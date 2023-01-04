using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public interface ICotizacion
    {
       

        public string Id { get; set; }
        public string fechaYHora { get; set; }
        public string IdVendedor { get; set; }
        public string IdPrenda { get; set; }
        public int PrecioUnitario { get; set; }
        public int CantidadPrendaCotizada { get; set; }
        public float ResultadoCalculo { get; set; }



       
    }
}
