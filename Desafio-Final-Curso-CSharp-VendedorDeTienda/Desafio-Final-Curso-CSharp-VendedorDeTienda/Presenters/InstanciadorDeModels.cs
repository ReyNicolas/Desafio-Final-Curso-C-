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
            vendedor.Nombre = "nicolás";
            vendedor.Apellido = "rey";
            vendedor.Id = 123;
            vendedor.Tienda = tienda;
            return vendedor;
        }

        public Tienda InstanciarTienda(Tienda tienda)
        {
            tienda.Nombre = "todoropa";
            tienda.Direccion = "av. siempreviva 123";
            tienda.IdsToPrendas = new Dictionary<string, IPrenda>();


            CalidadPremium calidadPremium = new CalidadPremium();
            CalidadStandard calidadStandard = new CalidadStandard();

            PantalonComun pantalonComun = new PantalonComun();
            PantalonChupin pantalonChupin = new PantalonChupin();


            CuelloComun cuelloComun = new CuelloComun();
            CuelloMao cuelloMao = new CuelloMao();

            MangaCorta mangaCorta = new MangaCorta();
            MangaLarga mangaLarga = new MangaLarga();


            List<IPrenda> prendas = new List<IPrenda>();
            prendas.Add(new Pantalon("pantalon comun standard", calidadStandard, 250, pantalonComun));
            prendas.Add(new Pantalon("pantalon comun premium", calidadPremium, 250, pantalonComun));

            prendas.Add(new Pantalon("pantalon chupin standard", calidadStandard, 750, pantalonChupin));
            prendas.Add(new Pantalon("pantalon chupin premium", calidadPremium, 750, pantalonChupin));


            prendas.Add(new Camisa("camisa mangacorta cuellomao standard", calidadStandard, 100, mangaCorta, cuelloMao));
            prendas.Add(new Camisa("camisa mangacorta cuellomao premimum", calidadPremium, 100, mangaCorta, cuelloMao));

            prendas.Add(new Camisa("camisa mangacorta cuellocomun standard", calidadStandard, 150, mangaCorta, cuelloComun));
            prendas.Add(new Camisa("camisa mangacorta cuellocomun premimum", calidadPremium, 150, mangaCorta, cuelloComun));


            prendas.Add(new Camisa("camisa mangalarga cuellomao standard", calidadStandard, 75, mangaLarga, cuelloMao));
            prendas.Add(new Camisa("camisa mangalarga cuellomao premimum", calidadPremium, 75, mangaLarga, cuelloMao));

            prendas.Add(new Camisa("camisa mangalarga cuellocomun standard", calidadStandard, 175, mangaLarga, cuelloComun));
            prendas.Add(new Camisa("camisa mangalarga cuellocomun premimum", calidadPremium, 175, mangaLarga, cuelloComun));


            tienda.AgregarListaDePrendas(prendas);


            return tienda;
        }
        
    }
}
