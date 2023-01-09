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
        public string Id { get;}
        public string IdCalidad { get; }
        public string IdTipo { get;}

        public TipoPrenda Tipo { get; }
        public int CantidadEnStock { get; set; }
    }


    public class Prenda : IPrenda
    {
        string id;
        string idCalidad;
        TipoPrenda tipoPrenda;
        int cantidadEnStock;
        public Prenda(TipoPrenda tipoPrenda, string idCalidad, int cantidad)
        {
            this.idCalidad = idCalidad;
            this.tipoPrenda = tipoPrenda;
            cantidadEnStock = cantidad;
            id = tipoPrenda.Id + idCalidad;
        }
        public string Id
        {
            get { return id; }
        }

        public TipoPrenda Tipo
        {
            get { return tipoPrenda; }
        }

        public string IdCalidad
        {
            get { return idCalidad; }
        }
        public string IdTipo
        {
            get { return tipoPrenda.Id; }
        }
        public int CantidadEnStock
        {
            get { return cantidadEnStock; }
            set { cantidadEnStock = value; }
        }
    }


   




}
