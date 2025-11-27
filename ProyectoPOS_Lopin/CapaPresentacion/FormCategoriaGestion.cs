using ProyectoPOS_Lopin.CapaEntidades;
using ProyectoPOS_Lopin.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOS_Lopin.CapaPresentacion
{
    public partial class FormCategoriaGestion : Form
    {
        //Definimos estos atributos para recibir datos desde FrmCategoria y guardarlos acá
        public string Modo { get; set; }        // Define la acción
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        CategoriaBLL bll = new CategoriaBLL();
        public FormCategoriaGestion()
        {
            InitializeComponent();
        }

        private void FormCategoriaGestion_Load(object sender, EventArgs e)
        {
            if (Modo == "Nuevo")
            {
                lblTitulo.Text = "AGREGAR NUEVA CATEGORÍA";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR CATEGORÍA";
                // Cargar datos en controles
                txtNombreCategoria.Text = NombreCategoria;
                txtDescripcion.Text = Descripcion;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


      

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar un nombre para la categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                // Creamos objeto categoría
                Categoria c = new Categoria
                {
                    Id = Id,
                    NombreCategoria = txtNombreCategoria.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };
                bll.Guardar(c);

                MessageBox.Show(
                    Modo == "Nuevo"
                        ? "La categoría ha sido registrada correctamente."
                        : "Los cambios han sido guardados correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error al interactuar con la base de datos.\n\nDetalles técnicos:\n" + ex.Message,
                    "Error SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado:\n" + ex.Message,
                    "Error general",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
