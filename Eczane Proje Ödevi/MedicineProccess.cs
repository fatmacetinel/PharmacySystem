using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Proje_Ödevi
{
    internal class MedicineProccess
    {
        private object medicine1;

        public bool Add(Medicine entity)
        {
            try
            {
                DbContext.MedicineList.Add(entity);
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
            foreach (var medicine in DbContext.MedicineList.ToList())
            {
                if (medicine.Id == id)
                {
                    DbContext.MedicineList.Remove(medicine);
                    result = true;
                    break;
                }
            }
            return result;
        }

        public Medicine Detail(int id)
        {
            Medicine newmedicine = new Medicine();
            foreach (var Medicine in DbContext.MedicineList.ToList())
            {
                if (newmedicine.Id == id)
                {
                    Medicine medicine1 = newmedicine;
                    break;
                }
            }
            return newmedicine;
        }

        public List<Medicine> List()
        {

            return DbContext.MedicineList.ToList();
        }
    }
}
