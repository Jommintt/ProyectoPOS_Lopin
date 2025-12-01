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

        }

        private void btmProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            {
                FormCliente2 frm = new FormCliente2();
                frm.ShowDialog();
            }
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            FrmPruebas frm = new FrmPruebas();
            frm.ShowDialog();
        }
    }
}








