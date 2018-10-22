using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoPav
{
    class MedicamentoHelper
    {
        BDHelper helper = new BDHelper();
        private clsMedicamento map_Medicamento(DataRow row)
        {
            clsMedicamento med = new clsMedicamento();
            med.Monodroga = row["monodroga"].ToString();
            med.Farmaco = row["farmaco"].ToString();
            med.Laboratorio = row["laboratorio"].ToString();
            return med;
        }

        public bool agregarMedicamento(clsMedicamento medicine)
        {
            string sql = "Insert into Medicamentos (monodroga, farmaco, laboratorio) "
                        + "values ('" + medicine.Monodroga + "', '" + medicine.Farmaco + "', '" + medicine.Laboratorio + "')";
            return (helper.consultaSQL(sql) == 1);
        }

        public clsMedicamento getByID(int id_med)
        {
            string sql = "Select * from Medicamentos where id=" + id_med.ToString();
            DataTable medicine = new DataTable();
            medicine = helper.consultaTabla_parametros(sql);
            if (medicine.Rows.Count > 0)
            {
                clsMedicamento medic = new clsMedicamento();
                medic = map_Medicamento(medicine.Rows[0]);
                return medic;
            }
            else
                return null;
        }
    }
}
