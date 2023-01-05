using Desafio_Final_Curso_CSharp_VendedorDeTienda.Models;
using Desafio_Final_Curso_CSharp_VendedorDeTienda.Presenters;
using Desafio_Final_Curso_CSharp_VendedorDeTienda.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Desafio_Final_Curso_CSharp_VendedorDeTienda
{
    public partial class CotizacionPrendaView : Form, ICotizacionPrendaView
    {
        string prenda;
        string calidad;
        string tipoPantalon;
        string tipoManga;
        string tipoCuello;
        Dictionary<string, RadioButton> idToRdBtn;
        CotizacionPrendaPresenter cotizacionPrendaPresenter;

        public CotizacionPrendaView( CotizacionPrendaPresenter cotizacionPrendaPresenter )
        {
            InitializeComponent();
            this.cotizacionPrendaPresenter = cotizacionPrendaPresenter;
            this.cotizacionPrendaPresenter.Iniciar(this);
            idToRdBtn = new Dictionary<string, RadioButton>();
            idToRdBtn.Add("Pantalon",rdBtnPantalon);
            idToRdBtn.Add("PantalonComun", rdBtnPantalonComun);
            idToRdBtn.Add("Chupin", rdBtnPantalonChupin);

            idToRdBtn.Add("CalidadStandard", rdBtnPrendaStandard);
            idToRdBtn.Add("CalidadPremium", rdBtnPrendaPremium);

            idToRdBtn.Add("Camisa", rdBtnCamisa);
            idToRdBtn.Add("MangaCorta", rdBtnMangaCorta);
            idToRdBtn.Add("MangaLarga", rdBtnMangaLarga);

            idToRdBtn.Add("CuelloMao", rdBtnCuelloMao);
            idToRdBtn.Add("CuelloComun", rdBtnCuelloComun);
        }


        public string Prenda 
        { 
            get { return prenda; } 
            set {
                prenda = value;
                if (!idToRdBtn[prenda].Checked) idToRdBtn[prenda].Checked = true;
            }

        
        }
        public string Calidad
        {
            get { return calidad; }
            set
            {
                calidad = value;
                if (!idToRdBtn[calidad].Checked) idToRdBtn[calidad].Checked = true;
            }


        }
        public string TipoPantalon
        {
            get { return tipoPantalon; }
            set
            {
                tipoPantalon = value;
                if(!idToRdBtn[tipoPantalon].Checked) idToRdBtn[tipoPantalon].Checked = true;
            }


        }
        public string TipoManga
        {
            get { return tipoManga; }
            set
            {
                tipoManga = value;
                if (!idToRdBtn[tipoManga].Checked) idToRdBtn[tipoManga].Checked = true;
            }


        }
        public string TipoCuello
        {
            get { return tipoCuello; }
            set
            {
                tipoCuello = value;
                if (!idToRdBtn[tipoCuello].Checked) idToRdBtn[tipoCuello].Checked = true; 
            }


        }

        public string NombreTienda 
        {
            get { return lblNombreTienda.Text; } 
            set { lblNombreTienda.Text = value; } 
        }
       
        public string DireccionTienda
        {
            get { return lblDireccionTienda.Text; }
            set { lblDireccionTienda.Text = value; }
        }


        public string NombreYApellidoVendedor 
        {
            set { lblNombreApellidoVendedor.Text = value; } 
        }

        public string IdVendedor 
        { 
            get { return lblCodigoVendedor.Text; } 
            set { lblCodigoVendedor.Text= value; }
        }





        public string PrecioUnitario 
        {
            get { return txtBoxPrecioUnitario.Text; }
            set { txtBoxPrecioUnitario.Text = value ; }
        }
        
        public string CantidadPrendaACotizar 
        {
            get { return txtBoxCantidadACotizar.Text; } 
            set { txtBoxCantidadACotizar.Text = value; }
        }

        public string ResultadoCalculo 
        { 
            get { return lblResultadoPrecioMostrar.Text; }
            set { lblResultadoPrecioMostrar.Text= value; } 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

       

        private void txtBoxPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            //TODO: cambiar resultado
        }

        

        private void txtBoxCantidadACotizar_TextChanged(object sender, EventArgs e)
        {
            //TODO: cambiar resultado
        }


        private void rdBtnPrendaStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPrendaStandard.Checked) calidad = "CalidadStandard";
            //TODO: cambiar prenda
        }

        private void rdBtnPrendaPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPrendaPremium.Checked) calidad = "CalidadPremium";
        }



        private void rdBtnCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnCamisa.Checked) prenda = "Camisa";
        }
        private void rdBtnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPantalon.Checked) prenda = "Pantalon";
        }



        private void rdBtnPantalonComun_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPantalonComun.Checked) tipoPantalon = "PantalonComun";
        }

        private void rdBtnPantalonChupin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnPantalonChupin.Checked) tipoPantalon = "Chupin";
            //TODO: cambiar prenda
        }


        
        private void rdBtnCuelloComun_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnCuelloComun.Checked) tipoCuello = "CuelloComun";
            //TODO: cambiar prenda
        }

        private void rdBtnCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnCuelloComun.Checked) tipoCuello = "CuelloComun";
        }



        private void rdBtnMangaLarga_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnMangaLarga.Checked) tipoManga = "MangaLarga";
            //TODO: cambiar prenda
        }
                    

        private void rdBtnMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnMangaCorta.Checked) TipoManga = "MangaCorta"; 
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //public event EventHandler CotizarEvent;

    }
}
