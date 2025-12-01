namespace ProyectoPOS_Lopin.CapaPresentacion
{
    partial class FrmPruebas
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
            this.btnStock = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnProbarPagos = new System.Windows.Forms.Button();
            this.btnClientesActivos = new System.Windows.Forms.Button();
            this.btnValidarVentas = new System.Windows.Forms.Button();
            this.btnPruebaVentaRapida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Lime;
            this.btnStock.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(54, 40);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(175, 53);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Lime;
            this.btnCerrar.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(54, 132);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(175, 54);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnProbarPagos
            // 
            this.btnProbarPagos.BackColor = System.Drawing.Color.Lime;
            this.btnProbarPagos.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarPagos.Location = new System.Drawing.Point(273, 132);
            this.btnProbarPagos.Name = "btnProbarPagos";
            this.btnProbarPagos.Size = new System.Drawing.Size(246, 54);
            this.btnProbarPagos.TabIndex = 3;
            this.btnProbarPagos.Text = "Probar Pagos";
            this.btnProbarPagos.UseVisualStyleBackColor = false;
            this.btnProbarPagos.Click += new System.EventHandler(this.btnProbarPagos_Click);
            // 
            // btnClientesActivos
            // 
            this.btnClientesActivos.BackColor = System.Drawing.Color.Lime;
            this.btnClientesActivos.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesActivos.Location = new System.Drawing.Point(273, 40);
            this.btnClientesActivos.Name = "btnClientesActivos";
            this.btnClientesActivos.Size = new System.Drawing.Size(246, 53);
            this.btnClientesActivos.TabIndex = 4;
            this.btnClientesActivos.Text = "Clientes Activos";
            this.btnClientesActivos.UseVisualStyleBackColor = false;
            this.btnClientesActivos.Click += new System.EventHandler(this.btnClientesActivos_Click);
            // 
            // btnValidarVentas
            // 
            this.btnValidarVentas.BackColor = System.Drawing.Color.Lime;
            this.btnValidarVentas.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarVentas.Location = new System.Drawing.Point(54, 225);
            this.btnValidarVentas.Name = "btnValidarVentas";
            this.btnValidarVentas.Size = new System.Drawing.Size(175, 59);
            this.btnValidarVentas.TabIndex = 5;
            this.btnValidarVentas.Text = "Validar Ventas";
            this.btnValidarVentas.UseVisualStyleBackColor = false;
            this.btnValidarVentas.Click += new System.EventHandler(this.btnValidarVentas_Click);
            // 
            // btnPruebaVentaRapida
            // 
            this.btnPruebaVentaRapida.BackColor = System.Drawing.Color.Lime;
            this.btnPruebaVentaRapida.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebaVentaRapida.Location = new System.Drawing.Point(273, 225);
            this.btnPruebaVentaRapida.Name = "btnPruebaVentaRapida";
            this.btnPruebaVentaRapida.Size = new System.Drawing.Size(246, 59);
            this.btnPruebaVentaRapida.TabIndex = 6;
            this.btnPruebaVentaRapida.Text = "Prueba de Venta Rapida";
            this.btnPruebaVentaRapida.UseVisualStyleBackColor = false;
            this.btnPruebaVentaRapida.Click += new System.EventHandler(this.btnPruebaVentaRapida_Click);
            // 
            // FrmPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(588, 326);
            this.Controls.Add(this.btnPruebaVentaRapida);
            this.Controls.Add(this.btnValidarVentas);
            this.Controls.Add(this.btnClientesActivos);
            this.Controls.Add(this.btnProbarPagos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnStock);
            this.Name = "FrmPruebas";
            this.Text = "FormPruebas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnProbarPagos;
        private System.Windows.Forms.Button btnClientesActivos;
        private System.Windows.Forms.Button btnValidarVentas;
        private System.Windows.Forms.Button btnPruebaVentaRapida;
    }
}