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
        private void frmAtencion_Load(object sender, EventArgs e)
        {
            lblPaciente.Text = NOM;
            lblHistorial.Text = HISTO.ToString();
            gbxAtencion.Text = "Motivos";
            lblAnterior.Text = "Motivos anteriores";
            lblActual.Text = "Motivos actuales";
            atr = 1;
            cmdBuffer.Enabled=false;
        }

        private void cmdMotivos_Click(object sender, EventArgs e)
        {
            gbxAtencion.Text = "Motivos";
            lblAnterior.Text = "Motivos anteriores";
            lblActual.Text = "Motivos actuales";
            atr = 1;
        }

        private void cmdRevision_Click(object sender, EventArgs e)
        {
            gbxAtencion.Text = "Revision";
            lblAnterior.Text = "Revision anteriores";
            lblActual.Text = "Revision actual";
            atr = 2;

        }

        private void cmdDiagnostico_Click(object sender, EventArgs e)
        {
            gbxAtencion.Text = "Diagnostico";
            lblAnterior.Text = "Diagnostico anteriores";
            lblActual.Text = "Diagnostico actual";
            atr = 3;
        }

        private void cmdPlan_Click(object sender, EventArgs e)
        {
            gbxAtencion.Text = "Plan Terapeutico";
            lblAnterior.Text = "Planes anteriores";
            lblActual.Text = "Plan actual";
            atr = 4;
        }

        private void cmdObservacion_Click(object sender, EventArgs e)
        {
            gbxAtencion.Text = "Observacion";
            lblAnterior.Text = "Observaciones anteriores";
            lblActual.Text = "Observacion actual";
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

    }
}
