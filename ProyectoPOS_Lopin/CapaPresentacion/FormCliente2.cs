using ProyectoPOS_Lopin.CapaDatos;
using ProyectoPOS_Lopin.CapaEntidades;
using ProyectoPOS_Lopin.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOS_Lopin.CapaPresentacion
{
    public partial class FormCliente2 : Form
    {
        int clienteId = 0;
        ClienteBLL bll = new ClienteBLL();
        private object ex;

        public FormCliente2()
        {
            InitializeComponent();
        }
        private void CargarLista()
        {
            dgvClientedos.DataSource = bll.Listar();
        }

        private void FrmClientedos_Load(object sender, EventArgs e)
        {
            {
                CargarLista();
                Limpiar();
            }
        }

        void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            chkEstado.Checked = true;
            txtBuscar.Clear();
            txtNombre.Focus();

        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente2 c = new Cliente2()
                {
                    Id = clienteId,//Si es 0 es nuevo registro, si tiene valor es Modificación
                    Nombre = txtNombre.Text,
                    Telefono = int.Parse(txtTelefono.Text),
                    Correo = txtEmail.Text,
                    Estado = chkEstado.Checked
                };
                //Llamamos al metodo guardar de la BLL(EL DECIDE SI ES INSERT O UPDATE)
                int id = bll.Guardar(c);
                MessageBox.Show("Cliente guardado con exito.", "Notificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLista();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientesdos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clienteId = Convert.ToInt32(dgvClientedos.Rows[e.RowIndex].Cells["Id"].Value);
                txtNombre.Text = dgvClientedos.Rows[e.RowIndex].Cells["NombreCompleto"].Value.ToString();
                txtTelefono.Text = dgvClientedos.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtEmail.Text = dgvClientedos.Rows[e.RowIndex].Cells["CorreoC"].Value.ToString();
                chkEstado.Checked = Convert.ToBoolean(dgvClientedos.Rows[e.RowIndex].Cells["Estado"].Value);
            }
            ;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteId == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar el cliente seleccionado?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Eliminar(clienteId);
                CargarLista();
                Limpiar();
            }
        }



        private void FormCliente2_Load(object sender, EventArgs e)
        {
            dgvClientedos.DataSource = bll.Buscar(txtBuscar.Text);
        }

        private void dgvClientedos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente2 c = new Cliente2()
                {
                    Id = clienteId, //Si es 0 es nuevo registro, ti siente valor es modificacion
                    Nombre = txtNombre.Text,
                    Telefono = int.Parse(txtTelefono.Text),
                    Correo = txtEmail.Text,
                    Estado = chkEstado.Checked,
                };
                //LLamamos al metodo guardar de la BLL ( El decide si es insert o update
                int id = bll.Guardar(c);
                MessageBox.Show("Cliente guardado conn exito.", "Notificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLista();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
        }
    



        

           
            

        
    
    

