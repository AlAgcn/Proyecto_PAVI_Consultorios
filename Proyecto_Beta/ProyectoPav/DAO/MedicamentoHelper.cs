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
    }
}
