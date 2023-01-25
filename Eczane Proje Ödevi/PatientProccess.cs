using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Proje_Ödevi
{
    internal class PatientProccess : PharmacyCrud<Patient>
    {
        public bool Add(Patient obj)
        {
            try
            {
                DbContext.PatientList.Add(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Patient Detail(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> List()
        {
            return DbContext.PatientList.ToList();
        }
    }
}
