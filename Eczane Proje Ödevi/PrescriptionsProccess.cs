using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Proje_Ödevi
{

    internal class PrescriptionsProccess : PharmacyCrud<Prescriptions>
    {
        public bool Add(Prescriptions obj)
        {
            try
            {
                DbContext.Prescription.Add(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            bool result = false;
            foreach (var prescription in DbContext.Prescription.ToList())
            {
                if (prescription.Id == id)
                {
                    DbContext.Prescription.Remove(prescription);
                    result = true;
                }
            }
            return result;
        }

        public Prescriptions Detail(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prescriptions> List()
        {
            return DbContext.Prescription.ToList();
        }
    }
}
