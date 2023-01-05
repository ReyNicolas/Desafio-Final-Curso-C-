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
        public CotizacionPrendaView()
        {
            InitializeComponent();
        }


        public string CodTipoPrenda
        {
            get { }
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



        private void rdBtnCuelloMao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdBtnCuelloComun_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: cambiar prenda
        }

        private void rdBtnMangaLarga_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: cambiar prenda
        }

        private void rdBtnPrendaStandard_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: cambiar prenda
        }

        private void rdBtnPantalonChupin_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: cambiar prenda
        }

        private void txtBoxPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            txtBoxPrecioUnitario.Text.
        }

        //public event EventHandler CotizarEvent;

    }
}
