using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public abstract class IPrenda
    {

        protected string id;
        protected ITipo calidadTipo;
        protected int cantidadEnStock;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public ITipo CalidadTipo
        {
            get { return calidadTipo; }
            set { calidadTipo = value; }
        }

        public int CantidadEnStock
        {
            get { return cantidadEnStock; }
            set { cantidadEnStock = value; }
        }

        public virtual float CalcularPrecio(float precio)
        {
            return calidadTipo.AjustarPrecio(precio);
        }

    }

    public class Pantalon : IPrenda
    {
        ITipo tipo;

        public Pantalon(string id,ITipo calidad, int cantidad, ITipo tipo)
        {
            this.id = id;
            calidadTipo= calidad;
            cantidadEnStock= cantidad;
            this.tipo= tipo;

        }

        public ITipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        } 
        public override float CalcularPrecio(float precio)
        {
            precio = tipo.AjustarPrecio(precio);
            return base.CalcularPrecio(precio);
        }
    }

    public class Camisa: IPrenda
    {
        ITipo mangaTipo;
        ITipo cuelloTipo;

        public Camisa(string id, ITipo calidad, int cantidad, ITipo manga, ITipo cuello)
        {
            this.id = id;
            calidadTipo = calidad;
            cantidadEnStock = cantidad;
            mangaTipo = manga;
            cuelloTipo = cuello;

        }

        public ITipo CuelloTipo
        {
            get { return cuelloTipo; }
            set { cuelloTipo = value;}
        }

        public ITipo MangaTipo
        {
            get { return mangaTipo; }
            set { mangaTipo = value;}
        }


        public override float CalcularPrecio(float precio)
        {
            precio = mangaTipo.AjustarPrecio(precio);
            precio = cuelloTipo.AjustarPrecio(precio);
            return base.CalcularPrecio(precio);
        }
    }


    public interface ITipo
    {
        public  float AjustarPrecio(float precio);
    }


    public class CalidadStandard : ITipo
    {
        public float AjustarPrecio(float precio)
        {
            return precio;
        }
    }

    public class CalidadPremium : ITipo
    {
        public float AjustarPrecio(float precio)
        {
            return precio*1.3f;
        }
    }


    public class PantalonChupin: ITipo
    {
        public float AjustarPrecio(float precio)
        {
            return precio * 0.88f;
        }
    }

    public class PantalonComun : ITipo
    {
        public float AjustarPrecio(float precio)
        {
            return precio;
        }
    }


    public class CuelloMao : ITipo
    {
        public float AjustarPrecio(float precio)
        {
            return precio * 1.03f;
        }
    }

    public class CuelloComun : ITipo
    {
        public float AjustarPrecio(float precio)
        {
            return precio;
        }
    }

    public class MangaCorta : ITipo
    {
        public float AjustarPrecio(float precio)
        {
            return precio * 0.9f;
        }
    }

    public class MangaLarga : ITipo
    {
        public float AjustarPrecio(float precio)
        {
            return precio;
        }
    }





}
