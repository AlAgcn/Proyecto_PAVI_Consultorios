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
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void cargarLista(ListBox lista, String tabla, string display, string value)
        {
            lista.DataSource = new BDHelper().consultaTabla_parametros("Select * FROM " + tabla);
            lista.DisplayMember = display;
            lista.ValueMember = value;
        }

        public void llenarCombo(ComboBox combo, String tabla, string display, string value)
        {
            combo.DataSource = new BDHelper().cargarTabla(tabla);
            combo.DisplayMember = display;
            combo.ValueMember = value;
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

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedico abrir = new frmMedico();
            abrir.ShowDialog();
        }

    }
}
