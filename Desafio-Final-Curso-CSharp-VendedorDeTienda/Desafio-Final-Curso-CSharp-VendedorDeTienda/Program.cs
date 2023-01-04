using Desafio_Final_Curso_CSharp_VendedorDeTienda.Models;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CotizacionPrendaView());


            Vendedor vendedor = new Vendedor("Nicolás", "Rey", "nfpersc");

            Tienda tienda = new Tienda("TodoRopa", "Av. SiempreViva 123", new List<Prenda>());
            

            CalidadPremium calidadPremium = new CalidadPremium();
            CalidadStandard calidadStandard = new CalidadStandard();

            Comun comun = new Comun();
            Chupin chupin = new Chupin();

            CuelloComun cuelloComun = new CuelloComun();
            CuelloMao cuelloMao= new CuelloMao();

            MangaCorta mangaCorta= new MangaCorta();
            MangaLarga mangaLarga= new MangaLarga();


            List<Prenda> prendas= new List<Prenda>();
            prendas.Add(new Pantalon("Pantalon Comun Standard", calidadStandard, 250, comun));
            prendas.Add(new Pantalon("Pantalon Comun Premium", calidadPremium, 250, comun));
            
            prendas.Add(new Pantalon("Pantalon Chupin Standard", calidadStandard, 750, chupin));
            prendas.Add(new Pantalon("Pantalon Chupin Premium", calidadPremium, 750, chupin));


            prendas.Add(new Camisa("Camisa MangaCorta CuelloMao Standard", calidadStandard, 100, mangaCorta, cuelloMao));
            prendas.Add(new Camisa("Camisa MangaCorta CuelloMao Premimum", calidadPremium, 100, mangaCorta, cuelloMao ));

            prendas.Add(new Camisa("Camisa MangaCorta CuelloComun Standard", calidadStandard, 150, mangaCorta, cuelloComun));
            prendas.Add(new Camisa("Camisa MangaCorta CuelloComun Premimum", calidadPremium, 150, mangaCorta, cuelloComun));

            
            prendas.Add(new Camisa("Camisa MangaLarga CuelloMao Standard", calidadStandard, 75, mangaLarga, cuelloMao));
            prendas.Add(new Camisa("Camisa MangaLarga CuelloMao Premimum", calidadPremium, 75, mangaLarga, cuelloMao));

            prendas.Add(new Camisa("Camisa MangaLarga CuelloComun Standard", calidadStandard, 175, mangaLarga, cuelloComun));
            prendas.Add(new Camisa("Camisa MangaLarga CuelloComun Premimum", calidadPremium, 175, mangaLarga, cuelloComun));


        }
    }
}