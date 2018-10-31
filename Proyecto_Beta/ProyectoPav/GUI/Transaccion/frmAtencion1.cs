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
    public partial class frmAtencion1 : Form
    {
        clsPaciente paciente = new clsPaciente();
        FunctionHelper funciones = new FunctionHelper();
        BDHelper datos = new BDHelper();
        clsMedicamento medicine = new clsMedicamento();
        string id_pac;

        public frmAtencion1(string paciente)
        {
            InitializeComponent();
            id_pac = paciente;
        }

        private void btnGuardarTodo_Click(object sender, EventArgs e)
        {
           if (String.IsNullOrEmpty(rtbMotivo.Text) || String.IsNullOrEmpty(rtbDiagnostico.Text) || dgvMedicamentos.Rows.Count == 0)
               MessageBox.Show("No se completaron todos los campos obligatorios", "Error de atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
           else
               guardarTransaccion();
       }

        private void frmAtencion1_Load(object sender, EventArgs e)
        {
            funciones.cargarListaSinEstado(lstMedicamentos, "Medicamentos", "id", "farmaco");
            funciones.llenarCombo(cboDietas, "Dietas", "n_dieta", "id");
            paciente = new PacienteHelper().getByHistory(int.Parse(id_pac));
            lblNombre.Text = "Nombre y Apellido: " + paciente.nombre+ " " +paciente.apellido;
            lblHistoriaClinica.Text = "Nª de Historia Clinica: " + paciente.historiaClinica.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


       private void guardarTransaccion()
       {
           List<string> transaccion = new List<string>();

           string sql1 = "Insert into Plan_Trp (id_dieta) values (" + cboDietas.SelectedValue.ToString() + ")";

           string sql2 = " declare @idtrp int set @idtrp = IDENT_CURRENT ('Plan_Trp') "
           + "insert into Atenciones_Medicas (id_hc, motivo_consulta, diagnostico, id_planTrp) values ("
           + paciente.historiaClinica + ", '" + rtbMotivo.Text + "', '" + rtbDiagnostico.Text + "',@idtrp)";

          transaccion.Add(sql1);
          transaccion.Add(sql2);

            for (int i = 0; i < dgvMedicamentos.Rows.Count; i++)
           {
               string sqln = "declare @idtrp int set @idtrp = IDENT_CURRENT ('Plan_Trp')"
                + "Insert into Detalle_Medicamento (id_medicamento, frecuencia, duracion, id_plan) values "
                      + "(" + int.Parse(dgvMedicamentos.Rows[i].Cells[0].Value.ToString()) + ", '"
                      + dgvMedicamentos.Rows[i].Cells[3].Value.ToString() + "', '"
                      + dgvMedicamentos.Rows[i].Cells[4].Value.ToString() + "',@idtrp)";

             transaccion.Add(sqln);
          }
        
            datos.conectarTransaccion();

            datos.ejecutarTransaccion(transaccion);

            datos.desconectar();


       }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id_med = int.Parse(lstMedicamentos.SelectedValue.ToString());
            medicine = new MedicamentoHelper().getByID(id_med);
            dgvMedicamentos.Rows.Add(id_med, medicine.Monodroga, medicine.Farmaco, txtFrecuencia.Text, txtDuracion.Text, medicine.Laboratorio);
        }

    }
}
