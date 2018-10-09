using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPav
{
    class clsMedicamento
    {
        string monodroga;
        string farmaco;
        string laboratorio;

        public string Monodroga
        {
            get { return monodroga; }
            set { monodroga = value; }
        }
        public string Farmaco
        {
            get { return farmaco; }
            set { farmaco = value; }
        }
        public string Laboratorio
        {
            get { return laboratorio; }
            set { laboratorio = value; }
        }

        public clsMedicamento(string droga, string far, string lab)
        {
            Monodroga = droga;
            Farmaco = far;
            Laboratorio = lab;
        }

        public clsMedicamento()
        {
            // TODO: Complete member initialization
        }
    }
}
