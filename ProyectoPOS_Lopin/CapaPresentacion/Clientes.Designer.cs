namespace ProyectoPOS_Lopin.CapaPresentacion
{
    partial class Clientes
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
            this.textControlClientes = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.groupCliente = new System.Windows.Forms.GroupBox();
            this.btenRegresar = new System.Windows.Forms.Button();
            this.btenlimpiar = new System.Windows.Forms.Button();
            this.btenEliminar = new System.Windows.Forms.Button();
            this.btenEditar = new System.Windows.Forms.Button();
            this.btenNuevo = new System.Windows.Forms.Button();
            this.chkestados = new System.Windows.Forms.CheckBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.texttelefono = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // textControlClientes
            // 
            this.textControlClientes.AutoSize = true;
            this.textControlClientes.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textControlClientes.Location = new System.Drawing.Point(326, 18);
            this.textControlClientes.Name = "textControlClientes";
            this.textControlClientes.Size = new System.Drawing.Size(243, 25);
            this.textControlClientes.TabIndex = 1;
            this.textControlClientes.Text = "CONTROL DE CLINTES";
            this.textControlClientes.Click += new System.EventHandler(this.textControlClientes_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvCliente.Location = new System.Drawing.Point(24, 66);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 62;
            this.dgvCliente.RowTemplate.Height = 28;
            this.dgvCliente.Size = new System.Drawing.Size(829, 146);
            this.dgvCliente.TabIndex = 2;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // groupCliente
            // 
            this.groupCliente.Controls.Add(this.btenRegresar);
            this.groupCliente.Controls.Add(this.btenlimpiar);
            this.groupCliente.Controls.Add(this.btenEliminar);
            this.groupCliente.Controls.Add(this.btenEditar);
            this.groupCliente.Controls.Add(this.btenNuevo);
            this.groupCliente.Controls.Add(this.chkestados);
            this.groupCliente.Controls.Add(this.textemail);
            this.groupCliente.Controls.Add(this.texttelefono);
            this.groupCliente.Controls.Add(this.textnombre);
            this.groupCliente.Controls.Add(this.textcodigo);
            this.groupCliente.Controls.Add(this.label6);
            this.groupCliente.Controls.Add(this.label5);
            this.groupCliente.Controls.Add(this.label3);
            this.groupCliente.Controls.Add(this.label2);
            this.groupCliente.Controls.Add(this.label1);
            this.groupCliente.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCliente.Location = new System.Drawing.Point(24, 227);
            this.groupCliente.Name = "groupCliente";
            this.groupCliente.Size = new System.Drawing.Size(829, 290);
            this.groupCliente.TabIndex = 3;
            this.groupCliente.TabStop = false;
            this.groupCliente.Text = "Cliente";
            // 
            // btenRegresar
            // 
            this.btenRegresar.BackColor = System.Drawing.Color.SpringGreen;
            this.btenRegresar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenRegresar.Location = new System.Drawing.Point(652, 229);
            this.btenRegresar.Name = "btenRegresar";
            this.btenRegresar.Size = new System.Drawing.Size(141, 43);
            this.btenRegresar.TabIndex = 17;
            this.btenRegresar.Text = "Regresar";
            this.btenRegresar.UseVisualStyleBackColor = false;
            this.btenRegresar.Click += new System.EventHandler(this.btenRegresar_Click);
            // 
            // btenlimpiar
            // 
            this.btenlimpiar.BackColor = System.Drawing.Color.SpringGreen;
            this.btenlimpiar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenlimpiar.Location = new System.Drawing.Point(495, 229);
            this.btenlimpiar.Name = "btenlimpiar";
            this.btenlimpiar.Size = new System.Drawing.Size(141, 43);
            this.btenlimpiar.TabIndex = 16;
            this.btenlimpiar.Text = "Limpar";
            this.btenlimpiar.UseVisualStyleBackColor = false;
            // 
            // btenEliminar
            // 
            this.btenEliminar.BackColor = System.Drawing.Color.SpringGreen;
            this.btenEliminar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenEliminar.Location = new System.Drawing.Point(340, 229);
            this.btenEliminar.Name = "btenEliminar";
            this.btenEliminar.Size = new System.Drawing.Size(141, 43);
            this.btenEliminar.TabIndex = 15;
            this.btenEliminar.Text = "Desechar";
            this.btenEliminar.UseVisualStyleBackColor = false;
            // 
            // btenEditar
            // 
            this.btenEditar.BackColor = System.Drawing.Color.SpringGreen;
            this.btenEditar.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenEditar.Location = new System.Drawing.Point(180, 229);
            this.btenEditar.Name = "btenEditar";
            this.btenEditar.Size = new System.Drawing.Size(141, 43);
            this.btenEditar.TabIndex = 14;
            this.btenEditar.Text = "Editar";
            this.btenEditar.UseVisualStyleBackColor = false;
            // 
            // btenNuevo
            // 
            this.btenNuevo.BackColor = System.Drawing.Color.SpringGreen;
            this.btenNuevo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenNuevo.Location = new System.Drawing.Point(21, 229);
            this.btenNuevo.Name = "btenNuevo";
            this.btenNuevo.Size = new System.Drawing.Size(141, 43);
            this.btenNuevo.TabIndex = 13;
            this.btenNuevo.Text = "Nuevo";
            this.btenNuevo.UseVisualStyleBackColor = false;
            // 
            // chkestados
            // 
            this.chkestados.AutoSize = true;
            this.chkestados.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkestados.Location = new System.Drawing.Point(620, 100);
            this.chkestados.Name = "chkestados";
            this.chkestados.Size = new System.Drawing.Size(160, 26);
            this.chkestados.TabIndex = 12;
            this.chkestados.Text = "Activo/Inactivo";
            this.chkestados.UseVisualStyleBackColor = true;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(111, 101);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(355, 30);
            this.textemail.TabIndex = 11;
            // 
            // texttelefono
            // 
            this.texttelefono.Location = new System.Drawing.Point(620, 39);
            this.texttelefono.Name = "texttelefono";
            this.texttelefono.Size = new System.Drawing.Size(141, 30);
            this.texttelefono.TabIndex = 10;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(111, 157);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(355, 30);
            this.textnombre.TabIndex = 8;
            // 
            // textcodigo
            // 
            this.textcodigo.Enabled = false;
            this.textcodigo.Location = new System.Drawing.Point(111, 39);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(140, 30);
            this.textcodigo.TabIndex = 7;
            this.textcodigo.TextChanged += new System.EventHandler(this.textcodigo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(875, 529);
            this.Controls.Add(this.groupCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.textControlClientes);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupCliente.ResumeLayout(false);
            this.groupCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textControlClientes;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox groupCliente;
        private System.Windows.Forms.Button btenRegresar;
        private System.Windows.Forms.Button btenlimpiar;
        private System.Windows.Forms.Button btenEliminar;
        private System.Windows.Forms.Button btenEditar;
        private System.Windows.Forms.Button btenNuevo;
        private System.Windows.Forms.CheckBox chkestados;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox texttelefono;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}