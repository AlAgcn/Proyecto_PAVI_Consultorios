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
    public partial class frmRepoHistorias : Form
    {
        BDHelper ayudin= new BDHelper();
        public frmRepoHistorias()
        {
            InitializeComponent();
        }

        private void frmRepoHistorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_3DataSet.Atenciones_Medicas' Puede moverla o quitarla según sea necesario.
            this.Atenciones_MedicasTableAdapter.Fill(this._3DataSet.Atenciones_Medicas);

            this.reportViewer1.RefreshReport();
        }
        private bool validarFechas(TextBox fecha1, TextBox fecha2)
        {
            if (fecha1.TextLength != 10 || fecha2.TextLength != 10)
                return false;

            if (Convert.ToDateTime(fecha1.Text) < Convert.ToDateTime(fecha2.Text))
                return true;
            else
                return false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string str = "SELECT * FROM Atenciones_Medicas WHERE 1=1";
            if (!String.IsNullOrEmpty(txtNroHist.Text))
                str += " AND id_hc=" + txtNroHist.Text;

            if (validarFechas(txtFechaDesde, txtFechaHasta))
                str += " AND fecha between '" + txtFechaDesde.Text + "' and '" + txtFechaHasta.Text + "'";
            else
                MessageBox.Show("Error en las fechas, no estan bien escritas", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Atenciones_MedicasBindingSource.DataSource = ayudin.consultaTabla_parametros(str);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            if (ayudin.siExisteCodigo("Pacientes", "n_HistoriaClinica", txtNroHist.Text))
            {
                string nombre = ayudin.consultaTabla_parametros("SELECT Nombre FROM Pacientes WHERE n_HistoriaClinica=" + txtNroHist.Text).Rows[0][0].ToString();

                txtNombrePac.Text = nombre;
            }
            else
            {
                MessageBox.Show("Historia Clinica No encontrada");
                txtNroHist.ResetText();
                txtNombrePac.ResetText();
            }
        }

        private void txtFechaHasta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
