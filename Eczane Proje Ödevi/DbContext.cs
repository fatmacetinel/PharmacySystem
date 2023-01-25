using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Proje_Ödevi
{
    internal class DbContext : İnheritance
    {
        public static List<Medicine> MedicineList = new List<Medicine>();
        public static List<Patient> PatientList = new List<Patient>();
        public static List<Prescriptions> Prescription = new List<Prescriptions>();
        public static List<Order> OrderList = new List<Order>();
        public static List<User> UserList = new List<User>();
        public DbContext()
        {

            Medicine medicine1 = new Medicine()
            {
                Id = 1,
                Name = "Reflor",
                Stock = 5,
                Price = 15,

            };
            MedicineList.Add(medicine1);

            Medicine medicine2 = new Medicine()
            {
                Id = 2,
                Name = "Metpamid",
                Stock = 4,
                Price = 20,
            };
            MedicineList.Add(medicine2);

            Medicine medicine3 = new Medicine()
            {
                Id = 3,
                Name = "Cıpro",
                Stock = 10,
                Price = 10,
            };
            MedicineList.Add(medicine3);

            Medicine medicine4 = new Medicine()
            {
                Id = 4,
                Name = "Flagyl",
                Stock = 6,
                Price = 15,
            };
            MedicineList.Add(medicine4);

            Medicine medicine5 = new Medicine()
            {
                Id = 5,
                Name = "Aferin",
                Stock = 9,
                Price = 10,
            };
            MedicineList.Add(medicine5);


            Medicine medicine6 = new Medicine()
            {
                Id = 6,
                Name = "İbucold",
                Stock = 5,
                Price = 20,
            };
            MedicineList.Add(medicine6);

            Medicine medicine7 = new Medicine()
            {
                Id = 7,
                Name = "TylolHot",
                Stock = 25,
                Price = 45,
            };
            MedicineList.Add(medicine7);

            Medicine medicine8 = new Medicine()
            {
                Id = 8,
                Name = "Parol",
                Stock = 30,
                Price = 15,
            };
            MedicineList.Add(medicine8);

            Medicine medicine9 = new Medicine()
            {
                Id = 9,
                Name = "Madecasol",
                Stock = 6,
                Price = 30,
            };
            MedicineList.Add(medicine9);

            Medicine medicine10 = new Medicine()
            {
                Id = 10,
                Name = "Bepanthen Plus",
                Stock = 4,
                Price = 35,
            };


            MedicineList.Add(medicine10);

            Order order = new Order()
            {
                Id = 1,
                MedicineId = 1,
                MedicineId2 = 2,
                MedicineId3 = 3,
                MedicineId4 = 4,
                PatinetId = 1,
            };
            OrderList.Add(order);

        }















    }

}
