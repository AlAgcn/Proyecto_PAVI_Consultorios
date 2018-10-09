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
        public frmMedicamentos()
        {
            InitializeComponent();
        }
        Boolean nv;
        Boolean md;
        Boolean rm;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtFarmaco.Text = new BDHelper().consultaTabla_parametros("Select monodrofa from Medicamentos where id=" + txtId.Text).Rows[0][0].ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
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
                new BDHelper().consultaSQL("INSERTE INTO Medicamentos (monodroga,farmaco,laboratorio) VALUES ('" + txtMedicamento.Text + "','" + txtFarmaco.Text + "','" + txtLaboratorio.Text + "')");
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
        }



    }
}
