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
       
        CotizacionPrendaPresenter cotizacionPrendaPresenter;
        FormHistorialVendedor formHistorialVendedor;

        public event EventHandler<string> OnPrendaChange;
        public event EventHandler<string> OnTipoPantalonChange;
        public event EventHandler<string> OnTipoMangaChange;
        public event EventHandler<string> OnTipoCuelloChange;
        public event EventHandler<string> OnCalidadChange;
        public event EventHandler OnVerHistorialVendedor;


        public event EventHandler OnPresionarCotizar;

        public CotizacionPrendaView( CotizacionPrendaPresenter cotizacionPrendaPresenter )
        {
            InitializeComponent();
            this.cotizacionPrendaPresenter = cotizacionPrendaPresenter;
            this.cotizacionPrendaPresenter.Iniciar(this);


            formHistorialVendedor = new FormHistorialVendedor(this);
            AsociarEventos();    
        }


        void AsociarEventos()
        {
            rdBtnPantalon.Click += delegate { OnPrendaChange?.Invoke(this,"Pantalon"); };
            rdBtnCamisa.Click += delegate { OnPrendaChange?.Invoke(this,"Camisa"); };

            rdBtnPrendaStandard.Click += delegate { OnCalidadChange?.Invoke(this,"CalidadStandard"); };
            rdBtnPrendaPremium.Click += delegate { OnCalidadChange?.Invoke(this, "CalidadPremium"); };

            rdBtnPantalonChupin.Click += delegate { OnTipoPantalonChange?.Invoke(this, "Chupin"); };
            rdBtnPantalonComun.Click += delegate { OnTipoPantalonChange?.Invoke(this, "Comun"); };

            rdBtnMangaCorta.Click += delegate { OnTipoMangaChange?.Invoke(this, "MangaCorta"); };
            rdBtnMangaLarga.Click += delegate { OnTipoMangaChange?.Invoke(this, "MangaLarga"); };


            rdBtnCuelloMao.Click += delegate { OnTipoCuelloChange?.Invoke(this, "CuelloMao"); };
            rdBtnCuelloComun.Click += delegate { OnTipoCuelloChange?.Invoke(this, "CuelloComun"); };

            btnCotizarPrenda.Click += delegate { OnPresionarCotizar?.Invoke(this, EventArgs.Empty); };

            linklblHistorial.LinkClicked += delegate { OnVerHistorialVendedor?.Invoke(this, EventArgs.Empty); };
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

        public string MensajeError
        {
            get { return lblMensajeError.Text; }
            set { lblMensajeError.Text = value; }
  
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

        public string CantidadStockPrenda 
        {
            get { return lblUnidadesDisponibles.Text; } 
            set {
                lblUnidadesDisponibles.Text = value;
                if(value.Length > 0)
                {
                    btnCotizarPrenda.Enabled = true;
                }
                else
                {
                    btnCotizarPrenda.Enabled = false;
                    lblUnidadesDisponibles.Text = "_";
                }
            
            } 
        
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

        public void AgregarListado(string id, string fechaYhora, string idVendedor, string prenda, string cantidad, string resultado)
        {
            formHistorialVendedor.AgregarCotizacion( id,  fechaYhora,  idVendedor,  prenda,  cantidad,  resultado);
        }



        private void linklblHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHistorialVendedor.Show();
            this.Enabled = false;
        }

    }
}
