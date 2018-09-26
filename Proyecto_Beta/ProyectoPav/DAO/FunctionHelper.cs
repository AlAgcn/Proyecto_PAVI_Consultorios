using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ProyectoPav
{
    class FunctionHelper
    {
        DataTable mitabla;
        BDHelper oDatos;
        public FunctionHelper()
        {
            mitabla = new DataTable();
            oDatos = new BDHelper();
        }


        public void llenarCombo(ComboBox cmbo, string Nombre_Tabla, string display, string value)
        {
            string cmd_sql = "Select * FROM " + Nombre_Tabla;
            cmbo.DataSource = oDatos.llenar_Tabla(Nombre_Tabla);
            cmbo.ValueMember = value;
            cmbo.DisplayMember = display;
        }

        public void cargarLista(ListBox lista, string tabla, string value, string display)
        {
            string sql_cmd = "SELECT * FROM " + tabla + " WHERE Estado='S'";
            lista.DataSource = oDatos.consultaTabla_parametros(sql_cmd);
            lista.ValueMember = value;
            lista.DisplayMember = display;
        }
    }
}
