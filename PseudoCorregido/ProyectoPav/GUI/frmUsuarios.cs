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
        Boolean flagGuardar = false;
        Boolean flagCancelar = false;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void deshabilitarCampos()
        {
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmarPassword.Enabled = false;
          
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
            new frmPrincipal().cargarLista(lstUsuario, "Users", "Usuarios", "id");
            llenarCombo(cmbPerfil, "Users", "Usuario", "id_perfil");
            cmbPerfil.Enabled = true;


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
  

            string str_sql = "INSERT INTO Users (Usuario, Password, id_perfil) values('"
                            + txtUsuario.Text + "','" + txtPassword.Text + "','" + cmbPerfil.Text.ToString() + "')";

            if ( flagGuardar==true && new BDHelper().consultaOldb(str_sql) > 0)
            {
                MessageBox.Show("Usuario agregado con Extio", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            lstUsuario.ResetText();
            new frmPrincipal().cargarLista(lstUsuario, "Users", "Usuario", "id");

        }
        public void llenarCombo(ComboBox combo, String tabla, string display, string value)
        {
            combo.DataSource = new BDHelper().consulta_oldb("Select * from Users");
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string str_sql = "INSERT INTO Users (Usuario, Password, id_perfil) VALUES('"
                            + txtUsuario.Text + "','" + txtPassword.Text + "','" +  cmbPerfil.SelectedValue.ToString() + "')";

            if (new BDHelper().consultaOldb(str_sql) > 0)
            {
                MessageBox.Show("Usuario agregado con Extio", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

    }
}
