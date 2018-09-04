using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;

namespace Trabajo_Practico_Consultorio
{
    /// <summary>
    /// Lógica de interacción para frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text == String.Empty || txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Ingrese algo en los campos");
            }
            else
            {
                BDHelper_Access oDatos = new BDHelper_Access();
                DataTable tablita = oDatos.consultaOLDB("SELECT * FROM Users WHERE Usuarios = \'" + txtUsuario.Text + "\' AND Password = \'" + txtPassword.Text + "\'");
                    
                if (tablita.Rows.Count >0)
                {
                    MainWindow frmPrincipal = new MainWindow();
                    MessageBox.Show("Has ingresado con exito");
                    frmPrincipal.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Escribio los datos incorrectos");
                }
            }
        }
    }
}
