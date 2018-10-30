using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ProyectoPav
{
    class PacienteHelper
    {
        BDHelper helper = new BDHelper();

        private clsPaciente map_Pacient(DataRow row)
        {
            clsPaciente paci = new clsPaciente();
            paci.historiaClinica = int.Parse(row["n_HistoriaClinica"].ToString());
            paci.nombre = row["Nombre"].ToString();
            paci.apellido = row["Apellido"].ToString();
            paci.dni = long.Parse(row["dni"].ToString());
            paci.nacimiento = row["Fecha_Nacimiento"].ToString();
            paci.obra_Social = int.Parse(row["id_obrasocial"].ToString());
            paci.nro_Afiliado = long.Parse(row["n_Afiliado"].ToString());
            paci.domicilio = row["Domicilio"].ToString();
            paci.telefono = long.Parse(row["Telefono"].ToString());
            return paci;

        }
        public clsPaciente getByNameSurname(string nombre,string apellido)
        {
            string str_sql = "select * from Pacientes where Nombre='" + nombre + "', Apellido='" + apellido + "'";
            DataTable tablin = new DataTable();
            tablin = helper.consultaTabla_parametros(str_sql);
        
            if (tablin.Rows.Count >0 )
            {
                clsPaciente paci = new clsPaciente();
                paci = map_Pacient(tablin.Rows[0]);
                return paci;
            }
            else
            {
                return null; 
            }
         }
        public clsPaciente getByHistory(int HC)
        {
            string str_sql = "SELECT * from Pacientes where n_HistoriaClinica=" + HC.ToString();
            DataTable tablin = new DataTable();
            tablin = helper.consultaTabla_parametros(str_sql);
            if (tablin.Rows.Count >0)
            {
                clsPaciente paci = new clsPaciente();
                paci = map_Pacient(tablin.Rows[0]);
                return paci;
            }
            else
            {
                return null;
            }
        }
        public void agregarPaciente(clsPaciente paci, BDHelper conexionAbierta)
        {
            string str_sql = "INSERT INTO Pacientes (Nombre,Apellido,dni,Fecha_Nacimiento,id_obrasocial,n_Afiliado,Domicilio,Telefono,Estado) values ";
            str_sql+="('"+paci.nombre+"','"+paci.apellido+"',"+paci.dni.ToString()+",'"+paci.nacimiento.ToString()+"','"+paci.obra_Social;
            str_sql += "'," + paci.nro_Afiliado.ToString() + ",'" + paci.domicilio + "'," + paci.telefono.ToString()+",'S')";
            conexionAbierta.ejecutarTransaccion(str_sql);

        }
        public bool actualizarPaciente(clsPaciente paci)
        {
            string str_sql = "UPDATE Pacientes SET";
            str_sql += "n_HistorialClinico=" + paci.historiaClinica.ToString();
            str_sql += ", Nombre='" + paci.nombre+"'";
            str_sql += ", Apellido='" + paci.apellido+"'";
            str_sql += ", Fecha_Nacimiento =" + paci.nacimiento.ToString();
            str_sql += ", id_obrasocial='" + paci.obra_Social+"'";
            str_sql += ", n_Afiliado="+ paci.nro_Afiliado;
            str_sql += ", Domicilio='" + paci.domicilio+"'";
            str_sql += ", Telefono=" + paci.telefono.ToString();
            str_sql += " WHERE dni=" + paci.dni.ToString();
            return (helper.consultaSQL(str_sql)==1);
            
        }
        public bool eliminarPaciente(string nombre, string apellido)
        {
            string str_sql = "UPDATE Pacientes SET Estado='N' WHERE Nombre='" + nombre + "' AND Apellido='" + apellido + "'";
            return (helper.consultaSQL(str_sql) == 1);
        }
    }
}
