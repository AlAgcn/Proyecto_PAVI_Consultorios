using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPav
{
    class Paciente
    {
        public int Id_HistorialClinico { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int Id_Dni { set; get; }
        public string Domicilio { set; get; }
        public string Obra_Social { set; get; }
        public int Id_Afiliado { set; get; }
        public int Telefono { set; get; }
        public DateTime Nacimiento { set; get; }
    }
}
