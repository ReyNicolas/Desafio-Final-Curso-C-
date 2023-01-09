using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public interface IAjustarPrecio
    {
        public float AjustarPrecio(float precio);
    }

    public class AjustarPrecioMultiplicar : IAjustarPrecio
    {
        float multiplicador;

        public AjustarPrecioMultiplicar(float valor)
        {
            multiplicador = valor;
        }
        public float AjustarPrecio(float precio)
        {
            return precio * multiplicador;
        }
    }

    public interface ITipoAjustarPrecio
    {
        public float AjustarPrecioEnBaseATipoPrenda(float precio, TipoPrenda tipo);
    }


    internal class AjustadorTipoCamisa : ITipoAjustarPrecio
    {
        Dictionary<string, IAjustarPrecio> ajustadoresPropiedades;


        public AjustadorTipoCamisa(Dictionary<string, IAjustarPrecio> ajustadoresPropiedades)
        {
            this.ajustadoresPropiedades = ajustadoresPropiedades;
        }

        public float AjustarPrecioEnBaseATipoPrenda(float precio, TipoPrenda tipo)
        {

            if (ajustadoresPropiedades.ContainsKey("CamisaManga" + tipo.ValorPropiedad("Manga")))
            {
                precio = ajustadoresPropiedades["CamisaManga" + tipo.ValorPropiedad("Manga")].AjustarPrecio(precio);
            }
            if (ajustadoresPropiedades.ContainsKey("CamisaCuello" + tipo.ValorPropiedad("Cuello")))
            {
                precio = ajustadoresPropiedades["CamisaCuello" + tipo.ValorPropiedad("Cuello")].AjustarPrecio(precio);
            }


            return precio;
        }

    }
    internal class AjustadorTipoPantalon : ITipoAjustarPrecio
    {
        Dictionary<string, IAjustarPrecio> ajustadoresPropiedades;


        public AjustadorTipoPantalon(Dictionary<string, IAjustarPrecio> ajustadoresPropiedades)
        {
            this.ajustadoresPropiedades = ajustadoresPropiedades;
        }

        public float AjustarPrecioEnBaseATipoPrenda(float precio, TipoPrenda tipo)
        {

            if (ajustadoresPropiedades.ContainsKey("PantalonEstilo" + tipo.ValorPropiedad("Estilo")))
            {
                precio = ajustadoresPropiedades["PantalonEstilo" + tipo.ValorPropiedad("Estilo")].AjustarPrecio(precio);
            }

            return precio;
        }
    }

    public interface IAjustarPrecioTipoPrendaTipoCalidad
    {
        public float AjustarPrecioPrendaConTipoYCalidad(float precio, TipoPrenda tipo, string calidad);
    }


    public class AjustarPrecioTipoPrendaTipoCalidad: IAjustarPrecioTipoPrendaTipoCalidad
    {
        Dictionary<string, IAjustarPrecio> idToAjustadores;
        Dictionary<string, ITipoAjustarPrecio> nombreTipoToAjustadorTipo;
        public AjustarPrecioTipoPrendaTipoCalidad(Dictionary<string, IAjustarPrecio> idToAjustadores, Dictionary<string, ITipoAjustarPrecio> nombreTipoToAjustadorTipo)
        {
            this.idToAjustadores = idToAjustadores;
            this.nombreTipoToAjustadorTipo = nombreTipoToAjustadorTipo;
        }

        public float AjustarPrecioPrendaConTipoYCalidad(float precio, TipoPrenda tipo, string calidad)
        {
            if (nombreTipoToAjustadorTipo.ContainsKey(tipo.Nombre))
            {
                precio = nombreTipoToAjustadorTipo[tipo.Nombre].AjustarPrecioEnBaseATipoPrenda(precio, tipo);
            }
            if (idToAjustadores.ContainsKey(calidad))
            {
                precio = idToAjustadores[calidad].AjustarPrecio(precio);
            }

            return  precio;
        }

    }

    

}
