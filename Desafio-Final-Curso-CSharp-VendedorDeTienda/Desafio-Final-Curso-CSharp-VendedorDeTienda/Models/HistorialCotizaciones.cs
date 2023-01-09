using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public interface IHistorialCotizacionesVendedores
    {
        public List<ICotizacion> DevolverCotizacionesDeVendedorId(int idVendedor);
    }
    
    public interface IHistorialCotizacionesCrear
    {
        public Cotizacion CrearCotizacionYDevolver();
    }

    public class HistorialCotizaciones: IHistorialCotizacionesVendedores , IHistorialCotizacionesCrear
    {
        static List<ICotizacion> listaCotizaciones;
        int newId;
        public HistorialCotizaciones(List<ICotizacion> cotizaciones, int newId)
        {
            listaCotizaciones = cotizaciones;
            this.newId = newId;
        }

        public Cotizacion CrearCotizacionYDevolver()
        {
            Cotizacion cotizacion = new Cotizacion();
            cotizacion.Id = newId;
            listaCotizaciones.Add(cotizacion);
            return cotizacion;
        }

        public List<ICotizacion> DevolverCotizacionesDeVendedorId(int idVendedor)
        {
         return   listaCotizaciones.FindAll(cotizacion => cotizacion.IdVendedor == idVendedor);
        }
        
    }

}
