namespace Desafio_Final_Curso_CSharp_VendedorDeTienda
{
    partial class FormHistorialVendedor
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
            this.listViewHistorial = new System.Windows.Forms.ListView();
            this.IDCotizacion = new System.Windows.Forms.ColumnHeader();
            this.FechaYHora = new System.Windows.Forms.ColumnHeader();
            this.IDVendedor = new System.Windows.Forms.ColumnHeader();
            this.IDPrenda = new System.Windows.Forms.ColumnHeader();
            this.Cantidad = new System.Windows.Forms.ColumnHeader();
            this.Resultado = new System.Windows.Forms.ColumnHeader();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewHistorial
            // 
            this.listViewHistorial.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listViewHistorial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCotizacion,
            this.FechaYHora,
            this.IDVendedor,
            this.IDPrenda,
            this.Cantidad,
            this.Resultado});
            this.listViewHistorial.Location = new System.Drawing.Point(12, 128);
            this.listViewHistorial.Name = "listViewHistorial";
            this.listViewHistorial.Size = new System.Drawing.Size(759, 224);
            this.listViewHistorial.TabIndex = 0;
            this.listViewHistorial.UseCompatibleStateImageBehavior = false;
            this.listViewHistorial.View = System.Windows.Forms.View.Details;
            this.listViewHistorial.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IDCotizacion
            // 
            this.IDCotizacion.Text = "ID Cotizacion";
            this.IDCotizacion.Width = 100;
            // 
            // FechaYHora
            // 
            this.FechaYHora.Text = "Fecha y Hora";
            this.FechaYHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FechaYHora.Width = 150;
            // 
            // IDVendedor
            // 
            this.IDVendedor.Text = "ID Vendedor";
            this.IDVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDVendedor.Width = 100;
            // 
            // IDPrenda
            // 
            this.IDPrenda.Text = "Prenda";
            this.IDPrenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDPrenda.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cantidad.Width = 100;
            // 
            // Resultado
            // 
            this.Resultado.Text = "Resultado";
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resultado.Width = 100;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(332, 392);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormHistorialVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.listViewHistorial);
            this.Name = "FormHistorialVendedor";
            this.Text = "Historial Vendedor";
            this.Load += new System.EventHandler(this.FormHistorialVendedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewHistorial;
        private ColumnHeader IDCotizacion;
        private ColumnHeader FechaYHora;
        private ColumnHeader IDVendedor;
        private ColumnHeader IDPrenda;
        private ColumnHeader Cantidad;
        private ColumnHeader Resultado;
        private Button btnCerrar;
    }
}