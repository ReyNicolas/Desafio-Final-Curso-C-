using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public interface ITienda
    {
        
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<string> IdsPrendas { get; set; }


    }

    
}
