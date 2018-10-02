using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace copia
{
    public partial class frmElegirPaciente : Form
    {
        public frmElegirPaciente()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.DataSource==null)
            {
                dgvPacientes.DataSource = new BDHelper().consulta_oldb("SELECT Nombre, Apellido, DNI, Historia_Clinica FROM Pacientes "+ new frmElegirPaciente().Parametros(txtNombre,txtHistoria,txtDni,txtApellido,"Nombre","Historia_Clinica","DNI","Apellido"));
            }
            else
            {
                dgvPacientes.DataSource = null;
                dgvPacientes.DataSource = new BDHelper().consulta_oldb("SELECT Nombre, Apellido, DNI, Historia_Clinica FROM Pacientes " + new frmElegirPaciente().Parametros(txtNombre, txtHistoria, txtDni, txtApellido, "Nombre", "Historia_Clinica", "DNI", "Apellido"));

            }
        }
        private string Parametros(TextBox txt1,TextBox txt2, TextBox txt3, TextBox txt4,string par1, string par2, string par3,string par4)
        {
            string str="WHERE 1=1";
            if (!(txt1.Text==string.Empty))
                {
                    str += " AND " + par1 + "='" + txt1.Text + "'";
                }
            if (!(txt2.Text == string.Empty))
            {
                str += " AND " + par2 + "='" + txt2.Text + "'";
            }
            if (!(txt3.Text == string.Empty))
            {
                str += " AND " + par3 + "='" + txt3.Text + "'";
            }
            if (!(txt4.Text == string.Empty))
            {
                str += " AND " + par4 + "='" + txt4.Text + "'";
            }
            return str;

        }

        private void cmdDetalle_Click(object sender, EventArgs e)
        {
            string str = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
            int histo = int.Parse(dgvPacientes.CurrentRow.Cells[3].Value.ToString());
            frmAtencion formi = new frmAtencion(str, histo);
            formi.ShowDialog();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
