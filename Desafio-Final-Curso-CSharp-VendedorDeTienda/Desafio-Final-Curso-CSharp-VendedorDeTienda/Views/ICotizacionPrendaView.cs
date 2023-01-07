using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Views
{
     public interface ICotizacionPrendaView
    {
                       
        public  string NombreTienda { get; set; }
        public string DireccionTienda { get; set; }


        public string NombreYApellidoVendedor {  set; }    
        public string IdVendedor { get; set; }


        public string PrecioUnitario { get; set; }

        public string CantidadStockPrenda { get; set; }

        public string CantidadPrendaACotizar { get; set; }
        public string ResultadoCalculo { get; set; }

        public string MensajeError { get; set; }

        public event EventHandler<string>  OnPrendaChange;
        public event EventHandler<string> OnTipoPantalonChange;
        public event EventHandler<string> OnTipoMangaChange;
        public event EventHandler<string> OnTipoCuelloChange;
        public event EventHandler<string> OnCalidadChange;

        public event EventHandler OnPresionarCotizar;
    }


}
