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
        enum TipoConexion
        { comun, transaccion}

        enum EstadoTransaccion
        { exito, fracaso}

        private static BDHelper instance;
        private string cadConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;
        private TipoConexion miTipo = TipoConexion.comun;
        private EstadoTransaccion miEstado = EstadoTransaccion.exito;

        public string CadConexion
        {
            get { return cadConexion; }
            set { cadConexion = value; }
        }
       

        public BDHelper()
        {
            cadConexion = @"Data Source=ALIBOOK\MISERVIDOR;Initial Catalog=Consultorio;Integrated Security=True";
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


        public void desconectar()
        {
            if (miTipo == TipoConexion.transaccion)
                if (miEstado == EstadoTransaccion.exito)
                    transaccion.Commit();
                else
                    transaccion.Rollback();
         conexion.Close();
         miTipo = TipoConexion.comun;
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

        public void ejecutarTransaccion(string sql_command)
        {
            try
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql_command;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                miEstado = EstadoTransaccion.fracaso;
            }
        }

        public void conectarTransaccion()
        {
            conexion.ConnectionString = cadConexion;
            conexion.Open();
            miTipo = TipoConexion.transaccion;
            transaccion = conexion.BeginTransaction();
            comando.Transaction = transaccion;
            miEstado = EstadoTransaccion.exito;
            comando.Connection = conexion;
        }
   }
}