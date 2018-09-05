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
    public partial class frmPrincipal : Form
    {
        DataTable miTabla;
        BDHelper origen;
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            origen = new BDHelper();
            miTabla = new DataTable();
            miTabla = origen.cargarTabla("Turnos");
            cmbPrueba.DataSource = miTabla;
            cmbPrueba.DisplayMember = miTabla.Columns[].ColumnName;
            cmbPrueba.ValueMember = miTabla.Columns[0].ColumnName;
        }
    }
}
