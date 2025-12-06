using ProyectoPOS_Lopin.CapaEntidades;
using ProyectoPOS_Lopin.CapaPresentacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOS_Lopin
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
             lblUsuarios.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";

            /// Control básico por rol
//Con este codigo deshabilitamos un botón de prueba para el usuario cajero, por ejemplo que no pueda Registrar Cliente(ojo esto es solo prueba)
            switch (SesionActual.Rol)
            {
                case "Admin":
                    // todo habilitado
                    break;
                case "Cajero":
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;
                default:
                    btnClientes.Enabled = false;
                    btnUsuarios.Enabled = false;
                    break;

            }


        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente2 frm = new FormCliente2();
            frm.ShowDialog();
        }

        private void btmProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.ShowDialog();
        }



        private void btnPruebas_Click(object sender, EventArgs e)
        {
            FrmPruebas frm = new FrmPruebas();
            frm.ShowDialog();
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
        }

        private void btnReportePDF_Click(object sender, EventArgs e)
        {
            FormReporteVentas frm = new FormReporteVentas();
            frm.ShowDialog();

        }
    }
}








