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
    internal class CotizacionPrendaPresenter
    {
        Tienda tienda;
        Vendedor vendedor;
        InstanciadorDeModels instaciadorDeModelos;

        ICotizacionPrendaView cotizacionPrendaView;


        public CotizacionPrendaPresenter(ICotizacionPrendaView cotizacionPrendaView)
        {
            this.cotizacionPrendaView = cotizacionPrendaView;
            Iniciar();
        }

        void Iniciar()
        {
            instaciadorDeModelos= new InstanciadorDeModels();
            tienda= new Tienda();
            vendedor= new Vendedor();

            instaciadorDeModelos.InstanciarTienda(tienda);
            instaciadorDeModelos.InstanciarVendedor(vendedor);

        }
        
        public void Cotizar()
        {
            vendedor.Cotizar(cotizacionPrendaView.PrecioUnitario, cotizacionPrendaView.CantidadPrendaACotizar, cotizacionPrendaView.ResultadoCalculo);
        }
        

        

    }
}
