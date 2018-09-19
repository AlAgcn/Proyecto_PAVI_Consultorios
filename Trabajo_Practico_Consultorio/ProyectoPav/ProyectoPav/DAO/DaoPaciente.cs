using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ProyectoPav
{
    class DaoPaciente
    {
        BDHelper ayudin = new BDHelper();
        private Paciente map_Pacient(DataRow row)
        {
            Paciente paci = new Paciente();
            paci.Id_HistorialClinico = int.Parse(row["n_HistoriaClinica"].ToString());
            paci.Id_Afiliado = int.Parse(row["n_Afiliado"].ToString());
            paci.Id_Dni = int.Parse(row["dni"].ToString());
            paci.Nacimiento = DateTime.Parse(row["Fecha_Nacimiento"].ToString());
            paci.Nombre = row["Nombre"].ToString();
            paci.Apellido = row["Apellido"].ToString();
            paci.Domicilio = row["Domicilia"].ToString();
            paci.Obra_Social = row["Obra_Social"].ToString();
            paci.Telefono = int.Parse(row["Telefono"].ToString());
            return paci;

        }
        public Paciente getByNameSurname(string nombre,string apellido)
        {
            string str_sql = "select * from Pacientes where Nombre='" + nombre + "', Apellido='" + apellido + "'";
            DataTable tablin = new DataTable();
            tablin = ayudin.consulta_oldb(str_sql);
        
            if (tablin.Rows.Count >0 )
            {
                Paciente paci = new Paciente();
                paci = map_Pacient(tablin.Rows[0]);
                return paci;
            }
            else
            {
                return null; 
            }
         }
        public Paciente getByHistory(int HC)
        {
            string str_sql = "select * from Pacientes where n_HistoriaClinica=" + HC.ToString();
            DataTable tablin = new DataTable();
            tablin = ayudin.consulta_oldb(str_sql);
            if (tablin.Rows.Count >0)
            {
                Paciente paci = new Paciente();
                paci = map_Pacient(tablin.Rows[0]);
                return paci;
            }
            else
            {
                return null;
            }
        }
        public bool agregarPaciente(Paciente paci)
        {
            string str_sql = "INSERT INTO Pacientes (n_HistoriaClinica,Nombre,Apellido,dni,Fecha_Nacimiento,Obra_Social,n_Afiliado,Domicilio,Telefono) values";
            str_sql+="("+paci.Id_HistorialClinico.ToString()+",'"+paci.Nombre+"','"+paci.Apellido+"',"+paci.Id_Dni.ToString()+","+paci.Nacimiento.ToString()+","+paci.Obra_Social;
            str_sql += "," + paci.Id_Afiliado.ToString() + ",'" + paci.Domicilio + "'," + paci.Telefono.ToString()+")";
            return (ayudin.consultaSQL(str_sql)==1);

        }
        public bool actualizarPaciente(Paciente paci)
        {
            string str_sql = "UPDATE Pacientes SET";
            str_sql += "n_HistorialClinico=" + paci.Id_HistorialClinico.ToString();
            str_sql += ", Nombre='" + paci.Nombre+"'";
            str_sql += ", Apellido='" + paci.Apellido+"'";
            str_sql += ", Fecha_Nacimiento =" + paci.Nacimiento.ToString();
            str_sql += ", Obra_Social='" + paci.Obra_Social+"'";
            str_sql += ", n_Afiliado="+ paci.Id_Afiliado;
            str_sql += ", Domicilio='" + paci.Domicilio+"'";
            str_sql += ", Telefono=" + paci.Telefono.ToString();
            str_sql += "WHERE dni=" + paci.Id_Dni.ToString();
            return (ayudin.consultaSQL(str_sql)==1);
            
        }
    }
}
