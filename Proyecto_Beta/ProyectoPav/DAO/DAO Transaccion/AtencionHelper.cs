using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoPav
{
    class AtencionHelper
    {
        private clsAtencionMedica map_Atencio(DataRow row)
        {
            clsAtencionMedica atencioncin = new clsAtencionMedica();
            atencioncin.id_HistorialClinico = int.Parse(row["Historial_Clinica"].ToString());
            atencioncin.Motivo_Consulta = row["Motivo_Consulta"].ToString();
            atencioncin.Observaciones = row["Observaciones"].ToString();
            atencioncin.Revision = row["Revision"].ToString();
            atencioncin.Plan_Terapeutico = row["Plan_Terapeutico"].ToString();
            atencioncin.Diagnostico = row["Diagnostico"].ToString();
            atencioncin.Fecha = row["Fecha"].ToString();
            return atencioncin;
        }
        public clsAtencionMedica getByHCFecha(int hc,string fecha)
        {
            return map_Atencio(new BDHelper().consultaTabla_parametros("SELECT * FROM Atenciones_Medicas WHERE Historia_Clinica=" + hc.ToString() +"AND Fecha='"+fecha+"'").Rows[0]);
        }
        public bool agregarAtencion(clsAtencionMedica atencioncin)
        {
            return (new BDHelper().consultaSQL("INSERT INTO Atenciones_Medicas (Historia_Clinica,Motivo_Consulta,Revision,Diagnostico,Plan_Terapeutico,Observaciones,fecha) VALUES ("+atencioncin.id_HistorialClinico.ToString()+",'"+atencioncin.Motivo_Consulta+"','"+atencioncin.Revision+"','"+atencioncin.Diagnostico+"','"+atencioncin.Plan_Terapeutico+"','"+atencioncin.Observaciones+"','"+atencioncin.Fecha+"')")==1);
        }

        
    }
}
