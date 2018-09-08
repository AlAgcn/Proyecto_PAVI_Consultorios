using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoPav
{
    class BDHelper
    {
        private string cadConexion;
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

        public void consultaSQL(string sqlComand)
        {
            try
            {
                conectar();
                comando.CommandText = sqlComand;
                comando.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                
                throw;
            }
            finally
            {
                desconectar();
            }
        }
    }
}