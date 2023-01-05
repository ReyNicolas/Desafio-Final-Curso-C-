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


        ICotizacionPrendaView cotizacionPrendaView;



        public void Iniciar(ICotizacionPrendaView cotizacionPrendaView)
        {
            this.cotizacionPrendaView = cotizacionPrendaView;
            instaciadorDeModelos = new InstanciadorDeModels();
            tienda= new Tienda();
            vendedor= new Vendedor();

            instaciadorDeModelos.InstanciarTienda(tienda);
            instaciadorDeModelos.InstanciarVendedor(vendedor, tienda);


            cotizacionPrendaView.DireccionTienda = tienda.Direccion;
            cotizacionPrendaView.NombreTienda = tienda.Nombre;

            cotizacionPrendaView.IdVendedor = vendedor.Id.ToString();
            cotizacionPrendaView.NombreYApellidoVendedor = vendedor.Nombre + " " + vendedor.Apellido;
            

        }
  
        void CambiarPrendaACotizar()

        {
            string codPrenda;

            if (cotizacionPrendaView.Prenda == "Camisa")
            {
                codPrenda = cotizacionPrendaView.Prenda + " " + cotizacionPrendaView.Calidad + " " + cotizacionPrendaView.TipoManga + " " + cotizacionPrendaView.TipoCuello;
            }
            else
            {
                codPrenda = cotizacionPrendaView.Prenda + " " + cotizacionPrendaView.Calidad + " " + cotizacionPrendaView.TipoPantalon;
            }

            prendaACotizar = tienda.IdsToPrendas[codPrenda];
        }

        void ActualizarCantidadPrenda()
        {
            cotizacionPrendaView.CantidadPrendaACotizar = prendaACotizar.CantidadEnStock.ToString();
        }

        public void Cotizar()
        {
            ICotizacion cotizacion = new Cotizacion();
            cotizacion.IdPrenda = prendaACotizar.Id;
            vendedor.Cotizar(cotizacion, float.Parse(cotizacionPrendaView.PrecioUnitario), int.Parse(cotizacionPrendaView.CantidadPrendaACotizar));
        }
        

        

    }
}
