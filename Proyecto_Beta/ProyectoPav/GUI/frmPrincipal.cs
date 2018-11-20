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

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPaciente open = new frmPaciente();
            open.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmElegirPaciente formis = new frmElegirPaciente();
            formis.ShowDialog();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            frmMedicamentos frm = new frmMedicamentos();
            frm.ShowDialog();
        }

        private void btnHistoriaClinica_Click(object sender, EventArgs e)
        {
            frmRepoHistorias formi = new frmRepoHistorias();
            formi.ShowDialog();
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            frmIngresarAnio  opne = new frmIngresarAnio();
            opne.ShowDialog();
        }



    }
}
