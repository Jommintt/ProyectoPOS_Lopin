using ProyectoPOS_Lopin.CapaDatos;
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
    public partial class FormDiseñoVentas : Form
    {
        public FormDiseñoVentas()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }
            DataGridViewRow row = dgvProductos.SelectedRows[0];
            int idProducto = Convert.ToInt32(row.Cells["Id"].Value);
            string nombre = row.Cells["Nombre"].Value.ToString();
            decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
            // Cantidad inicial = 1
            int cantidad = 1;
            decimal subTotal = precio * cantidad;
            // Agregar al detalle
            dgvDetalles.Rows.Add(
            idProducto,
            nombre,
            cantidad,
            precio,
            subTotal
            );
        
            RecalcularTotal();//dará error, mas adelante se creará el método, comenta esta linea cuando ejecutes
        }
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button3_Click(sender, e);
        }
        
        

        private void FormDiseñoVentas_Load(object sender, EventArgs e)
        {
            // --- CLIENTES ---
            cboCliente.DataSource = ClienteDAL.ListarActivos();
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "Id";
            // --- TIPO PAGO ---
            cboMetodoPago.DataSource = MetodoPagoDAL.Listar(); //asiganmos datos al desplegable
            cboMetodoPago.DisplayMember = "Nombre"; //lo que muestra
            cboMetodoPago.ValueMember = "Id"; //el valor que nos importa ID
                                            
                                          
            // --- CONFIGURAR COLUMNAS DEL DETALLE ---
            ConfigurarTablaDetalles();
        }
            private void ConfigurarTablaDetalles()
        {
            dgvDetalles.Columns.Clear();

            // ID PRODUCTO
            DataGridViewTextBoxColumn colIdProd = new DataGridViewTextBoxColumn();
            colIdProd.Name = "Id_Producto";
            colIdProd.HeaderText = "ID";
            colIdProd.Visible = false;
            dgvDetalles.Columns.Add(colIdProd);

            // NOMBRE PRODUCTO
            dgvDetalles.Columns.Add("NombreProducto", "Producto");

            // CANTIDAD
            DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn();
            colCant.Name = "Cantidad";
            colCant.HeaderText = "Cant.";
            dgvDetalles.Columns.Add(colCant);

            // PRECIO UNITARIO
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "PrecioUnitario";
            colPrecio.HeaderText = "Precio Unitario";
            dgvDetalles.Columns.Add(colPrecio);

            // SUBTOTAL
            DataGridViewTextBoxColumn colSub = new DataGridViewTextBoxColumn();
            colSub.Name = "SubTotal";
            colSub.HeaderText = "Subtotal";
            colSub.ReadOnly = true;
            dgvDetalles.Columns.Add(colSub);

            // Asegurar permisos de edición
            dgvDetalles.ReadOnly = false;

            // Columnas NO editables
            dgvDetalles.Columns["SubTotal"].ReadOnly = true;
            dgvDetalles.Columns["PrecioUnitario"].ReadOnly = true;
            dgvDetalles.Columns["NombreProducto"].ReadOnly = true;
            dgvDetalles.Columns["Id_Producto"].ReadOnly = true;

            // ÚNICA columna editable:
            dgvDetalles.Columns["Cantidad"].ReadOnly = false;
            
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)

        { }
        //Meétodo que trae los datos al dgv, colocado fuera del LOAD
        private void CargarProductos(string filtro)
        {
            // Obtenemos la lista desde DAL
            var tabla = ProductoDAL.Listar(); // ya lo creamos en Paso 2
                                              // Filtrar si hay texto
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                var dv = tabla.DefaultView;
                dv.RowFilter = $"Nombre LIKE '%{filtro}%'";
                dgvProductos.DataSource = dv;
            }
            else
            {
                dgvProductos.DataSource = tabla;
            }
            dgvProductos.Columns["Id"].Visible = false;
        }

        private void txtBuscarProducto_Click(object sender, EventArgs e)
        {
            string texto = txtBuscarProducto.Text.Trim();
        }

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarProductos(txtBuscarProducto.Text.Trim());
            }

        }
    
    }
}