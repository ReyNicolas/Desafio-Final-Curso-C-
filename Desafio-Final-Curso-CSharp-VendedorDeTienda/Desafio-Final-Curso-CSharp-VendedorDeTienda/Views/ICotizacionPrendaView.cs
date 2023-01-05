using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Views
{
     public interface ICotizacionPrendaView
    {
        // public string Id { get; set; }
        // public string fechaYHora { get; set; }
        //public string IdPrenda { get; set; }


        
        public  string NombreTienda { get; set; }
        public string DireccionTienda { get; set; }


        public string NombreYApellidoVendedor {  set; }    
        public string IdVendedor { get; set; }


        public string Prenda { get; set; }
        public string Calidad { get; set; }
        public string TipoPantalon { get; set; }
        public string TipoManga { get; set; }
        public string TipoCuello { get; set; }
        public string PrecioUnitario { get; set; }
        public string CantidadPrendaACotizar { get; set; }
        public string ResultadoCalculo { get; set; }


        //public event EventHandler CotizarEvent;
    }

   
}
