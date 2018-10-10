using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ProyectoPav
{
    public partial class frmAtencion : Form
    {
        string NOM;
        int HISTO;
        int atr;
        public frmAtencion(string nom,int histo)
        {
            InitializeComponent();
            NOM = nom;
            HISTO = histo;
        }
        clsAtencionMedica ate = new clsAtencionMedica();
        FunctionHelper funcioncin = new FunctionHelper();
        private void frmAtencion_Load(object sender, EventArgs e)
        {
            lblPaciente.Text = "Nombre del paciente: "+NOM;
            lblHistorial.Text = "Numero de HC: "+HISTO.ToString();
            gpbAtencion.Text = "Motivos";
            lblAnterior.Text = "Motivos anteriores";
            lblActual.Text = "Motivos actuales";
            sinPlan();
            atr = 1;
            cmdBuffer.Enabled=false;
            funcioncin.cargarLista(lsbMedicamentos, "Medicamentos", "id","farmaco");
            funcioncin.llenarCombo(cboDieta, "Dietas", "n_dieta", "id");
            
        }

        private void cmdMotivos_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Motivos";
            lblAnterior.Text = "Motivos anteriores";
            lblActual.Text = "Motivos actuales";
            sinPlan();
            atr = 1;
        }

        private void cmdRevision_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Revision";
            lblAnterior.Text = "Revision anteriores";
            lblActual.Text = "Revision actual";
            sinPlan();
            atr = 2;

        }

        private void cmdDiagnostico_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Diagnostico";
            lblAnterior.Text = "Diagnostico anteriores";
            lblActual.Text = "Diagnostico actual";
            sinPlan();
            atr = 3;
        }

        private void cmdPlan_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Plan Terapeutico";
            lblAnterior.Text = "Planes anteriores";
            lblActual.Text = "Plan actual";
            atr = 4;
            lblMedicamentos.Visible = true;
            btnAgregar.Visible = true;
            cboDieta.Visible = true;
            rcbActual.Visible = false;
            rcbAnterior.Visible = false;
            lblActual.Visible  = false;
            lblAnterior.Visible  = false;
            lblDietas.Visible= true;
            lblDuracion.Visible  = true;
            lblFrecuencia.Visible  = true;
            lsbMedicamentos.Visible  = true;
            txtDuracion.Visible = true;
            txtFrecuencia.Visible = true;
            dgvMedicamentos.Visible = true;
            

        }

        private void cmdObservacion_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Observacion";
            lblAnterior.Text = "Observaciones anteriores";
            lblActual.Text = "Observacion actual";
            sinPlan();
            atr = 5;
            
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void vaciar()
            {
                rcbActual.Text = string.Empty;
                rcbAnterior.Text = string.Empty;
            }

        private void cmdBuffer_Click(object sender, EventArgs e)
        {
            if (atr==1)
            {
                ate.Motivo_Consulta = rcbActual.Text ;
            }
            if (atr==2)
            {
                ate.Revision = rcbActual.Text;
            }
            if (atr==3)
            {
                ate.Diagnostico = rcbActual.Text;
            }
            if (atr==4)
            {
                ate.Plan_Terapeutico = rcbActual.Text;
            }
            if(atr==5)
            {
                ate.Revision = rcbActual.Text;
            }
        }
        private void comprobarVacio()
        {
            if(rcbActual.Text==string.Empty )
            {
                cmdBuffer.Enabled=false;
            }
            else{
                cmdBuffer.Enabled=true;
            }
        }
        private void sinPlan()
        {
            lblMedicamentos.Visible = false;
            btnAgregar.Visible = false;
            cboDieta.Visible = false;
            rcbActual.Visible = true;
            rcbAnterior.Visible=true;
            lblActual.Visible = true ;
            lblAnterior.Visible = true ;
            lblDietas.Visible = false;
            lblDuracion.Visible = false;
            lblFrecuencia.Visible = false ;
            lsbMedicamentos.Visible = false;
            txtDuracion.Visible = false;
            txtFrecuencia.Visible = false;
            dgvMedicamentos.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvMedicamentos.Rows.Add(new BDHelper().consultaTabla_parametros("SELECT farmaco FROM Medicamentos WHERE id="+lsbMedicamentos.SelectedValue).Rows[0][0].ToString(), txtDuracion.Text, txtFrecuencia.Text);
        }

    }
}
