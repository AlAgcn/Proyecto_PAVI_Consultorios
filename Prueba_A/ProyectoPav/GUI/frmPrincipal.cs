using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ProyectoPav
{
    public partial class frmPrincipal : Form
    {
        DataTable miTabla;
        BDHelper origen;
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            new frmLogIn().ShowDialog();
        }
        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            frmUsuarios open = new frmUsuarios();
            open.ShowDialog();
        }
    }
}
