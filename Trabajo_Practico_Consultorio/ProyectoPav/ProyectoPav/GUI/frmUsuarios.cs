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
       
        Boolean flagNuevo = false;
        Boolean flagModificar = false;
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
            llenarCombo(cmbPerfil, "Perfiles", "Perfil", "id");
            cmbPerfil.Enabled = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            cmbPerfil.Enabled = true;
            llenarCombo(cmbPerfil, "Perfiles", "Perfil", "id");
            flagNuevo = true;
            


            lstUsuario.ResetText();
            new frmPrincipal().cargarLista(lstUsuario, "Users", "Usuario", "id");

        }
        public void llenarCombo(ComboBox combo, String tabla, string display, string value)
        {
            combo.DataSource = new BDHelper().consulta_oldb("Select * from "+tabla);
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!((txtUsuario.Text == String.Empty) || (txtPassword.Text==String.Empty) || (txtConfirmarPassword.Text==String.Empty) || (cmbPerfil.Text==String.Empty )))
            {
                if (txtConfirmarPassword.Text==txtPassword.Text)
            
            
                { 
                    if (flagNuevo)
                    {
                        string str_sql = "INSERT INTO Users (Password,Usuarios, id_perfil, Estado) VALUES('don', 'dola',1, 'S')";

                        if (new BDHelper().consultaOldb(str_sql) > 0)
                        {
                            MessageBox.Show("Usuario agregado con Extio", "Nuevo Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    }
                    if (flagModificar)
                    {
                        string str_sql = "UPDATE Users SET Password='"+txtPassword.Text+"',Usuarios='"+txtUsuario.Text+"',id_perfil="+cmbPerfil.SelectedValue.ToString()+" WHERE id="+lstUsuario.SelectedValue.ToString();
                        if (new BDHelper().consultaOldb(str_sql) > 0)
                        {
                            MessageBox.Show("Usuario modificado con Extio", "Usuario Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Algunos campos no tienen valores", "Errores de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
        }

        private void cmdSalir_Click(object sender, EventArgs e)
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
           if(!(lstUsuario.SelectedIndex==-1))
           {
            habilitarCampos();
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            cmbPerfil.Enabled = true;
            llenarCombo(cmbPerfil, "Perfiles", "Perfil", "id");
            flagModificar = true;
           }
            else
            {
                MessageBox.Show("Debe seleccionar algun usuario", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (!(lstUsuario.SelectedIndex == -1))
            {
                            if (MessageBox.Show("¿Desea eliminar al usuario?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                string str_sql = "UPDATE Users Set Estado ='N', WHERE id=" + lstUsuario.SelectedValue.ToString();
                                if (new BDHelper().consultaOldb(str_sql) > 0)
                                {
                                    MessageBox.Show("Usuario eliminado con Extio", "Usuario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                }

                            }
            }
            else
            {
                MessageBox.Show("Debe seleccionar algun usuario", "Error de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






    }
}
