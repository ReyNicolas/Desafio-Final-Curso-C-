using Desafio_Final_Curso_CSharp_VendedorDeTienda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Presenters
{
    public class InstanciadorDeModels
    {
        HistorialCotizaciones historialCotizaciones;
        public IHistorialCotizacionesCrear InstanciarHistorialCotizaciones()
        {
            historialCotizaciones = new HistorialCotizaciones(new List<ICotizacion>(), 1);
            return historialCotizaciones;
        }

        public Vendedor InstanciarVendedor(Tienda tienda)
        {


            Dictionary<string, IAjustarPrecio> ajustadores = new Dictionary<string, IAjustarPrecio>();
            Dictionary<string, ITipoAjustarPrecio> ajustadoresTipo = new Dictionary<string, ITipoAjustarPrecio>();


            ajustadores.Add("CamisaMangaCorta", new AjustarPrecioMultiplicar(0.9f));
            ajustadores.Add("CamisaCuelloMao", new AjustarPrecioMultiplicar(1.03f));
            ajustadores.Add("PantalonEstiloChupin", new AjustarPrecioMultiplicar(0.88f));
            ajustadores.Add("CalidadPremium", new AjustarPrecioMultiplicar(1.3f));


            ajustadoresTipo.Add("Camisa", new AjustadorTipoCamisa(ajustadores));
            ajustadoresTipo.Add("Pantalon", new AjustadorTipoPantalon(ajustadores));


            Vendedor vendedor = new Vendedor(123, "Nicolás", "Rey", tienda, new AjustarPrecioTipoPrendaTipoCalidad(ajustadores, ajustadoresTipo), historialCotizaciones);         
            return vendedor;

        }

        public Tienda InstanciarTienda(Tienda tienda)
        {
            tienda.Nombre = "RodoRopa";
            tienda.Direccion = "Av. Siempreviva 123";
            tienda.IdsToPrendas = new Dictionary<string, IPrenda>();
            tienda.AgregarListaDePrendas(InstaciarListaDePrenda());

            return tienda;
        }

        public List<IPrenda> InstaciarListaDePrenda()
        {
            List<IPrenda> prendas = new List<IPrenda>();

            prendas.Add(CrearPantalon("Comun","CalidadStandard",250 ));
            prendas.Add(CrearPantalon("Comun", "CalidadPremium", 250 ));

            prendas.Add(CrearPantalon("Chupin", "CalidadStandard", 750));
            prendas.Add(CrearPantalon("Chupin", "CalidadPremium", 750));

            prendas.Add(CrearCamisa("Corta", "Mao", "CalidadPremium", 100));
           prendas.Add( CrearCamisa("Corta", "Mao", "CalidadStandard", 100));

            prendas.Add(CrearCamisa("Corta", "Comun", "CalidadPremium", 150));
            prendas.Add(CrearCamisa("Corta", "Comun", "CalidadStandard", 150));

            prendas.Add(CrearCamisa("Larga", "Mao", "CalidadPremium", 75));
            prendas.Add(CrearCamisa("Larga", "Mao", "CalidadStandard", 75));

            prendas.Add(CrearCamisa("Larga", "Comun", "CalidadPremium", 175));
            prendas.Add(CrearCamisa("Larga", "Comun", "CalidadStandard", 175));

            return prendas;

        }


        public Prenda CrearCamisa(string manga, string cuello, string calidad, int cantidad)
        {
            TipoPrenda tipo = new TipoPrenda("Camisa").AgregarPropiedadConValor("Manga", manga).AgregarPropiedadConValor("Cuello", cuello);
           

            return new Prenda(tipo,calidad,cantidad);
        }

        public Prenda CrearPantalon(string estilo,string calidad, int cantidad)
        {
            TipoPrenda tipo =  new TipoPrenda("Pantalon").AgregarPropiedadConValor("Estilo", estilo);
           
            return new Prenda(tipo, calidad, cantidad);
        }


    }
}
