using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProyectoPav
{
    class DaoHistorialClinico
    {
        BDHelper ayudin = new BDHelper();
        private HistorialClinico map_HistorialClinico(DataRow row)
        {
            HistorialClinico histo = new HistorialClinico();
            histo.cod = int.Parse(row["cod"].ToString());
            histo.nombre = row["Nombre"].ToString();
            histo.apellido = row["Apellido"].ToString();
            histo.dni = int.Parse(row["dni"].ToString());

            return histo;
        }
        public HistorialClinico getByDni (int dni)
        {
            string str_sql = "SELECT * FROM Historias_Clinicas WHERE dni=" + dni.ToString();
            DataTable tablin = new DataTable();
            tablin = ayudin.consulta_oldb(str_sql);
            if (tablin.Rows.Count > 0)
            {
                HistorialClinico histo = new HistorialClinico();
                histo = map_HistorialClinico(tablin.Rows[0]);
                return histo;
            }
            else
            {
                return null;
            }
        }
        public bool agregarHistorial(HistorialClinico histo)
        {
            string str_sql="INSERT INTO Historias_Clinicas (Nombre,Apellido,dni) VALUES ('"+histo.nombre+"','"+histo.apellido+"',"+histo.dni.ToString()+")";
            return (ayudin.consultaSQL(str_sql) == 1);
        }
        public bool actualizarHistorial(HistorialClinico histo)
        {
            string str_sql = "UPDATE Historias_Clinicas SET ";
            str_sql += "Nombre='" + histo.nombre + "', Apellido='" + histo.apellido + "',dni=" + histo.dni.ToString()+"WHERE cod="+histo.cod.ToString();
            return (ayudin.consultaSQL(str_sql) == 1);
        }
    }
}
