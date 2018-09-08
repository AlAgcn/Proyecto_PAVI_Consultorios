using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPav
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void deshabilitarCampos()
        {
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmarPassword.Enabled = false;
            cmbPerfil.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmarPassword.Enabled = true;
            cmbPerfil.Enabled = true;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            deshabilitarCampos();
            new frmPrincipal().cargarLista(lstUsuario, "Users", "Usuario", "id");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;

            String str_sql = "INSERT INTO Users (Usuario, Password, Perfil) values('"
                            + txtUsuario.Text + "', " + txtPassword + "', " + cmbPerfil.Text + "'";
            if (new BDHelper().consultaSQL(str_sql))
            {
                MessageBox.Show("Usuario agregado con Extio", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            lstUsuario.ResetText();
            new frmPrincipal().cargarLista(lstUsuario, "Users", "Usuario", "id");

        }


    }
}
