using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoPav
{
    public partial class frmGrafiquin : Form
    
    {
        int ANIO;
        BDHelper ayudin = new BDHelper();
        public frmGrafiquin(int anio)
        {
            InitializeComponent();
            ANIO = anio;
        }

        private void frmGrafiquin_Load(object sender, EventArgs e)
        {
            txtanio.Text = ANIO.ToString();
            llenarBarra(txtanio.Text);
            
            
        }
        private void llenarBarra(string anio)
        {
            
            chtAtencionesMes.Titles.Add("Atenciones por mes en un año");
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            int[] atenciones = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            DataTable table = new DataTable();
            table = ayudin.consultaTabla_parametros("SELECT Fecha From Atenciones_Medicas");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DateTime time = Convert.ToDateTime(table.Rows[i][0].ToString());
                int mes = time.Month;
                if (time.Year.ToString()==anio)
                atenciones[mes - 1]++;
            }
            for (int i = 0; i < meses.Length; i++)
            {
                Series serie=chtAtencionesMes.Series.Add(meses[i]);
                serie.Points.Add(atenciones[i]);
            }

        }


    }
}
