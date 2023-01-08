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
        IPrenda prendaACotizar;

        string prendaTipo ="";
        string prendaNombre="";
        string tipoPantalon="";
        string tipoManga="";
        string tipoCuello="";
        string calidad="";


        ICotizacionPrendaView cotizacionPrendaView;



        public void Iniciar(ICotizacionPrendaView view)
        {
            cotizacionPrendaView = view;
            instaciadorDeModelos = new InstanciadorDeModels();
            tienda= new Tienda();
            vendedor= new Vendedor();

            instaciadorDeModelos.InstanciarTienda(tienda);
            instaciadorDeModelos.InstanciarVendedor(vendedor, tienda);


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
            CambiarPrendaACotizar();

        }

        void CambiarTipoPantalon(object sender, string tipo)
        {
            tipoPantalon = tipo;
            prendaTipo = prendaNombre + tipo;
            CambiarPrendaACotizar();
        }

        void CambiarTipoManga(object sender, string tipo)
        {
            tipoManga = tipo;
            prendaTipo = prendaNombre + tipoManga + tipoCuello;
            CambiarPrendaACotizar();
        }

        void CambiarTipoCuello(object sender, string tipo)
        {
            tipoCuello = tipo;
            prendaTipo = prendaNombre + tipoManga + tipoCuello;
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

            if (prendaNombre == "Camisa")
            {
                codPrenda = prendaNombre + tipoManga + tipoCuello + calidad;
            }
            if (prendaNombre == "Pantalon")
            {
                codPrenda = prendaNombre +  tipoPantalon + calidad;
            }

            if (tienda.IdsToPrendas.ContainsKey(codPrenda))
            {
                prendaACotizar = tienda.IdsToPrendas[codPrenda];
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

            ICotizacion cotizacion = new Cotizacion();
            cotizacion.IdPrenda = prendaACotizar.Id;
            vendedor.Cotizar(cotizacion,precioUnitario , cantidadACotizar,calidad, prendaTipo);
            cotizacionPrendaView.ResultadoCalculo = cotizacion.ResultadoCalculo.ToString();
        }
        

        

    }
}
