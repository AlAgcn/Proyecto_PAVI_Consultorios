using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPav
{
    class clsAtencionMedica
    {
        public int Id { set;  get; }
        public int id_HistorialClinico { set; get; }
        public string Motivo_Consulta { set; get; }
        public string Revision { set; get; }
        public string Diagnostico { set; get; }
        public string Plan_Terapeutico { set; get; }
        public string Observaciones { set; get; }
        public string Fecha { set; get; }
    }

}
