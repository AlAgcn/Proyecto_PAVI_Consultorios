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
        Boolean rm;
        public frmMedicamentos()
        {
            InitializeComponent();
        }

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            deshabilitarBotones();
        }

        private void deshabilitarBotones()
        {
            txtMonodroga.Enabled = false;
            txtLaboratorio.Enabled = false;
            txtFarmaco.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void habilitarBotones()
        {
            txtMonodroga.Enabled = true;
            txtLaboratorio.Enabled = true;
            txtFarmaco.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFarmaco.Text = new BDHelper().consultaTabla_parametros("Select monodroga from Medicamentos where id=" + txtId.Text).Rows[0][0].ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarBotones();
            nv = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            md = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            rm = true;
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
                    new BDHelper().consultaSQL("UPDATE Medicamentos SET monodroga='" + txtMedicamento.Text + "',farmaco='" + txtFarmaco.Text + "',laboratorio='" + txtLaboratorio.Text + "' WHERE id=" + txtId.Text);

                }
            nv = false;
            md = false;
            txtId.ResetText();
            txtFarmaco.ResetText();
            txtLaboratorio.ResetText();
            txtMedicamento.ResetText();
            deshabilitarBotones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
