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
    public partial class frmMedico : Form
    {
        BDHelper helper = new BDHelper();
        FunctionHelper funciones = new FunctionHelper();
        bool newm = false;
        bool modm = false;
        bool delm = false;
        public frmMedico()
        {
            InitializeComponent();
        }

        private void deshabilitarCampos()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            dtpFecha.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            dtpFecha.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            deshabilitarCampos();
            funciones.cargarLista(lstMedicos, "Medicos", "Apellido", "id");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            newm = true;
        }

        private void nuevoMedico()
        {
            string sql = "INSERT INTO Medicos (Nombre, Apellido, Fecha_Ingreso, Estado) values ('" +
                          txtNombre.Text + "','" +
                          txtApellido.Text + "','" +
                          dtpFecha.Value.ToShortDateString() + "', 'S')";
            if (helper.consultaSQL(sql) > 0)
            {
                MessageBox.Show("Medico agregado", "Nuevo Medico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            txtNombre.ResetText();
            txtApellido.ResetText();
            dtpFecha.ResetText();
            deshabilitarCampos();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            newm = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            modm = true;
        }

        private void modificarMedico()
        {
            string sql = "UPDATE Medicos SET Nombre='" + txtNombre.Text + "', Apellido='" + txtApellido.Text + "' WHERE Nombre='" + lstMedicos.SelectedValue.ToString() + "'";
            if (helper.consultaSQL(sql) > 0)
            {
                MessageBox.Show("Usuario modificado", "Usuario Modificado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            delm = true;
        }

        private void eliminarMedico()
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (newm)
            {
                nuevoMedico();
            }
            else if (modm)
            {
                modificarMedico();
            }
            else
                eliminarMedico();

            deshabilitarCampos();
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
            txtNombre.ResetText();
            txtApellido.ResetText();
            dtpFecha.ResetText();
            funciones.cargarLista(lstMedicos, "Medicos", "id", "Apellido");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtApellido.Clear();
            dtpFecha.ResetText();
            deshabilitarCampos();
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
