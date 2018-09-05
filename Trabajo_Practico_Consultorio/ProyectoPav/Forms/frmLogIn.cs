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
    public partial class frmLogIn : Form
    {
        private BDHelper oDatos;
        private DataTable tabla;
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
                txtUsuarios.Focus();
            }
            else
            {
                oDatos= new BDHelper();
                tabla = new DataTable();
                String comand = "SELECT Usuarios,Password from Users WHERE Usuarios= '" + txtUsuarios.Text + "' and Password = '" + txtPasswords.Text + "'";
                tabla = oDatos.consultaTabla(comand);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("Todo Mal haces", "Mal Ali", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Una bien", "Atroden", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                }
            }
                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
