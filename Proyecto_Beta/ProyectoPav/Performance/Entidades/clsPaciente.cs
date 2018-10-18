using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPav
{
    class clsPaciente
    {
        public int historiaClinica { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public int dni { set; get; }
        public string domicilio { set; get; }
        public int obra_Social { set; get; }
        public int nro_Afiliado { set; get; }
        public int telefono { set; get; }
        public String nacimiento { set; get; }

        public clsPaciente(int hclinica, string nom, string apell, int DNI, string dom, int osocial, int nroafiliado, int tel, string nac)
        {
            historiaClinica = hclinica;
            nombre = nom;
            apellido = apell;
            dni = DNI;
            domicilio = dom;
            obra_Social = osocial;
            nro_Afiliado = nroafiliado;
            telefono = tel;
            nacimiento = nac;
        }

        public clsPaciente(int hclinica, string nom, string apell, int DNI, string dom, int tel, string nac)
        {
            historiaClinica = hclinica;
            nombre = nom;
            apellido = apell;
            dni = DNI;
            domicilio = dom;
            obra_Social = 0;
            nro_Afiliado = 0;
            telefono = tel;
            nacimiento = nac;
        }

        public clsPaciente()
        {
            // TODO: Complete member initialization
        }
    }
}