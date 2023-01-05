using Desafio_Final_Curso_CSharp_VendedorDeTienda.Models;
using Desafio_Final_Curso_CSharp_VendedorDeTienda.Presenters;

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
            //Application.Run(new CotizacionPrendaView());
            Application.Run(new CotizacionPrendaView(new CotizacionPrendaPresenter()));

            


        }
    }
}