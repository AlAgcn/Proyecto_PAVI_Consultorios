﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPav
{
    class UsuarioHelper
    {
        BDHelper helper = new BDHelper();
       private clsUsuario map_Users(DataRow row)
        {
            clsUsuario usu = new clsUsuario();
            usu.Id = int.Parse(row["id"].ToString());
            usu.Usuarios = row["Usuario"].ToString();
            usu.Password = row["Password"].ToString();
            usu.Estado = row["Estado"].ToString();
            usu.id_perfil = int.Parse(row["id_perfil"].ToString());
            return usu;
        }
        public clsUsuario getByNamePass(string name,string password)
        {
            string str_sql= "Select * from Users where Usuario='"+name+"', Password='"+password+"'";
            DataTable tablin = new DataTable();
            tablin = helper.consultaTabla_parametros(str_sql);
            if (tablin.Rows.Count >0)
            {
                clsUsuario usu = new clsUsuario();
                usu = map_Users(tablin.Rows[0]);
                return usu;
            }
            else
            {
                return null;
            }
        }
        public clsUsuario getById(int id)
        {
            string str_sql="Select * from Users where id="+id.ToString();
            DataTable tablin = new DataTable();
            tablin = helper.consultaTabla_parametros(str_sql);
            if (tablin.Rows.Count >0)
            {
                clsUsuario usu = new clsUsuario();
                usu = map_Users(tablin.Rows[0]);
                return usu;
            }
            else
            {
                return null;
            }
        }
        public bool AgregarUsu(clsUsuario usu)
        {
            string str_sql = "INSERT INTO Users (Usuario,Password,id_perfil,Estado) VALUES ('" + usu.Usuarios + "','" + usu.Password + "'," + usu.id_perfil.ToString() + ",'" + usu.Estado + "')";
            return (helper.consultaSQL(str_sql)== 1);
        }
            
    }
}
