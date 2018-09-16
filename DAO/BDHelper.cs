using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace ProyectoPav
{
    class BDHelper
    {
        private string cadConexion;
        private string strConOldb;
        private OleDbCommand cmd;
        private OleDbConnection con;
        private SqlConnection conexion;
        private SqlCommand comando;
        public string CadConexion
        {
            get { return cadConexion; }
            set { cadConexion = value; }
        }
        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }

        public BDHelper()
        {
            cadConexion = @"Data Source=(localdb)\MiBase;Initial Catalog=MyFirst;Integrated Security=True";
            conexion = new SqlConnection();
            comando = new SqlCommand();
            strConOldb = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Usuario\Escritorio\Cosas Raras\Progrmacionn\Base de Datosssss\Base de Datos access_TP_PAV\TablasConsultorio_TP_Integrador.mdb'";
            con = new OleDbConnection();
            cmd = new OleDbCommand();
        }

        
        public DataTable consulta_oldb(string comand)
        {
            con.ConnectionString = strConOldb;
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comand;
            DataTable tablin = new DataTable();
            tablin.Load(cmd.ExecuteReader());
            con.Close();
            return tablin;
        }

        private void conectar()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            conexion.ConnectionString = cadConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable cargarTabla(String nombreTabla)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = "Select * from " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public DataTable consultaTabla_parametros(String filtros)
        {
            DataTable tablar = new DataTable();
            conectar();
            comando.CommandText = filtros;
            tablar.Load(comando.ExecuteReader());
            desconectar();

            return tablar;
        }

        public int consultaSQL(string sqlComand)
        {
            {
                conectar();
                comando.CommandText = sqlComand;
                int filas = comando.ExecuteNonQuery();
                desconectar();
                return filas;

            }
        }
        public int consultaOldb(string oldbCmd)
        {
            con.ConnectionString = strConOldb;
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = oldbCmd;
            int filas=cmd.ExecuteNonQuery();
            con.Close();
            return filas;
            
        }
    }
}