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
    public partial class frmPacientes : Form
    {
        bool flaguardar = false;
        bool flagmodificar = false;       
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (MessageBox.Show("seguro que quiere salir","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        public void cargarLista(ListBox lista, String tabla, string display, string value)
        {
            BDHelper oDatos = new BDHelper();
            lista.DataSource = oDatos.consulta_oldb("select * from Pacientes");
            lista.DisplayMember = display;
            lista.ValueMember = value;
            lista.SelectedIndex = -1;
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            cargarLista(lsbPacientes, "Pacientes", "Nombre", "n_HistoriaClinica");
            deshabilitar();
            cmdNuevo.Enabled = true;
            cmdModificar.Enabled = true;
            cmdSalir.Enabled = true;
            cmdEliminar.Enabled = true;
            
        }
        private void inicio()
        {
            cargarLista(lsbPacientes, "Pacientes", "Nombre", "n_HistoriaClinica");
            deshabilitar();
            desahibilitar_campos();
            cmdNuevo.Enabled = true;
            cmdModificar.Enabled = true;
            cmdSalir.Enabled = true;
            cmdEliminar.Enabled = true;
        }
        private void habilitar()
        {
            cmdCancelar.Enabled = true;
            cmdEliminar.Enabled = true;
            cmdGuardar.Enabled = true;
            cmdModificar.Enabled = true;
            cmdNuevo.Enabled = true;
            cmdSalir.Enabled = true;
            cmdCargar.Enabled = true;
        }
        private void deshabilitar()
        {
            cmdSalir.Enabled = false;
            cmdNuevo.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            cmdEliminar.Enabled = false;
            cmdCancelar.Enabled = false;
            cmdCargar.Enabled = false;
        }
        private void borrar()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtHistorial.Text = string.Empty;
            txtObraSocial.Text = string.Empty;
        }
        private void habilitar_campos()
        {
          
           txtTelefono.Enabled=true;
           txtObraSocial.Enabled = true;
           txtNombre.Enabled = true;
           txtHistorial.Enabled = true;
           txtDomicilio.Enabled = true;
           txtDni.Enabled = true;
           txtCodigo.Enabled = true;
           txtApellido.Enabled = true;
        }
        private void desahibilitar_campos()
        {
            txtTelefono.Enabled = false;
            txtObraSocial.Enabled = false;
            txtNombre.Enabled = false;
            txtHistorial.Enabled = false;
            txtDomicilio.Enabled = false;
            txtDni.Enabled = false;
            txtCodigo.Enabled = false;
            txtApellido.Enabled = false;
        }
        private void cargar()
        {
            int cod = int.Parse(lsbPacientes.SelectedValue.ToString());
            Paciente paci = new Paciente();
            paci =new DaoPaciente().getByHistory(cod);
            txtApellido.Text = paci.Apellido;
            txtNombre.Text = paci.Nombre;
            txtTelefono.Text = paci.Telefono.ToString();
            txtCodigo.Text = paci.Telefono.ToString();
            txtDomicilio.Text = paci.Domicilio;
            txtDni.Text = paci.Id_Dni.ToString();
            txtHistorial.Text = paci.Id_HistorialClinico.ToString();
            txtObraSocial.Text = paci.Obra_Social;


 
        }
        private void guardar()
        {
            Paciente paci = new Paciente();
            paci.Apellido = txtApellido.Text;
            paci.Nombre=txtNombre.Text;
            paci.Telefono=int.Parse(txtTelefono.Text);
            paci.Telefono=int.Parse(txtTelefono.Text);
            paci.Domicilio=txtDomicilio.Text;
            paci.Id_Dni=int.Parse(txtDni.Text);
            paci.Id_HistorialClinico=int.Parse(txtHistorial.Text);
            paci.Obra_Social=txtObraSocial.Text ;
            bool flag = new DaoPaciente().agregarPaciente(paci);
            HistorialClinico histo = new HistorialClinico();
            histo.apellido = txtApellido.Text;
            histo.nombre = txtNombre.Text;
            histo.dni = int.Parse(txtDni.ToString());
            flag = new DaoHistorialClinico().agregarHistorial(histo);
        }
        private void modificar()
        {
            Paciente paci = new Paciente();
            paci.Apellido = txtApellido.Text;
            paci.Nombre=txtNombre.Text;
            paci.Telefono=int.Parse(txtTelefono.Text);
            paci.Telefono=int.Parse(txtTelefono.Text);
            paci.Domicilio=txtDomicilio.Text;
            paci.Id_Dni=int.Parse(txtDni.Text);
            paci.Id_HistorialClinico=int.Parse(txtHistorial.Text);
            paci.Obra_Social = txtObraSocial.Text;
            bool flag = new DaoPaciente().actualizarPaciente(paci);
            HistorialClinico histo = new HistorialClinico();
            histo.apellido = txtApellido.Text;
            histo.nombre = txtNombre.Text;
            histo.dni = int.Parse(txtDni.ToString());
            flag = new DaoHistorialClinico().actualizarHistorial(histo);

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            habilitar_campos();
            flaguardar = true;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            cmdCargar.Enabled = true;
            habilitar_campos();
            flagmodificar = true;
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (flagmodificar && validaciones ())
            {
                modificar();
                flagmodificar = false;
                inicio();
            }
            if (flaguardar && validaciones ())
            {
                guardar();
                flaguardar = false;
                inicio();
            }
        }
        private Boolean  validaciones()
        {
            if (txtApellido.Text==string.Empty || txtCodigo.Text==string.Empty || txtDni.Text==string.Empty || txtDomicilio.Text==string.Empty  || txtHistorial.Text== string.Empty || txtNombre.Text==string.Empty || txtObraSocial.Text==string.Empty || txtTelefono.Text==string.Empty)
            {
                MessageBox.Show("Alguno de los campos esta vacio", "Error de campo");
                return false;
            }
            else
            {
                return true;
            }
        }



    }
}
