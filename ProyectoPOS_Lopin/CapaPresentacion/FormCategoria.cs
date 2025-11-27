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
    public partial class FormCategoria : Form
    {
        CategoriaBLL bll = new CategoriaBLL();
        int categoriaID = 0; // Guarda el ID seleccionado
        string Modo = "Nuevo"; //Buevo o Editar

        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
            HabilitarBotones();

        }
        void HabilitarBotones()
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvControlCategoria.ClearSelection();
            dgvControlCategoria.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dgvControlCategoria.SelectedRows.Count > 0;
                btnModificar.Enabled = filaSeleccionada;
                btnEliminar.Enabled = filaSeleccionada;
            };
        }
        void CargarDatos()
        {
            dgvControlCategoria.DataSource = bll.Listar();
            dgvControlCategoria.ClearSelection();
            categoriaID = 0;   // Reiniciar ID seleccionado

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvControlCategoria.DataSource = bll.Buscar(btnBuscar.Text);
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si clickeamos una fila válida
            if (e.RowIndex >= 0)
            {
                categoriaID = Convert.ToInt32(dgvControlCategoria.Rows[e.RowIndex].Cells["Id"].Value);
            }

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormCategoriaGestion frm = new FormCategoriaGestion(); //Aca dará error hasta que construyamos el Formulario llamado  FrmCategoriaGestion

            // MODO CREAR NUEVA CATEGORIA
            frm.Modo = "Nuevo"; //definimos por defecto que sea “nuevo”
            frm.Id = 0; //Guardara el Id que traigamos  del FrmCategoriaGestion

            frm.ShowDialog();  // Abrir como modal
            CargarDatos();     // Refrescar al cerrar

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (categoriaID == 0)
            {
                MessageBox.Show("Seleccione una categoría",
                   "Información",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }
            FormCategoriaGestion frm = new FormCategoriaGestion();
            // MODO EDITAR
            frm.Modo = "Editar";
            frm.Id = categoriaID;

            // Pasar información desde el DGV
            frm.NombreCategoria = dgvControlCategoria.CurrentRow.Cells["NombreCategoria"].Value.ToString();
            frm.Descripcion = dgvControlCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (categoriaID == 0)
            {
                MessageBox.Show("Seleccione una categoría",
                   "Información",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;

            }
            // Abrir formulario de eliminación
            FormCategoriaEliminar frm = new FormCategoriaEliminar();

            frm.Id = categoriaID;
            frm.NombreCategoria = dgvControlCategoria.CurrentRow.Cells["NombreCategoria"].Value.ToString();
            frm.Descripcion = dgvControlCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();

            frm.ShowDialog();
            CargarDatos();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvControlCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si clickeamos una fila válida
            if (e.RowIndex >= 0)
            {
                categoriaID = Convert.ToInt32(dgvControlCategoria.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }
    }
}
  


