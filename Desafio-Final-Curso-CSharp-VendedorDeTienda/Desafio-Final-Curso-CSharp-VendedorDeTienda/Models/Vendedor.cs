using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public interface IVendedor
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


    }
}
