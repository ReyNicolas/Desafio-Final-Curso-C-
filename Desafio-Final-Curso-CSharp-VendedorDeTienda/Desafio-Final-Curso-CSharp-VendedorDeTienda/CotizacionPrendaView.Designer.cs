using Desafio_Final_Curso_CSharp_VendedorDeTienda.Views;

namespace Desafio_Final_Curso_CSharp_VendedorDeTienda
{
    partial class CotizacionPrendaView: Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblCodVendedorText = new System.Windows.Forms.Label();
            this.linklblHistorial = new System.Windows.Forms.LinkLabel();
            this.lblCodigoVendedor = new System.Windows.Forms.Label();
            this.lblNombreApellidoVendedor = new System.Windows.Forms.Label();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.gpBoxPrecioUnitarioYCantidad = new System.Windows.Forms.GroupBox();
            this.txtBoxCantidadACotizar = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblCantidadACotizar = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblResultadoPrecioMostrar = new System.Windows.Forms.Label();
            this.lblResultadoPrecioTexto = new System.Windows.Forms.Label();
            this.btnCotizarPrenda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUnidadesDisponibles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPrendas = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdBtnCuelloMao = new System.Windows.Forms.RadioButton();
            this.rdBtnCuelloComun = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBtnMangaCorta = new System.Windows.Forms.RadioButton();
            this.rdBtnMangaLarga = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdBtnPantalonChupin = new System.Windows.Forms.RadioButton();
            this.rdBtnPantalonComun = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdBtnCamisa = new System.Windows.Forms.RadioButton();
            this.rdBtnPantalon = new System.Windows.Forms.RadioButton();
            this.gpBoxCalidad = new System.Windows.Forms.GroupBox();
            this.rdBtnPrendaPremium = new System.Windows.Forms.RadioButton();
            this.rdBtnPrendaStandard = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gpBoxPrecioUnitarioYCantidad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbPrendas.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gpBoxCalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel1.Controls.Add(this.lblDireccionTienda);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombreTienda);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 546);
            this.splitContainer1.SplitterDistance = 34;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireccionTienda.Location = new System.Drawing.Point(654, 9);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(134, 23);
            this.lblDireccionTienda.TabIndex = 1;
            this.lblDireccionTienda.Text = "lblDireccionTienda";
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreTienda.Location = new System.Drawing.Point(12, 9);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(124, 23);
            this.lblNombreTienda.TabIndex = 0;
            this.lblNombreTienda.Text = "lblNombreTienda";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer2.Panel1.Controls.Add(this.lblCodVendedorText);
            this.splitContainer2.Panel1.Controls.Add(this.linklblHistorial);
            this.splitContainer2.Panel1.Controls.Add(this.lblCodigoVendedor);
            this.splitContainer2.Panel1.Controls.Add(this.lblNombreApellidoVendedor);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.lblMensajeError);
            this.splitContainer2.Panel2.Controls.Add(this.gpBoxPrecioUnitarioYCantidad);
            this.splitContainer2.Panel2.Controls.Add(this.lblResultadoPrecioMostrar);
            this.splitContainer2.Panel2.Controls.Add(this.lblResultadoPrecioTexto);
            this.splitContainer2.Panel2.Controls.Add(this.btnCotizarPrenda);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.gbPrendas);
            this.splitContainer2.Size = new System.Drawing.Size(800, 508);
            this.splitContainer2.SplitterDistance = 40;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblCodVendedorText
            // 
            this.lblCodVendedorText.AutoSize = true;
            this.lblCodVendedorText.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodVendedorText.Location = new System.Drawing.Point(302, 10);
            this.lblCodVendedorText.Name = "lblCodVendedorText";
            this.lblCodVendedorText.Size = new System.Drawing.Size(28, 23);
            this.lblCodVendedorText.TabIndex = 5;
            this.lblCodVendedorText.Text = "ID:";
            // 
            // linklblHistorial
            // 
            this.linklblHistorial.AutoSize = true;
            this.linklblHistorial.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linklblHistorial.Location = new System.Drawing.Point(697, 10);
            this.linklblHistorial.Name = "linklblHistorial";
            this.linklblHistorial.Size = new System.Drawing.Size(66, 23);
            this.linklblHistorial.TabIndex = 4;
            this.linklblHistorial.TabStop = true;
            this.linklblHistorial.Text = "Historial";
            this.linklblHistorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblHistorial_LinkClicked);
            // 
            // lblCodigoVendedor
            // 
            this.lblCodigoVendedor.AutoSize = true;
            this.lblCodigoVendedor.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoVendedor.Location = new System.Drawing.Point(336, 10);
            this.lblCodigoVendedor.Name = "lblCodigoVendedor";
            this.lblCodigoVendedor.Size = new System.Drawing.Size(133, 23);
            this.lblCodigoVendedor.TabIndex = 3;
            this.lblCodigoVendedor.Text = "lblCodigoVendedor";
            // 
            // lblNombreApellidoVendedor
            // 
            this.lblNombreApellidoVendedor.AutoSize = true;
            this.lblNombreApellidoVendedor.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreApellidoVendedor.Location = new System.Drawing.Point(12, 10);
            this.lblNombreApellidoVendedor.Name = "lblNombreApellidoVendedor";
            this.lblNombreApellidoVendedor.Size = new System.Drawing.Size(195, 23);
            this.lblNombreApellidoVendedor.TabIndex = 2;
            this.lblNombreApellidoVendedor.Text = "lblNombreApellidoVendedor";
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.BackColor = System.Drawing.Color.IndianRed;
            this.lblMensajeError.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblMensajeError.Location = new System.Drawing.Point(345, 401);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(0, 20);
            this.lblMensajeError.TabIndex = 6;
            // 
            // gpBoxPrecioUnitarioYCantidad
            // 
            this.gpBoxPrecioUnitarioYCantidad.BackColor = System.Drawing.Color.Lavender;
            this.gpBoxPrecioUnitarioYCantidad.Controls.Add(this.txtBoxCantidadACotizar);
            this.gpBoxPrecioUnitarioYCantidad.Controls.Add(this.txtBoxPrecioUnitario);
            this.gpBoxPrecioUnitarioYCantidad.Controls.Add(this.lblCantidadACotizar);
            this.gpBoxPrecioUnitarioYCantidad.Controls.Add(this.lblPrecioUnitario);
            this.gpBoxPrecioUnitarioYCantidad.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpBoxPrecioUnitarioYCantidad.Location = new System.Drawing.Point(117, 334);
            this.gpBoxPrecioUnitarioYCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.gpBoxPrecioUnitarioYCantidad.Name = "gpBoxPrecioUnitarioYCantidad";
            this.gpBoxPrecioUnitarioYCantidad.Padding = new System.Windows.Forms.Padding(2);
            this.gpBoxPrecioUnitarioYCantidad.Size = new System.Drawing.Size(552, 65);
            this.gpBoxPrecioUnitarioYCantidad.TabIndex = 5;
            this.gpBoxPrecioUnitarioYCantidad.TabStop = false;
            this.gpBoxPrecioUnitarioYCantidad.Text = "Precio Unitario Y Cantidad";
            // 
            // txtBoxCantidadACotizar
            // 
            this.txtBoxCantidadACotizar.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxCantidadACotizar.Location = new System.Drawing.Point(463, 29);
            this.txtBoxCantidadACotizar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxCantidadACotizar.Name = "txtBoxCantidadACotizar";
            this.txtBoxCantidadACotizar.Size = new System.Drawing.Size(70, 25);
            this.txtBoxCantidadACotizar.TabIndex = 3;
            // 
            // txtBoxPrecioUnitario
            // 
            this.txtBoxPrecioUnitario.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPrecioUnitario.Location = new System.Drawing.Point(146, 30);
            this.txtBoxPrecioUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPrecioUnitario.Name = "txtBoxPrecioUnitario";
            this.txtBoxPrecioUnitario.Size = new System.Drawing.Size(111, 25);
            this.txtBoxPrecioUnitario.TabIndex = 2;
            // 
            // lblCantidadACotizar
            // 
            this.lblCantidadACotizar.AutoSize = true;
            this.lblCantidadACotizar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadACotizar.Location = new System.Drawing.Point(288, 30);
            this.lblCantidadACotizar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadACotizar.Name = "lblCantidadACotizar";
            this.lblCantidadACotizar.Size = new System.Drawing.Size(163, 26);
            this.lblCantidadACotizar.TabIndex = 1;
            this.lblCantidadACotizar.Text = "Cantidad A Cotizar:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioUnitario.Location = new System.Drawing.Point(15, 28);
            this.lblPrecioUnitario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(131, 26);
            this.lblPrecioUnitario.TabIndex = 0;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblResultadoPrecioMostrar
            // 
            this.lblResultadoPrecioMostrar.AutoSize = true;
            this.lblResultadoPrecioMostrar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoPrecioMostrar.Location = new System.Drawing.Point(437, 421);
            this.lblResultadoPrecioMostrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultadoPrecioMostrar.Name = "lblResultadoPrecioMostrar";
            this.lblResultadoPrecioMostrar.Size = new System.Drawing.Size(0, 26);
            this.lblResultadoPrecioMostrar.TabIndex = 4;
            // 
            // lblResultadoPrecioTexto
            // 
            this.lblResultadoPrecioTexto.AutoSize = true;
            this.lblResultadoPrecioTexto.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultadoPrecioTexto.Location = new System.Drawing.Point(345, 421);
            this.lblResultadoPrecioTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultadoPrecioTexto.Name = "lblResultadoPrecioTexto";
            this.lblResultadoPrecioTexto.Size = new System.Drawing.Size(88, 26);
            this.lblResultadoPrecioTexto.TabIndex = 3;
            this.lblResultadoPrecioTexto.Text = "Resultado:";
            // 
            // btnCotizarPrenda
            // 
            this.btnCotizarPrenda.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnCotizarPrenda.Enabled = false;
            this.btnCotizarPrenda.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCotizarPrenda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCotizarPrenda.Location = new System.Drawing.Point(126, 410);
            this.btnCotizarPrenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnCotizarPrenda.Name = "btnCotizarPrenda";
            this.btnCotizarPrenda.Size = new System.Drawing.Size(193, 44);
            this.btnCotizarPrenda.TabIndex = 2;
            this.btnCotizarPrenda.Text = "Cotizar";
            this.btnCotizarPrenda.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lblUnidadesDisponibles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(117, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 46);
            this.panel1.TabIndex = 1;
            // 
            // lblUnidadesDisponibles
            // 
            this.lblUnidadesDisponibles.AutoSize = true;
            this.lblUnidadesDisponibles.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnidadesDisponibles.Location = new System.Drawing.Point(262, 18);
            this.lblUnidadesDisponibles.Name = "lblUnidadesDisponibles";
            this.lblUnidadesDisponibles.Size = new System.Drawing.Size(17, 18);
            this.lblUnidadesDisponibles.TabIndex = 1;
            this.lblUnidadesDisponibles.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unidades de stock disponible:";
            // 
            // gbPrendas
            // 
            this.gbPrendas.BackColor = System.Drawing.Color.Lavender;
            this.gbPrendas.Controls.Add(this.panel6);
            this.gbPrendas.Controls.Add(this.panel5);
            this.gbPrendas.Controls.Add(this.panel4);
            this.gbPrendas.Controls.Add(this.gpBoxCalidad);
            this.gbPrendas.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbPrendas.Location = new System.Drawing.Point(117, 17);
            this.gbPrendas.Name = "gbPrendas";
            this.gbPrendas.Size = new System.Drawing.Size(553, 253);
            this.gbPrendas.TabIndex = 0;
            this.gbPrendas.TabStop = false;
            this.gbPrendas.Text = "Prendas";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Beige;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Location = new System.Drawing.Point(262, 170);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 75);
            this.panel6.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdBtnCuelloMao);
            this.panel3.Controls.Add(this.rdBtnCuelloComun);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(8, 37);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 35);
            this.panel3.TabIndex = 9;
            // 
            // rdBtnCuelloMao
            // 
            this.rdBtnCuelloMao.AutoSize = true;
            this.rdBtnCuelloMao.Location = new System.Drawing.Point(153, 8);
            this.rdBtnCuelloMao.Name = "rdBtnCuelloMao";
            this.rdBtnCuelloMao.Size = new System.Drawing.Size(61, 30);
            this.rdBtnCuelloMao.TabIndex = 7;
            this.rdBtnCuelloMao.Text = "Mao";
            this.rdBtnCuelloMao.UseVisualStyleBackColor = true;
            // 
            // rdBtnCuelloComun
            // 
            this.rdBtnCuelloComun.AutoSize = true;
            this.rdBtnCuelloComun.Location = new System.Drawing.Point(68, 8);
            this.rdBtnCuelloComun.Name = "rdBtnCuelloComun";
            this.rdBtnCuelloComun.Size = new System.Drawing.Size(82, 30);
            this.rdBtnCuelloComun.TabIndex = 4;
            this.rdBtnCuelloComun.Text = "Comun";
            this.rdBtnCuelloComun.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuello";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdBtnMangaCorta);
            this.panel2.Controls.Add(this.rdBtnMangaLarga);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 31);
            this.panel2.TabIndex = 8;
            // 
            // rdBtnMangaCorta
            // 
            this.rdBtnMangaCorta.AutoSize = true;
            this.rdBtnMangaCorta.Location = new System.Drawing.Point(142, 5);
            this.rdBtnMangaCorta.Name = "rdBtnMangaCorta";
            this.rdBtnMangaCorta.Size = new System.Drawing.Size(72, 30);
            this.rdBtnMangaCorta.TabIndex = 6;
            this.rdBtnMangaCorta.Text = "Corta";
            this.rdBtnMangaCorta.UseVisualStyleBackColor = true;
            // 
            // rdBtnMangaLarga
            // 
            this.rdBtnMangaLarga.AutoSize = true;
            this.rdBtnMangaLarga.Location = new System.Drawing.Point(72, 5);
            this.rdBtnMangaLarga.Name = "rdBtnMangaLarga";
            this.rdBtnMangaLarga.Size = new System.Drawing.Size(74, 30);
            this.rdBtnMangaLarga.TabIndex = 5;
            this.rdBtnMangaLarga.Text = "Larga";
            this.rdBtnMangaLarga.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manga";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rdBtnPantalonChupin);
            this.panel5.Controls.Add(this.rdBtnPantalonComun);
            this.panel5.Location = new System.Drawing.Point(30, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 73);
            this.panel5.TabIndex = 10;
            // 
            // rdBtnPantalonChupin
            // 
            this.rdBtnPantalonChupin.AutoSize = true;
            this.rdBtnPantalonChupin.Location = new System.Drawing.Point(52, 41);
            this.rdBtnPantalonChupin.Name = "rdBtnPantalonChupin";
            this.rdBtnPantalonChupin.Size = new System.Drawing.Size(82, 30);
            this.rdBtnPantalonChupin.TabIndex = 1;
            this.rdBtnPantalonChupin.Text = "Chupin";
            this.rdBtnPantalonChupin.UseVisualStyleBackColor = true;
            // 
            // rdBtnPantalonComun
            // 
            this.rdBtnPantalonComun.AutoSize = true;
            this.rdBtnPantalonComun.Location = new System.Drawing.Point(52, 10);
            this.rdBtnPantalonComun.Name = "rdBtnPantalonComun";
            this.rdBtnPantalonComun.Size = new System.Drawing.Size(82, 30);
            this.rdBtnPantalonComun.TabIndex = 0;
            this.rdBtnPantalonComun.Text = "Comun";
            this.rdBtnPantalonComun.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.Controls.Add(this.rdBtnCamisa);
            this.panel4.Controls.Add(this.rdBtnPantalon);
            this.panel4.ForeColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(30, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(470, 37);
            this.panel4.TabIndex = 2;
            // 
            // rdBtnCamisa
            // 
            this.rdBtnCamisa.AutoSize = true;
            this.rdBtnCamisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdBtnCamisa.Location = new System.Drawing.Point(275, 3);
            this.rdBtnCamisa.Name = "rdBtnCamisa";
            this.rdBtnCamisa.Size = new System.Drawing.Size(83, 30);
            this.rdBtnCamisa.TabIndex = 1;
            this.rdBtnCamisa.Text = "Camisa";
            this.rdBtnCamisa.UseVisualStyleBackColor = true;
            // 
            // rdBtnPantalon
            // 
            this.rdBtnPantalon.AutoSize = true;
            this.rdBtnPantalon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdBtnPantalon.Location = new System.Drawing.Point(66, 3);
            this.rdBtnPantalon.Name = "rdBtnPantalon";
            this.rdBtnPantalon.Size = new System.Drawing.Size(98, 30);
            this.rdBtnPantalon.TabIndex = 0;
            this.rdBtnPantalon.Text = "Pantalon";
            this.rdBtnPantalon.UseVisualStyleBackColor = true;
            // 
            // gpBoxCalidad
            // 
            this.gpBoxCalidad.BackColor = System.Drawing.Color.SkyBlue;
            this.gpBoxCalidad.Controls.Add(this.rdBtnPrendaPremium);
            this.gpBoxCalidad.Controls.Add(this.rdBtnPrendaStandard);
            this.gpBoxCalidad.Location = new System.Drawing.Point(32, 32);
            this.gpBoxCalidad.Name = "gpBoxCalidad";
            this.gpBoxCalidad.Size = new System.Drawing.Size(454, 77);
            this.gpBoxCalidad.TabIndex = 1;
            this.gpBoxCalidad.TabStop = false;
            this.gpBoxCalidad.Text = "Calidad";
            // 
            // rdBtnPrendaPremium
            // 
            this.rdBtnPrendaPremium.AutoSize = true;
            this.rdBtnPrendaPremium.Location = new System.Drawing.Point(256, 36);
            this.rdBtnPrendaPremium.Name = "rdBtnPrendaPremium";
            this.rdBtnPrendaPremium.Size = new System.Drawing.Size(100, 30);
            this.rdBtnPrendaPremium.TabIndex = 1;
            this.rdBtnPrendaPremium.Text = "Premium";
            this.rdBtnPrendaPremium.UseVisualStyleBackColor = true;
            // 
            // rdBtnPrendaStandard
            // 
            this.rdBtnPrendaStandard.AutoSize = true;
            this.rdBtnPrendaStandard.Location = new System.Drawing.Point(64, 36);
            this.rdBtnPrendaStandard.Name = "rdBtnPrendaStandard";
            this.rdBtnPrendaStandard.Size = new System.Drawing.Size(103, 30);
            this.rdBtnPrendaStandard.TabIndex = 0;
            this.rdBtnPrendaStandard.Text = "Standard";
            this.rdBtnPrendaStandard.UseVisualStyleBackColor = true;
            // 
            // CotizacionPrendaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CotizacionPrendaView";
            this.Text = "Cotizacion Prenda";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gpBoxPrecioUnitarioYCantidad.ResumeLayout(false);
            this.gpBoxPrecioUnitarioYCantidad.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbPrendas.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gpBoxCalidad.ResumeLayout(false);
            this.gpBoxCalidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblDireccionTienda;
        private Label lblNombreTienda;
        private SplitContainer splitContainer2;
        private LinkLabel linklblHistorial;
        private Label lblCodigoVendedor;
        private Label lblNombreApellidoVendedor;
        private GroupBox gbPrendas;
        private Panel panel1;
        private Label lblUnidadesDisponibles;
        private Label label3;
        private RadioButton rdBtnPantalonChupin;
        private RadioButton rdBtnPantalonComun;
        private RadioButton rdBtnCuelloMao;
        private RadioButton rdBtnMangaCorta;
        private RadioButton rdBtnMangaLarga;
        private RadioButton rdBtnCuelloComun;
        private Label label2;
        private Label label1;
        private GroupBox gpBoxCalidad;
        private RadioButton rdBtnPrendaPremium;
        private RadioButton rdBtnPrendaStandard;
        private Button btnCotizarPrenda;
        private Label lblResultadoPrecioMostrar;
        private Label lblResultadoPrecioTexto;
        private GroupBox gpBoxPrecioUnitarioYCantidad;
        private TextBox txtBoxCantidadACotizar;
        private TextBox txtBoxPrecioUnitario;
        private Label lblCantidadACotizar;
        private Label lblPrecioUnitario;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private RadioButton rdBtnCamisa;
        private RadioButton rdBtnPantalon;
        private Panel panel6;
        private Panel panel5;
        private Label lblMensajeError;
        private Label lblCodVendedorText;
    }
}