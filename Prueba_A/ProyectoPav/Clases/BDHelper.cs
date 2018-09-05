using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace ProyectoPav
{
    class BDHelper
    {
        private string cadConexion;
        private OleDbConnection conexion;
        private OleDbCommand comando;
        public string CadConexion
        {
            get { return cadConexion; }
            set { cadConexion = value; }
        }
        public OleDbConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        public OleDbCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }

        public BDHelper()
        {
            cadConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Mis Documentos\Consultorios.mdb";
            conexion = new OleDbConnection();
            comando = new OleDbCommand();

        }
        private void conectar()
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            conexion.ConnectionString = cadConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
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
        public DataTable consultaTabla (String buscar)
        {
            DataTable tablar = new DataTable();
            conectar();
            comando.CommandText = buscar;
            tablar.Load(comando.ExecuteReader());
            desconectar();

            return tablar;
        }
    }
}
