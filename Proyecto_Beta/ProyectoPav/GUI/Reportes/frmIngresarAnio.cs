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
    public partial class frmIngresarAnio : Form
    {
        public frmIngresarAnio()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmGrafiquin open = new frmGrafiquin(int.Parse(textBox1.Text));
            open.ShowDialog();

        }
    }
}
