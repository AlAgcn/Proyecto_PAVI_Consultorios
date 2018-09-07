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
        BDHelper oDatos = new BDHelper();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void cargarLista (ListBox lista)
        {
            lista.DataSource = oDatos.cargarTabla("Users");
            lista.DisplayMember = "Usuario";
            lista.ValueMember = "id";
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarLista(lstUsuario);
        }
    }
}
