using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public interface IPrenda
    {
        public string Id { get; set; }
        public string CalidadId { get; set; }
        public int CantidadEnStock { get; set; }

        public float CalcularPrecio(float precio);

    }

    public interface ITipo
    {
        public string Id { set; get; } 
        public float MulitiplicadorDePrecio { get; set; }
    }

    
    public interface ICamisa
    {
        public string MangaId { get; set; }
        public string CuelloId { get; set; }
    }



    public interface IPantalon
    {
        public string TipoId { get; set; }
    }
   

   




  
}
