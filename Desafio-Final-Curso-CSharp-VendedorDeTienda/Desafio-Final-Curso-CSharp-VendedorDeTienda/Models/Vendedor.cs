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
        public Tienda Tienda { get; set; }

        public List<ICotizacion> Cotizaciones { get; }
        public ICotizacion Cotizar(ICotizacion cotizacion, float precioUnitario, int cantidad, string calidad, TipoPrenda tipo);
    }


    public class Vendedor : IVendedor
    {
        int id;
        string nombre;
        string apellido;
        Tienda tienda;
        IAjustarPrecioTipoPrendaTipoCalidad ajustador;
        IHistorialCotizacionesVendedores historialCotizaciones;

        public Vendedor(int id, string nombre, string apellido, Tienda tienda, IAjustarPrecioTipoPrendaTipoCalidad ajustador, IHistorialCotizacionesVendedores historialCotizaciones)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tienda = tienda;
            this.ajustador = ajustador;
            this.historialCotizaciones = historialCotizaciones;
        }

        public IAjustarPrecioTipoPrendaTipoCalidad Ajustador
        {
            get { return ajustador; }
            set { ajustador = value; }
        }

        public Tienda Tienda
        {
            get { return tienda; }
            set { tienda = value; }
        }
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

        public List<ICotizacion> Cotizaciones 
        {
            get { return historialCotizaciones.DevolverCotizacionesDeVendedorId(id); }
        }
        public ICotizacion Cotizar(ICotizacion cotizacion, float precioUnitario, int cantidad, string calidad, TipoPrenda tipo)
        {
            cotizacion.PrecioUnitario = precioUnitario;
            cotizacion.CantidadPrendaCotizada = cantidad;
            cotizacion.ResultadoCalculo = ajustador.AjustarPrecioPrendaConTipoYCalidad(precioUnitario, tipo, calidad) * cantidad;
            cotizacion.FechaYHora = DateTime.Now.ToString();
            cotizacion.IdVendedor = id;

            return cotizacion;
        }
    }
}
