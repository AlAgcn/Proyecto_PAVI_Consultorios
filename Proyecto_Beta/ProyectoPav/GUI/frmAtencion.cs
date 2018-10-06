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
        public frmAtencion(string nom,int histo)
        {
            InitializeComponent();
            NOM = nom;
            HISTO = histo;
        }

        private void frmAtencion_Load(object sender, EventArgs e)
        {
            lblPaciente.Text = NOM;
            lblHistorial.Text = HISTO.ToString();
            gpbAtencion.Text = "Motivos";
            lblAnterior.Text = "Motivos anteriores";
            lblActual.Text = "Motivos actuales";
        }

        private void cmdMotivos_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Motivos";
            lblAnterior.Text = "Motivos anteriores";
            lblActual.Text = "Motivos actuales";
        }

        private void cmdRevision_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Revision";
            lblAnterior.Text = "Revision anteriores";
            lblActual.Text = "Revision actual";

        }

        private void cmdDiagnostico_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Diagnostico";
            lblAnterior.Text = "Diagnostico anteriores";
            lblActual.Text = "Diagnostico actual";
        }

        private void cmdPlan_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Plan Terapeutico";
            lblAnterior.Text = "Planes anteriores";
            lblActual.Text = "Plan actual";
        }

        private void cmdObservacion_Click(object sender, EventArgs e)
        {
            gpbAtencion.Text = "Observacion";
            lblAnterior.Text = "Observaciones anteriores";
            lblActual.Text = "Observacion actual";
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
