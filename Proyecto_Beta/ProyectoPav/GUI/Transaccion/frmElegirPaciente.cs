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
    public partial class frmElegirPaciente : Form
    {
        BDHelper oDatos = new BDHelper();
        public frmElegirPaciente()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string str = "SELECT Nombre,Apellido, dni, n_historiaClinica FROM PACIENTES WHERE 1=1";
            if (!(txtNombre.Text == string.Empty))
                str += " AND Nombre='" + txtNombre.Text + "'";
            if (!(txtApellido.Text == string.Empty))
            {
                str += " AND Apellido='" + txtApellido.Text + "'";
            }
            if (!(txtDni.Text == string.Empty))
            {
                str += " AND dni=" + txtDni.Text + "";
            }
            if (!(txtHistoria.Text == string.Empty))
            {
                str += " AND n_historiaclinica=" + txtHistoria.Text + "";
            }
          dgvPacientes.Rows.Clear();
          DataTable aux = new DataTable();
          aux = oDatos.consultaTabla_parametros(str);
          llenarGrilla(dgvPacientes, aux);
        }

        private void llenarGrilla(DataGridView grilla, DataTable data)
        {
            for (int i=0; i<data.Rows.Count; i++)
            {
                grilla.Rows.Add(data.Rows[i]["Nombre"],
                                data.Rows[i]["Apellido"], 
                                data.Rows[i]["dni"], 
                                data.Rows[i]["n_HistoriaClinica"]);
            }
        }

        private void cmdDetalle_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.Rows.Count != 0)
            {
                string id_paciente = dgvPacientes.CurrentRow.Cells[3].Value.ToString();
                frmAtencion1 form = new frmAtencion1(id_paciente);
                form.ShowDialog();
            }
            else
                MessageBox.Show("Debe seleccionar un paciente", "Error de paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
