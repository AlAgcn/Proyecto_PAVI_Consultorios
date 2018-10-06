using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPav
{
    class clsUsuario
    {
        private int id;
        private String n_usuario;
        private String n_password;

        private int n_perfil;

        public String N_usuario
        {
            get { return n_usuario; }
            set { n_usuario = value; }
        }

        public String N_password
        {
            get { return n_password; }
            set { n_password = value; }
        }
        

        public int N_perfil
        {
            get { return n_perfil; }
            set { n_perfil = value; }
        }

        public clsUsuario(String nombre, String password, int perfil)
        {
            n_usuario = nombre;
            n_password = password;
            n_perfil = perfil;
        }

        public clsUsuario()
        {
            // TODO: Complete member initialization
        }
        public void mostrarDatos()
        {

        }
    }
}
