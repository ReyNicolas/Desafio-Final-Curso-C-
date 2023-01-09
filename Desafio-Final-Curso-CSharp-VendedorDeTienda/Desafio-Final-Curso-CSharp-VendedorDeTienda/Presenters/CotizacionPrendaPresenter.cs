using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Desafio_Final_Curso_CSharp_VendedorDeTienda.Models;
using Desafio_Final_Curso_CSharp_VendedorDeTienda.Views;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Presenters
{
    public  class CotizacionPrendaPresenter
    {
        Tienda tienda;
        Vendedor vendedor;
        InstanciadorDeModels instaciadorDeModelos;
        IHistorialCotizacionesCrear historialCotizaciones;
        IPrenda prendaACotizar;

 
        string prendaNombre="";  
        string calidad="";
        string prendaTipo = "";
        Dictionary<string, string> dicPropiedadesValor = new Dictionary<string, string>(); 

        ICotizacionPrendaView cotizacionPrendaView;


        public void Iniciar(ICotizacionPrendaView view)
        {
            cotizacionPrendaView = view;
            instaciadorDeModelos = new InstanciadorDeModels();
            tienda= new Tienda();

            tienda= instaciadorDeModelos.InstanciarTienda(tienda);
            historialCotizaciones = instaciadorDeModelos.InstanciarHistorialCotizaciones();
            vendedor = instaciadorDeModelos.InstanciarVendedor(tienda);
           


            cotizacionPrendaView.DireccionTienda = tienda.Direccion;
            cotizacionPrendaView.NombreTienda = tienda.Nombre;

            cotizacionPrendaView.IdVendedor = vendedor.Id.ToString();
            cotizacionPrendaView.NombreYApellidoVendedor = vendedor.Nombre + " " + vendedor.Apellido;


            cotizacionPrendaView.OnPrendaChange += CambiarPrendaNombre;
            cotizacionPrendaView.OnCalidadChange += CambiarCalidad;
            cotizacionPrendaView.OnTipoPantalonChange += CambiarTipoPantalon;
            cotizacionPrendaView.OnTipoMangaChange += CambiarTipoManga;
            cotizacionPrendaView.OnTipoCuelloChange += CambiarTipoCuello;

            cotizacionPrendaView.OnPresionarCotizar += Cotizar;
            cotizacionPrendaView.OnVerHistorialVendedor += MostrarHistorialVendedor;
        }


        void MostrarHistorialVendedor(object sender,EventArgs e)
        {
            foreach (ICotizacion cotizacion in vendedor.Cotizaciones)
           {
                cotizacionPrendaView.AgregarListado(cotizacion.Id.ToString(), cotizacion.FechaYHora, cotizacion.IdVendedor.ToString(), cotizacion.IdPrenda, cotizacion.CantidadPrendaCotizada.ToString(), cotizacion.ResultadoCalculo.ToString());
            }
        }
  
        void CambiarPrendaNombre(object sender, string nombre) 
        {
            prendaNombre = nombre;
            dicPropiedadesValor.Clear();
            CambiarPrendaACotizar();

        }

        void CambiarTipoPantalon(object sender, string tipo)
        {
            dicPropiedadesValor.Remove("Estilo");
            dicPropiedadesValor.Add("Estilo", tipo);
            CambiarPrendaACotizar();
        }

        void CambiarTipoManga(object sender, string tipo)
        {
            dicPropiedadesValor.Remove("Manga");
            dicPropiedadesValor.Add("Manga",tipo);
            CambiarPrendaACotizar();
        }

        void CambiarTipoCuello(object sender, string tipo)
        {
            dicPropiedadesValor.Remove("Cuello");
            dicPropiedadesValor.Add("Cuello", tipo);
            CambiarPrendaACotizar();
        }

        void CambiarCalidad(object sender, string unaCalidad)
        {
            calidad = unaCalidad;
            CambiarPrendaACotizar();
        }



        void CambiarPrendaACotizar()

        {
            string codPrenda="";

            if (prendaNombre == "Camisa" && dicPropiedadesValor.ContainsKey("Manga") && dicPropiedadesValor.ContainsKey("Cuello"))
            {
                prendaTipo = prendaNombre + dicPropiedadesValor["Manga"] + dicPropiedadesValor["Cuello"];
                codPrenda = prendaTipo + calidad;
            }
            if (prendaNombre == "Pantalon" && dicPropiedadesValor.ContainsKey("Estilo"))
            {
                prendaTipo = prendaNombre + dicPropiedadesValor["Estilo"];
                codPrenda =  prendaTipo + calidad;
            }

            if (tienda.IdsToPrendas.ContainsKey(codPrenda))
            {
                prendaACotizar = tienda.DevolverPrendaConId(codPrenda);
                ActualizarCantidadStockPrenda();
            }
            else
            {
                cotizacionPrendaView.CantidadStockPrenda = "";
            }
           
        }
               
        void ActualizarCantidadStockPrenda()
        {
            cotizacionPrendaView.CantidadStockPrenda = prendaACotizar.CantidadEnStock.ToString();
        }

        public void Cotizar(object sender, EventArgs e)
        {
            float precioUnitario=0;
            int cantidadACotizar=0;
            cotizacionPrendaView.MensajeError = "";

            try
            {
                precioUnitario = float.Parse(cotizacionPrendaView.PrecioUnitario);
                if (precioUnitario <= 0) throw new FormatException();
            } 
            catch(FormatException ex) 
            {
                cotizacionPrendaView.MensajeError += "El precio unitario debe ser un numero decimal positivo \n";
            }
            try
            {
                cantidadACotizar = int.Parse(cotizacionPrendaView.CantidadPrendaACotizar);
                if(cantidadACotizar <0 || cantidadACotizar > prendaACotizar.CantidadEnStock) throw new FormatException();
            }
            catch(FormatException ex)
            { 
                cotizacionPrendaView.MensajeError += "La cantidad a cotizar debe ser un numero entero positivo\n e inferior a la cantidad de stock \n";
            }
            if(cotizacionPrendaView.MensajeError.Length > 0)
            {
                return;
            }

            ICotizacion cotizacion = historialCotizaciones.CrearCotizacionYDevolver();
            cotizacion.IdPrenda = prendaACotizar.Id;
            vendedor.Cotizar(cotizacion,precioUnitario , cantidadACotizar,calidad, prendaACotizar.Tipo);
            cotizacionPrendaView.ResultadoCalculo = cotizacion.ResultadoCalculo.ToString();
        }
        

        

    }
}
