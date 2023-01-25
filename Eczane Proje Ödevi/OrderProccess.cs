using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Proje_Ödevi
{
    internal class OrderProccess
    {
        public bool Add(Order entity)
        {
            bool result = false;
            foreach (var medicine in DbContext.MedicineList.ToList())
            {
                if (medicine.Id== entity.MedicineId)
                {
                    foreach (var patient in DbContext.PatientList.ToList())
                    {
                        if (patient.Id == entity.PatinetId) 
                        {
                            if (patient.Balance >=(medicine.Price*entity.Quantity) && medicine.Stock >= entity.Quantity)
                            {
                                
                                Order order = new Order()
                                {
                                    Id = entity.Id,
                                    MedicineId = entity.MedicineId,
                                   PatinetId = entity.PatinetId,
                                    Quantity = entity.Quantity,
                                    TotalPirce = (entity.Quantity * medicine.Price)
                                };
                                DbContext.OrderList.Add(order);
                                result = true;
                                break;
                            }
                        }
                    }

                    break;
                }
            }
            return result;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Order Detail(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> List()
        {
            return DbContext.OrderList.ToList();
        }
    }
}
