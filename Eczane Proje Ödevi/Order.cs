using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Proje_Ödevi
{
    internal class Order
    {
        public int Id { get; set; }
        public int MedicineId { get; set; }
        public int MedicineId2 { get; set; }
        public int MedicineId3 { get; set; }
        public int MedicineId4 { get; set; }
        public int PatinetId { get; set; }
        public int PrescriptionsId { get; set; }
        public int Quantity { get; set; }
        public int Quantity2 { get; set; }
        public int Quantity3 { get; set; }
        public int Quantity4 { get; set; }
        public double TotalPirce { get; set; }
    }
}
