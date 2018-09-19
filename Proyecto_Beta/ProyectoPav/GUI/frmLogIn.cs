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
    public partial class frmLogIn : Form
    {
        private Boolean salir = true;
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuarios.Text) || String.IsNullOrEmpty(txtPasswords.Text))
            {
                MessageBox.Show("No ingreso usuario y/o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswords.Clear();
                txtUsuarios.Clear();
                txtUsuarios.Focus();
            }
            else
            {
                DataTable tabla = new DataTable();
                String comand = "SELECT Usuario,Password from Users WHERE Usuario='" + txtUsuarios.Text + "' and Password ='" + txtPasswords.Text + "'";
                tabla = new BDHelper().consultaTabla_parametros(comand);
                if (tabla.Rows.Count == 0)
                {
                    txtUsuarios.Clear();
                    txtPasswords.Clear();
                    MessageBox.Show("Usuario y/o contraseña incorrecto", "Inicio Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuarios.Focus();

                }
                else
                {
                    MessageBox.Show("Bienvenido "+ txtUsuarios.Text, "Inicio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salir = false;
                    this.Close();
                }
            }
                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir)
            {
                if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                { e.Cancel = true;
                txtUsuarios.Clear();
                txtPasswords.Clear();
                txtUsuarios.Focus();
                }
                else
                {
                   Environment.Exit(0);
                }
            }
            else
            { e.Cancel = false; }
        }

    }

}
