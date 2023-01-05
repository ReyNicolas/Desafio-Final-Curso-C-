using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public interface ICotizacion
    {
        public int Id { get; set; }
        public string FechaYHora { get; set; }
        public int IdVendedor { get; set; }
        public int IdPrenda { get; set; }
        public float PrecioUnitario { get; set; }
        public int CantidadPrendaCotizada { get; set; }
        public float ResultadoCalculo { get; set; }
      
    }


    public class Cotizacion: ICotizacion
    {
        int id;
        string fechaYHora;
        int idVendedor;
        int idPrenda;
        float precioUnitario;
        int cantidadPrendaCotizada;
        float resultadoCalculo;


        public int Id 
        { 
            get { return id; } 
            set { id = value; }
        }
        public string FechaYHora
        {
            get { return fechaYHora; }
            set { fechaYHora = value; }
        }

        public int IdVendedor
        {
            get { return idVendedor; }
            set { idVendedor = value; }
        }

        public int IdPrenda
        {
            get { return idPrenda; }
            set { idPrenda = value; }
        }

        public float PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public int CantidadPrendaCotizada
        {
            get { return cantidadPrendaCotizada; }
            set { cantidadPrendaCotizada = value; }
        }

        public float ResultadoCalculo
        {
            get { return resultadoCalculo; }
            set { resultadoCalculo = value; }
        }

    }
}
