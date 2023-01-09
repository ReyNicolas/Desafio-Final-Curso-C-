using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public class TipoPrenda
    {       
        string id;
        string nombre;
        Dictionary<string, string> propiedades;
     
        public TipoPrenda(string nombre)
        {
            this.nombre = nombre;
            id = nombre;
            propiedades = new Dictionary<string, string>();
        }

        public TipoPrenda AgregarPropiedadConValor(string unaPropiedad, string unValor)
        {
            propiedades.Add(unaPropiedad, unValor);
            id += unaPropiedad + unValor;
            return this;
        }
        public string Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string ValorPropiedad(string propiedad)
        {
            if (propiedades.ContainsKey(propiedad))
            {
                return propiedades[propiedad];
            }
            else
            {
                return "";
            }
        }

    }

}
