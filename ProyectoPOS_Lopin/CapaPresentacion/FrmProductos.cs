using ProyectoPOS_Lopin.CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOS_Lopin.CapaPresentacion
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        //creaciond e una lsita estatica que simulara la DB 
        public static List<Producto> ListaProducto = new List<Producto>();
        private void DeshabilitarBotones()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnlimpiarcampo.Enabled = false;
            btnnuevo.Enabled = true;
        }
        private void HabilitarBotones()
        {
            btnnuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnlimpiarcampo.Enabled = true;
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void FrmProductos_Load(object sender, EventArgs e)

        {
            DeshabilitarBotones(); //al iniciar, no esten activos
            //cargar los datos iniciales 
            if (!ListaProducto.Any())
            {

                ListaProducto.Add(new Producto
                {
                    Id = 1,
                    Nombre = "Cafe Gourmet",
                    Descripcion = "Importado",
                    Precio = 10.5m,
                    Stock = 100,
                    Estado = true
                });
                ListaProducto.Add(new Producto
                {
                    Id = 2,
                    Nombre = "Cafe Borno",
                    Descripcion = "De Altura",
                    Precio = 20.0m,
                    Stock = 100,
                    Estado = true
                });
                ListaProducto.Add(new Producto
                {
                    Id = 3,
                    Nombre = "Cheesscake",
                    Descripcion = "Dulce Sabor",
                    Precio = 15.75m,
                    Stock = 100,
                    Estado = true
                });
            }
            RefrescarGrid();//mando a llamar el metodo para refrescar el datagridview
        }


        // private object listaProductos;



        private void RefrescarGrid()
        {
            dgvProducto.AutoGenerateColumns = true;
            dgvProducto.DataSource = null; // Limpiar el DataSource antes de reasignarlo
            dgvProducto.DataSource = ListaProducto; // Asignar la lista como DataSource
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Validación de nombre
            if (string.IsNullOrWhiteSpace(label6.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                label6.Focus();
                return;
            }

            // Validación de precio
            if (!Validacion.EsDecimal(label4.Text))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                label4.Focus();
                return;
            }

            // Validación de stock
            if (!Validacion.EsEntero(chk.Text))
            {
                MessageBox.Show("El stock debe ser un número entero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                chk.Focus();
                return;
            }

            // Crear un producto nuevo
            Producto nuevo = new Producto
            {
                Id = ListaProducto.Count + 1,
                Nombre = label6.Text,
                Descripcion = label3.Text,
                Precio = decimal.Parse(label4.Text),
                Stock = int.Parse(textStock.Text),
            };

            //Crear un producto y asignar Id incremental manualmente
            int nuevoId = ListaProducto.Any() ? ListaProducto.Max(x => x.Id) + 1 : 1;
            var p = new Producto
            {
                Id = ListaProducto.Count + 1,
                Nombre = label6.Text,
                Descripcion = label3.Text,
                Precio = decimal.Parse(label4.Text),
                Stock = int.Parse(textStock.Text),
            };

            // Agregarlo a la listaE
            ListaProducto.Add(nuevo);
            RefrescarGrid();//refrescar el datagridview
            //limpiar los controles
            MessageBox.Show("Producto agregado correctamente.");
        }



        //metodo para limpiar los controles
        private void LimpiarCampos()
        {
            textCodigo.Text = "";
            label6.Text = "";
            label3.Text = "";
            label4.Text = "";
            chk.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducto.CurrentRow == null) return;
            //Obtener el producto seleccionado
            textCodigo.Text = dgvProducto.CurrentRow.Cells["Id"].Value.ToString();
            textNombre.Text = dgvProducto.CurrentRow.Cells["Nombre"].Value.ToString();
            textDescripcion.Text = dgvProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
            textPrecio.Text = dgvProducto.CurrentRow.Cells["Precio"].Value.ToString();
            textStock.Text = dgvProducto.CurrentRow.Cells["Stock"].Value.ToString();
            chk.Text = dgvProducto.CurrentRow.Cells["Estado"].Value.ToString();

            //Habilitar los botones de editar y eliminar
            HabilitarBotones();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textCodigo.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto válido para eliminar.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prod = ListaProducto.FirstOrDefault(x => x.Id == id);
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar el producto seleccionado?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListaProducto.Remove(prod);//con remove elimino el producto de la lista
                RefrescarGrid();//refrescar el datagridview
                LimpiarCampos();//limpiar los controles
                DeshabilitarBotones();
            }
        }
        //Evento para editar un producto
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //valido que el id sea un entero
            if (!int.TryParse(textCodigo.Text, out int id))
            {
                MessageBox.Show("Seleccione un producto válido para eliminar.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //busco el producto en la lista
            var prod = ListaProducto.FirstOrDefault(x => x.Id == id);
            //si lo encuentro, actualizo sus propiedades
            if (prod == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Validaciones identicas a las del boton guardar
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNombre.Focus();
                return;

            }
        }

        private void btnnuevo_Click_1(object sender, EventArgs e)

        {
            // Validación de nombre
            if (string.IsNullOrWhiteSpace(label6.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                label6.Focus();
                return;
            }

            // Validación de precio
            if (!Validacion.EsDecimal(label4.Text))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                label4.Focus();
                return;
            }

            // Validación de stock
            if (!Validacion.EsEntero(chk.Text))
            {
                MessageBox.Show("El stock debe ser un número entero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                chk.Focus();
                return;
            }

            // Crear un producto nuevo
            Producto nuevo = new Producto
            {
                Id = ListaProducto.Count + 1,
                Nombre = label6.Text,
                Descripcion = label3.Text,
                Precio = decimal.Parse(label4.Text),
                Stock = int.Parse(textStock.Text),
            };

            //Crear un producto y asignar Id incremental manualmente
            int nuevoId = ListaProducto.Any() ? ListaProducto.Max(x => x.Id) + 1 : 1;
            var p = new Producto
            {
                Id = ListaProducto.Count + 1,
                Nombre = label6.Text,
                Descripcion = label3.Text,
                Precio = decimal.Parse(label4.Text),
                Stock = int.Parse(textStock.Text),
            };

            // Agregarlo a la listaE
            ListaProducto.Add(nuevo);
            RefrescarGrid();//refrescar el datagridview
            //limpiar los controles
            MessageBox.Show("Producto agregado correctamente.");
            DeshabilitarBotones();
        }

       
    }
    
}




