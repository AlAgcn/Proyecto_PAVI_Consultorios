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
            new frmPrincipal().llenarCombo(cmbPerfil, "Perfiles", "n_perfil", "id_perfil");
            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (new BDHelper().siExiste("Users", "Usuario", txtUsuario.Text))
            {
                MessageBox.Show("El usuario ingresado ya existe, por favor ingrese uno distinto", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtPassword.Clear();
                txtConfirmarPassword.Clear();
                txtUsuario.Focus();
            }
            else
            {
                string str_sql = "INSERT INTO Users (Usuario, Password, id_perfil, Estado) values('"
                                + txtUsuario.Text + "', '" + txtPassword.Text + "', '" + cmbPerfil.SelectedValue.ToString() + "','S')";

                if (new BDHelper().consultaSQL(str_sql) > 0)
                {
                    MessageBox.Show("Usuario agregado con Extio", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                lstUsuario.ResetText();
                new frmPrincipal().cargarLista(lstUsuario, "Users", "Usuario", "id");
                deshabilitarCampos();
                btnNuevo.Enabled = true;
            }
        }


    }
}
