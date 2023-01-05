using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public interface IVendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public ICotizacion Cotizar();
    }


    public class Vendedor : IVendedor
    {
        int id;
        string nombre;
        string apellido;
        List<ICotizacion> cotizaciones = new List<ICotizacion>();



        public int Id 
        {
            get { return id; }
            set { id = value; } 
        
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }

        public ICotizacion Cotizar( float precioUnitario, )
        {
            ICotizacion cotizacion= new Cotizacion();
            this.cotizaciones.Add(cotizacion);
            return cotizacion;
        }
    }
}
