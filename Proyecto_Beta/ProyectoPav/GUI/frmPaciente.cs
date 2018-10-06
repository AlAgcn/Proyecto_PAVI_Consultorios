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
        }

        private void deshabilitarCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDNI.Enabled = false;
            txtObraSocial.Enabled = false;
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
            txtObraSocial.Enabled = true;
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
            txtObraSocial.ResetText();
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
            paciente.obra_Social = txtObraSocial.Text;
            paciente.nro_Afiliado = int.Parse(txtNumeroDeSocio.Text);
            paciente.domicilio = txtDomicilio.Text;
            if (pacienteHelper.agregarPaciente(paciente))
                MessageBox.Show("Paciente Agredado", "Añadir Paciente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        

        private void eliminarPaciente()
        {
            throw new NotImplementedException();
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
                eliminarPaciente();

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
    }
}
