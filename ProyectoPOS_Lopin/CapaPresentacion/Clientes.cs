
    using ProyectoPOS_Lopin.CapaEntidades;
using ProyectoPOS_Lopin.CapaNegocio;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace ProyectoPOS_Lopin.CapaPresentacion
    {
        public partial class Clientes : Form
        {
            // Lista que simula la base de datos
            public static List<Cliente> ListaClientes = new List<Cliente>();

        private void DeshabilitarBotones()
        {
            btenEditar.Enabled = false;
            btenEliminar.Enabled = false;
            btenlimpiar.Enabled = false;
            btenNuevo.Enabled = true;
        }
        private void HabilitarBotones()
        {
            btenNuevo.Enabled = false;
            btenEditar.Enabled = true;
            btenEliminar.Enabled = true;
            btenlimpiar.Enabled = true;
        }
        public Clientes()
            {
                InitializeComponent();
                // Optional: wire some handlers if designer didn't
                // (Most likely already set in designer)
            }

            private void Clientes_Load(object sender, EventArgs e)
            {
            DeshabilitarBotones(); //al iniciar, no esten activos
                                   // Cargar datos iniciales si la lista está vacía
            if (!ListaClientes.Any())
                {
                    ListaClientes.Add(new Cliente
                    {
                        Id = 1,
                        Nombre = "Camila Mila",
                        Email = "camila@mail.com",
                        Telefono = "12345678",
                        Estado = true
                    });

                    ListaClientes.Add(new Cliente
                    {
                        Id = 2,
                        Nombre = "Luis Pérez",
                        Email = "luis@mail.com",
                        Telefono = "99998888",
                        Estado = true
                    });
                }

                RefrescarGrid();
            }

            private void RefrescarGrid()
            {
                // Asegúrate que en el diseñador exista dgvClientes (DataGridView)
               
                    dgvCliente.AutoGenerateColumns = true;
                    dgvCliente.DataSource = null;
                    dgvCliente.DataSource = ListaClientes;
                }


            private void LimpiarCampos()
            {
                // Nombres de controles esperados: txtId, txtNombre, txtEmail, txtTelefono, chkEstado
                var txtCodigo = this.Controls.Find("txtId", true).FirstOrDefault() as TextBox;
                var txtnombre = this.Controls.Find("txtNombre", true).FirstOrDefault() as TextBox;
                var txtemail = this.Controls.Find("txtEmail", true).FirstOrDefault() as TextBox;
                var txttelefono = this.Controls.Find("txtTelefono", true).FirstOrDefault() as TextBox;
                var chkestado = this.Controls.Find("chkEstado", true).FirstOrDefault() as CheckBox;

                if (txtCodigo != null) txtCodigo.Text = "";
                if (txtnombre != null) txtnombre.Text = "";
                if (txtemail != null) txtemail.Text = "";
                if (txttelefono != null) txttelefono.Text = "";
                if (chkestado != null) chkestado.Checked = false;
            }

            private void btnNuevo_Click(object sender, EventArgs e)
            {
                var txtnombre = this.Controls.Find("txtNombre", true).FirstOrDefault() as TextBox;
                var txtemail = this.Controls.Find("txtEmail", true).FirstOrDefault() as TextBox;
                var txttelefono = this.Controls.Find("txtTelefono", true).FirstOrDefault() as TextBox;
                var chkestado = this.Controls.Find("chkEstado", true).FirstOrDefault() as CheckBox;

                if (txtnombre == null)
                {
                    MessageBox.Show("No se encontró el control txtNombre en el formulario. Revisa el diseñador.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtnombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.");
                    return;
                }

                int nuevoId = ListaClientes.Any() ? ListaClientes.Max(x => x.Id) + 1 : 1;

                Cliente c = new Cliente
                {
                    Id = nuevoId,
                    Nombre = txtnombre.Text,
                    Email = txtemail?.Text ?? "",
                    Telefono = txttelefono?.Text ?? "",
                    Estado = chkestado?.Checked ?? false
                };

                ListaClientes.Add(c);
                RefrescarGrid();
                LimpiarCampos();

                MessageBox.Show("Cliente agregado correctamente.");
            }
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                var dgv = this.Controls.Find("dgvClientes", true).FirstOrDefault() as DataGridView;
                if (dgv == null || dgv.CurrentRow == null) return;

                var txtCodigo = this.Controls.Find("txtId", true).FirstOrDefault() as TextBox;
                var txtnombre = this.Controls.Find("txtNombre", true).FirstOrDefault() as TextBox;
                var txtemail = this.Controls.Find("txtEmail", true).FirstOrDefault() as TextBox;
                var txtelefono = this.Controls.Find("txtTelefono", true).FirstOrDefault() as TextBox;
                var chkestado = this.Controls.Find("chkEstado", true).FirstOrDefault() as CheckBox;

                if (txtCodigo != null) txtCodigo.Text = dgv.CurrentRow.Cells["Id"].Value.ToString();
                if (txtnombre != null) txtnombre.Text = dgv.CurrentRow.Cells["Nombre"].Value.ToString();
                if (txtemail != null) txtemail.Text = dgv.CurrentRow.Cells["Email"].Value.ToString();
                if (txtelefono != null) txtelefono.Text = dgv.CurrentRow.Cells["Telefono"].Value.ToString();
                if (chkestado != null) chkestado.Checked = (bool)dgv.CurrentRow.Cells["Estado"].Value;

                //Habilitar los botones de editar y eliminar
                HabilitarBotones();
            }
            }




            private void btnEditar_Click(object sender, EventArgs e)
            {
                var txtId = this.Controls.Find("txtId", true).FirstOrDefault() as TextBox;
                var txtNombre = this.Controls.Find("txtNombre", true).FirstOrDefault() as TextBox;
                var txtEmail = this.Controls.Find("txtEmail", true).FirstOrDefault() as TextBox;
                var txtTelefono = this.Controls.Find("txtTelefono", true).FirstOrDefault() as TextBox;
                var chkEstado = this.Controls.Find("chkEstado", true).FirstOrDefault() as CheckBox;

                if (txtId == null || !int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("Seleccione un cliente válido.");
                    return;
                }

                var cliente = ListaClientes.FirstOrDefault(x => x.Id == id);

                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }

                cliente.Nombre = txtNombre?.Text ?? cliente.Nombre;
                cliente.Email = txtEmail?.Text ?? cliente.Email;
                cliente.Telefono = txtTelefono?.Text ?? cliente.Telefono;
                cliente.Estado = chkEstado?.Checked ?? cliente.Estado;

                RefrescarGrid();
                MessageBox.Show("Cliente actualizado correctamente.");
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                var txtId = this.Controls.Find("txtId", true).FirstOrDefault() as TextBox;

                if (txtId == null || !int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("Seleccione un cliente válido.");
                    return;
                }

                var cliente = ListaClientes.FirstOrDefault(x => x.Id == id);
                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }

                if (MessageBox.Show("¿Eliminar cliente?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ListaClientes.Remove(cliente);
                    RefrescarGrid();
                    LimpiarCampos();

                DeshabilitarBotones();
            }
            }

        private void textcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCliente.CurrentRow == null) return;
            //Obtener el producto seleccionado
            textcodigo.Text = dgvCliente.CurrentRow.Cells["Id"].Value.ToString();
            textnombre.Text = dgvCliente.CurrentRow.Cells["Nombre"].Value.ToString();
            texttelefono.Text = dgvCliente.CurrentRow.Cells["Telefono"].Value.ToString();
            chkestados.Text = dgvCliente.CurrentRow.Cells["Estado"].Value.ToString();
            textemail.Text = dgvCliente.CurrentRow.Cells["Email"].Value.ToString();
            //Habilitar los botones de editar y eliminar
            HabilitarBotones();
        }

        private void btenRegresar_Click(object sender, EventArgs e)
        {

        }

        private void textControlClientes_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
