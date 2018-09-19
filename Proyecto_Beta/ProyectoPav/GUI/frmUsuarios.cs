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
        bool newu = false;
        bool modu = false;
        bool delu = false;
        frmPrincipal principal = new frmPrincipal();
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
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmarPassword.Enabled = true;
            cmbPerfil.Enabled = true;
            principal.llenarCombo(cmbPerfil, "Perfiles", "n_perfil", "id_perfil");
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private bool camposLlenos()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtConfirmarPassword.Text))
                return false;
            else
                return true;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            deshabilitarCampos();
            new frmPrincipal().cargarLista(lstUsuario, "Users where Estado='S'", "Usuario", "id");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            newu = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {   
            if (newu)
            {
                if (camposLlenos())
                {
                    nuevoUsuario();
                    newu = false;
                }
                else
                    MessageBox.Show("Debe completar todos los campos", "Campo/s vacio/s", MessageBoxButtons.OK);
            }
            else if(modu)
                {
                    if (camposLlenos())
                    {
                        modificarUsuario();
                        modu = false;
                    }
                    else 
                        MessageBox.Show("Debe completar todos los campos", "Campo/s vacio/s", MessageBoxButtons.OK);
                }
            else if (delu)
            {
                eliminarUsuario();
                delu = false;
            }
            deshabilitarCampos();
            principal.cargarLista(lstUsuario, "Users", "Usuario", "id");
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            newu = false;
            modu = false;
            delu = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarCampos();
            txtPassword.Text = String.Empty;
            txtUsuario.Text = String.Empty;
            txtConfirmarPassword.Text = String.Empty;
            cmbPerfil.SelectedIndex = -1;
            lstUsuario.SelectedIndex = -1;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            newu = false;
            modu = false;
            delu = false;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            modu = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            delu = true;
          }

        private void nuevoUsuario()
        {
            if (new BDHelper().siExiste("Users", "Usuario", txtUsuario.Text) == true  || txtConfirmarPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("El usuario ingresado ya existe, o las constraseñas no coinciden", "Datos Fallidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Usuario agregado", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }

                lstUsuario.ResetText();
                new frmPrincipal().cargarLista(lstUsuario, "Users", "Usuario", "id");
                deshabilitarCampos();
                newu = false;
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
            
            private void modificarUsuario()
        {
            habilitarCampos();
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;

                if (new BDHelper().siExiste("Users", "Usuario", txtUsuario.Text) )
                {
                    if (txtConfirmarPassword.Text == txtPassword.Text)
                    {
                        string str_sql = "UPDATE Users SET Password='" + txtPassword.Text +
                           "',id_perfil='" + cmbPerfil.SelectedValue.ToString() +
                           "' WHERE Usuario='" + txtUsuario.Text + "'";
                        if (new BDHelper().consultaSQL(str_sql) > 0)
                        {
                            MessageBox.Show("Usuario modificado", "Usuario Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                        MessageBox.Show("Las contraseñas ingresadas no coinciden", "Contraseña invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe ingresar algun usuario", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
              
            }
        private void eliminarUsuario()
            {
                if (new BDHelper().siExiste("Users", "Usuario", txtUsuario.Text))
            {
                if (MessageBox.Show("¿Desea eliminar al usuario? " + txtUsuario.Text, "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string str_sql = "UPDATE Users Set Estado ='N' WHERE Usuario='" + txtUsuario.Text + "'";
                    if (new BDHelper().consultaSQL(str_sql) > 0)
                    {
                        MessageBox.Show("Usuario eliminado", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }

                }
                else
                {
                    MessageBox.Show("El usuario ingresado no existe", "Usuario no encontrado", MessageBoxButtons.OK);
                    txtUsuario.Clear();
                }
                }
            }
    }
}
