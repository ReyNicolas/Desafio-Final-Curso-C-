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
        public FormHistorialVendedor()
        {
            InitializeComponent();
            
        }

        
        private void HistorialVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
