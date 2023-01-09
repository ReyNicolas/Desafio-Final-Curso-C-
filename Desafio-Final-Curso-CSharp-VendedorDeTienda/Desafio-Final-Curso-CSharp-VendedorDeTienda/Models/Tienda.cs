using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Models
{
    public interface ITienda
    {
        
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Dictionary<string, IPrenda> IdsToPrendas { get; set; }

        public void AgregarPrenda(IPrenda prenda);

        public void AgregarListaDePrendas(List<IPrenda> prendas);
        public IPrenda DevolverPrendaConId(string id);
    }
    public class Tienda: ITienda
    {
        string nombre, direccion;
        Dictionary<string, IPrenda> idsToPrendas;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public Dictionary<string, IPrenda> IdsToPrendas { get { return idsToPrendas; } set { idsToPrendas = value; } }

        public void AgregarPrenda(IPrenda prenda)
        {
            idsToPrendas.Add(prenda.Id, prenda);
        }

        public void AgregarListaDePrendas(List<IPrenda> prendas)
        {
            foreach (IPrenda prenda in prendas)
            {
                AgregarPrenda(prenda);
            }
        }
        public IPrenda DevolverPrendaConId(string id)
        {
            return idsToPrendas[id];
        }


    }

    
}
