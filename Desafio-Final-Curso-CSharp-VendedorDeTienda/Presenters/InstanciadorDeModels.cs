using Desafio_Final_Curso_CSharp_VendedorDeTienda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda.Presenters
{
    internal class InstanciadorDeModels
    {

        public Vendedor InstanciarVendedor(Vendedor vendedor, Tienda tienda)
        {
            

            Dictionary<string, ITipoAjustarPrecioPrenda> ajustadores = new Dictionary<string, ITipoAjustarPrecioPrenda>();

            AjustarPrecioMultiplicar ajustadorMCamisaMangaCorta = new AjustarPrecioMultiplicar(0.9f);
            AjustarPrecioMultiplicar ajustadorMCamisaCuelloMao = new AjustarPrecioMultiplicar(1.03f);
            AjustarPrecioMultiplicarTrasAnidado ajustarMCamisaMangaCortaCuelloMao = new AjustarPrecioMultiplicarTrasAnidado(1.03f, ajustadorMCamisaMangaCorta);
            AjustarPrecioMultiplicar ajustadorMPantalonChupin = new AjustarPrecioMultiplicar(0.88f);
            AjustarPrecioMultiplicar ajustadorMCalidadPremium = new AjustarPrecioMultiplicar(1.3f);

            ajustadores.Add("CamisaMangaCortaCuelloComun", ajustadorMCamisaMangaCorta);
            ajustadores.Add("CamisaMangaCortaCuelloMao", ajustarMCamisaMangaCortaCuelloMao);
            ajustadores.Add("CamisaMangaLargaCuelloMao", ajustadorMCamisaCuelloMao);
            ajustadores.Add("PantalonChupin", ajustadorMPantalonChupin);
            ajustadores.Add("CalidadPremium", ajustadorMCalidadPremium);


            
            vendedor.Nombre = "Nicolás";
            vendedor.Apellido = "Rey";
            vendedor.Id = 123;
            vendedor.Tienda = tienda;
            vendedor.Ajustador = new AjustarPrecioTipoPrendaTipoCalidad(ajustadores);
            return vendedor;

        }

        public Tienda InstanciarTienda(Tienda tienda)
        {
            tienda.Nombre = "RodoRopa";
            tienda.Direccion = "Av. Siempreviva 123";
            tienda.IdsToPrendas = new Dictionary<string, IPrenda>();


            List<IPrenda> prendas = new List<IPrenda>();
           

            prendas.Add(new Prenda("PantalonComun", "CalidadStandard", 250));
            prendas.Add(new Prenda("PantalonComun", "CalidadPremium", 250));

            prendas.Add(new Prenda("PantalonChupin", "CalidadStandard", 750));
            prendas.Add(new Prenda("PantalonChupin", "CalidadPremium", 750));

            prendas.Add(new Prenda("CamisaMangaCortaCuelloMao", "CalidadStandard", 100));
            prendas.Add(new Prenda("CamisaMangaCortaCuelloMao", "CalidadPremium", 100));

            prendas.Add(new Prenda("CamisaMangaCortaCuelloComun", "CalidadStandard", 150));
            prendas.Add(new Prenda("CamisaMangaCortaCuelloComun", "CalidadPremium", 150));

            prendas.Add(new Prenda("CamisaMangaLargaCuelloMao", "CalidadStandard", 75));
            prendas.Add(new Prenda("CamisaMangaLargaCuelloMao", "CalidadPremium", 75));

            prendas.Add(new Prenda("CamisaMangaLargaCuelloComun", "CalidadStandard", 175));
            prendas.Add(new Prenda("CamisaMangaLargaCuelloComun", "CalidadPremium", 175));

            tienda.AgregarListaDePrendas(prendas);           

            return tienda;
        }

            



          
        
    }
}
