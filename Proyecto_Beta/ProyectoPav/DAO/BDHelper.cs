using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ProyectoPav
{
    class BDHelper
    {
        private string cadConexion;
        private OleDbConnection  conexion;
        private OleDbCommand  comando;
        public string CadConexion
        {
            get { return cadConexion; }
            set { cadConexion = value; }
        }
        public OleDbConnection  Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        public OleDbCommand  Comando
        {
            get { return comando; }
            set { comando = value; }
        }

        public BDHelper()
        {
            cadConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\Usuario\Escritorio\Cosas Raras\Progrmacionn\Base de Datosssss\Base de Datos access_TP_PAV\TablasConsultorio_TP_Integrador.mdb'";
            conexion = new OleDbConnection() ;
            comando = new OleDbCommand();

        }
        private void conectar()
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            conexion.ConnectionString = cadConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable llenar_Tabla(String nombreTabla)
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

        public bool siExiste(string nombreTabla, string columna, string nuevo)
        {
            DataTable existe = new DataTable();
            conectar();
            comando.CommandText = "SELECT " + columna + " FROM " + nombreTabla + " WHERE " + columna + "='" + nuevo + "'";
            existe.Load(comando.ExecuteReader());
            if (existe.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}