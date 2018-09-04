using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Trabajo_Practico_Consultorio
{
    class BDHelper_Access
    {
        string strConection=@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\Usuario\Escritorio\Cosas Raras\Progrmacionn\Base de Datosssss\Base de Datos access_TP_PAV\TablasConsultorio_TP_Integrador.mdb";
        OleDbCommand cmd;
        OleDbConnection connection;

        public string StrConection { get => StrConection1;}
        public OleDbCommand Cmd { get => cmd; set => cmd = value; }
        public OleDbConnection Connection { get => connection; set => connection = value; }
        public string StrConection1 { get => strConection; set => strConection = value; }

        public DataTable consultaOLDB(string strCmdOldb)
        {
            DataTable tablon = new DataTable();
            connection = new OleDbConnection();
            cmd = new OleDbCommand();
            connection.ConnectionString = StrConection;
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strCmdOldb;
            tablon.Load(cmd.ExecuteReader());
            connection.Close();
            return tablon;
        }







        
    }
}
