using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProyectoPav
{
    class HistorialClinicoHelper
    {
        BDHelper helper = new BDHelper();
        private clsHistorialClinico map_HistorialClinico(DataRow row)
        {
            clsHistorialClinico histo = new clsHistorialClinico();
            histo.cod = int.Parse(row["cod"].ToString());
            histo.nombre = row["Nombre"].ToString();
            histo.apellido = row["Apellido"].ToString();
            histo.dni = int.Parse(row["dni"].ToString());

            return histo;
        }
        public clsHistorialClinico getByDni (int dni)
        {
            string str_sql = "SELECT * FROM Historias_Clinicas WHERE dni=" + dni.ToString();
            DataTable tabla = new DataTable();
            tabla = helper.consultaTabla_parametros(str_sql);
            if (tabla.Rows.Count > 0)
            {
                clsHistorialClinico histo = new clsHistorialClinico();
                histo = map_HistorialClinico(tabla.Rows[0]);
                return histo;
            }
            else
            {
                return null;
            }
        }
        public bool agregarHistorial(clsHistorialClinico histo)
        {
            string str_sql="INSERT INTO Historias_Clinicas (Nombre,Apellido,dni) VALUES ('"+histo.nombre+"','"+histo.apellido+"',"+histo.dni.ToString()+")";
            return (helper.consultaSQL(str_sql) == 1);
        }
        public bool actualizarHistorial(clsHistorialClinico histo)
        {
            string str_sql = "UPDATE Historias_Clinicas SET ";
            str_sql += "Nombre='" + histo.nombre + "', Apellido='" + histo.apellido + "',dni=" + histo.dni.ToString()+"WHERE cod="+histo.cod.ToString();
            return (helper.consultaSQL(str_sql) == 1);
        }
    }
}
