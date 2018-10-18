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
        BDHelper datos = new BDHelper();
        int id_pac;
        public frmAtencion1(int paciente)
        {
            InitializeComponent();
            id_pac = paciente;
        }

        private void btnGuardarTodo_Click(object sender, EventArgs e)
        {
            //string sql2 = "Insert into Plan_T (id_plan, id_dieta) values (" + textBox1.Text + "," + txtDuracion.Text + ")";
            //string sql3= "SELECT MAX (id_plan) FROM Plan _T ";

            //string str_sql = "Insert into Atenciones_Medicas (motivo_consulta, diagnostico, plan_terapeutico) values ('"
              //  + rtbMotivo.Text + "', '" + rtbDiagnostico.Text + "', ";
        }

    }
}
