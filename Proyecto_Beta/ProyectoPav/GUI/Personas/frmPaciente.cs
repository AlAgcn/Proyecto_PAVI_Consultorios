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
    public partial class frmPaciente : Form
    {
        clsPaciente paciente;
        PacienteHelper pacienteHelper = new PacienteHelper();
        bool newp = false;
        bool modp = false;
        bool delp = false;
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            deshabilitarCampos();
            new FunctionHelper().llenarCombo(cboObraSocial, "Obras_Sociales", "n_obrasocial", "id");
        }

        private void deshabilitarCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDNI.Enabled = false;
            cboObraSocial.Enabled = false;
            txtNumeroDeSocio.Enabled = false;
            txtTelefono.Enabled = false;
            txtDomicilio.Enabled = false;
            dtpNacimiento.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDNI.Enabled = true;
            cboObraSocial.Enabled = true;
            txtNumeroDeSocio.Enabled = true;
            txtTelefono.Enabled = true;
            txtDomicilio.Enabled = true;
            dtpNacimiento.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void blanquearCampos()
        {
            txtNombre.ResetText();
            txtApellido.ResetText();
            txtDNI.ResetText();
            txtTelefono.ResetText();
            cboObraSocial.ResetText();
            txtNumeroDeSocio.ResetText();
            txtDomicilio.ResetText();
            dtpNacimiento.ResetText();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            newp = true;
        }

        private void nuevoPaciente()
        {
            paciente = new clsPaciente();
            paciente.nombre = txtNombre.Text;
            paciente.apellido = txtApellido.Text;
            paciente.dni = int.Parse(txtDNI.Text);
            paciente.telefono = int.Parse(txtTelefono.Text);
            paciente.nacimiento = dtpNacimiento.Text;
            paciente.obra_Social = int.Parse(cboObraSocial.SelectedValue.ToString());
            paciente.nro_Afiliado = int.Parse(txtNumeroDeSocio.Text);
            paciente.domicilio = txtDomicilio.Text;
            if (pacienteHelper.agregarPaciente(paciente))
                MessageBox.Show("Paciente Agredado", "Añadir Paciente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void eliminarPaciente()
        {
            PacienteHelper paci = new PacienteHelper();
           bool bol= paci.eliminarPaciente(txtNombre.Text, txtApellido.Text);
            if (bol)
            {
                MessageBox.Show("se elimino con exito");
            }

        }

        private void modificarPaciente()
        {
            throw new NotImplementedException();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (newp)
                nuevoPaciente();
            else if (modp)
                modificarPaciente();
            else if (delp)
            {
                if(txtApellido.Text==string.Empty && txtNombre.Text==string.Empty  )
                {
                    MessageBox.Show("tiene que llenar ambos campos");
                }
                else
                { eliminarPaciente();
                }
            
           }

            blanquearCampos();
            deshabilitarCampos();
            newp = false;
            modp = false;
            delp = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            blanquearCampos();
            deshabilitarCampos();
            newp = false;
            modp = false;
            delp = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe ingresar el nombre y apellido del paciente");
            deshabilitarCampos();
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            btnGuardar.Enabled = true;
            delp = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clsPaciente paci = new clsPaciente();
            paci.apellido = txtApellido.Text;
            paci.dni = int.Parse(txtDNI.Text);
            paci.domicilio = txtDomicilio.Text;
            paci.nombre=txtNombre.Text;
            paci.nro_Afiliado = int.Parse(txtNumeroDeSocio.Text);
            paci.obra_Social = int.Parse(cboObraSocial.SelectedValue.ToString());
            paci.telefono = int.Parse(txtTelefono.Text);
            PacienteHelper pacih = new PacienteHelper();
            pacih.actualizarPaciente(paci);
        }
    }
}
