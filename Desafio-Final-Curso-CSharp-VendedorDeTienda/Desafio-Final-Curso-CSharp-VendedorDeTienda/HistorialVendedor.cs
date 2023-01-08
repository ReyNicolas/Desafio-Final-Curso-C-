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
    public partial class FormHistorialVendedor : Form
    {
        CotizacionPrendaView prendaView;
        public FormHistorialVendedor( CotizacionPrendaView vistaPadre )
        {
            InitializeComponent();
            this.ControlBox = false;   
            this.prendaView = vistaPadre;
        }

        public void AgregarCotizacion(string id, string fechaYhora, string idVendedor, string prenda, string cantidad, string resultado)
        {
            ListViewItem lista = new ListViewItem(id);
            lista.SubItems.Add(fechaYhora);
            lista.SubItems.Add(idVendedor);
            lista.SubItems.Add(prenda);
            lista.SubItems.Add(cantidad);
            lista.SubItems.Add(resultado);
            listViewHistorial.Items.Add(lista);
        }

        private void FormHistorialVendedor_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.prendaView.Show();
            this.prendaView.Enabled = true;
            listViewHistorial.Items.Clear();
            this.Hide();
            
            
        }
    }
}
