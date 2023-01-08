using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{

    public interface IPrenda
    {
        public string Id { get; set; }
        public string IdCalidad { get; set; }
        public string IdTipo { get; set; }

        public int CantidadEnStock { get; set; }
    }


    public class Prenda : IPrenda
    {
        string id;
        string idCalidad;
        string idTipo;
        int cantidadEnStock;
        public Prenda(string idTipo, string idCalidad, int cantidad)
        {
            this.idCalidad = idCalidad;
            this.idTipo = idTipo;
            cantidadEnStock = cantidad;
            id = idTipo + idCalidad;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string IdCalidad
        {
            get { return idCalidad; }
            set { idCalidad = value; }
        }
        public string IdTipo
        {
            get { return idTipo; }
            set { idTipo = value; }
        }
        public int CantidadEnStock
        {
            get { return cantidadEnStock; }
            set { cantidadEnStock = value; }
        }
    }


    public interface ITipoAjustarPrecioPrenda
    {
        public float AjustarPrecio(float precio);
    }

    public class AjustarPrecioMultiplicar : ITipoAjustarPrecioPrenda
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

    public class AjustarPrecioMultiplicarTrasAnidado : ITipoAjustarPrecioPrenda
    {
        float multiplicador;
        ITipoAjustarPrecioPrenda otroAjustador;

        public AjustarPrecioMultiplicarTrasAnidado(float valor, ITipoAjustarPrecioPrenda ajustador)
        {
            multiplicador = valor;
            otroAjustador = ajustador;
        }

        public float AjustarPrecio(float precio)
        {
            return otroAjustador.AjustarPrecio(precio) * multiplicador;
        }

    }

    public class AjustarPrecioTipoPrendaTipoCalidad
    {
        Dictionary<string, ITipoAjustarPrecioPrenda> idToAjustadores;
        public AjustarPrecioTipoPrendaTipoCalidad(Dictionary<string, ITipoAjustarPrecioPrenda> idToAjustadores)
        {
            this.idToAjustadores = idToAjustadores;
        }

        public float AjustarPrecioPrendaConTipoYCalidad(float precio, string tipo, string calidad)
        {
            if (idToAjustadores.ContainsKey(tipo))
            {
                precio = idToAjustadores[tipo].AjustarPrecio(precio);
            }
            if (idToAjustadores.ContainsKey(calidad))
            {
                precio = idToAjustadores[calidad].AjustarPrecio(precio);
            }

            return precio;
        }

    }




}
