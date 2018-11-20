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
    public partial class frmMedicamentos : Form
    {
        MedicamentoHelper medhelp = new MedicamentoHelper();
        Boolean nv;
        Boolean md;
        public frmMedicamentos()
        {
            InitializeComponent();
        }

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            deshabilitarBotones();
            new FunctionHelper().cargarListaSinEstado(lstMedicamentos, "Medicamentos", "id", "farmaco");
        }

        private void deshabilitarBotones()
        {
            txtMonodroga.Enabled = false;
            txtLaboratorio.Enabled = false;
            txtFarmaco.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            txtMonodroga.ResetText();
            txtFarmaco.ResetText();
            txtLaboratorio.ResetText();
        }

        private void habilitarBotones()
        {
            txtMonodroga.Enabled = true;
            txtLaboratorio.Enabled = true;
            txtFarmaco.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            nv = true;
            btnModificar.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            md = true;
            habilitarBotones();
            btnNuevo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nv)
            {
                clsMedicamento medic = new clsMedicamento(txtMonodroga.Text, txtFarmaco.Text, txtLaboratorio.Text);
                if (medhelp.agregarMedicamento(medic))
                    MessageBox.Show("Medicamento agregado", "Nuevo Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (md)
                {
                    new BDHelper().consultaSQL("UPDATE Medicamentos SET monodroga='" + txtMonodroga.Text + "',farmaco='" + txtFarmaco.Text + "',laboratorio='" + txtLaboratorio.Text + "' WHERE id=" + lstMedicamentos.SelectedValue.ToString());

                }

            nv = false;
            md = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            txtFarmaco.ResetText();
            deshabilitarBotones();
            new FunctionHelper().cargarListaSinEstado(lstMedicamentos, "Medicamentos", "id", "farmaco");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarBotones();
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            nv = false;
            md = false;
        }

        
    }
}
