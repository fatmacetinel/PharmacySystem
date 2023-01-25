using Eczane_Proje_Ödevi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Proje_Ödevi
{
    public partial class Reçete : Form
    {
        int Quantıty = 0;
        int Quantıty2 = 0;
        int Quantıty3 = 0;
        int Quantıty4 = 0;


        int PatientId = 0;
        int Medicine1 = 0;
        int Medicine2 = 0;
        int Medicine3 = 0;
        int Medicine4 = 0;
        MedicineProccess medicineProccess = new MedicineProccess();
        PatientProccess patientProccess = new PatientProccess();
        OrderProccess OrderProccess = new OrderProccess();
        public Reçete()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rçtOluştBtn_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();

            Prescriptions prescriptions = new Prescriptions()
            {
                Id = DbContext.Prescription.Count(),
                PatientId = Convert.ToInt32(PtntidTxt.Text),
                Medicine1 = Convert.ToInt32(mdc1Txt.Text),
                Medicine2 = Convert.ToInt32(mdc2Txt.Text),
                Medicine3 = Convert.ToInt32(mdc3Txt.Text),
                Medicine4 = Convert.ToInt32(mdc4Txt.Text)

            };
            DbContext.Prescription.Add(prescriptions);

            Patient PPatients = new Patient();
            bool statusC = false;
            foreach (var Patients in DbContext.PatientList)
            {
                if (Convert.ToInt32(PtntidTxt.Text) == Patients.Id)
                {
                    PPatients = Patients;
                    statusC = true;
                    break;
                }
            }
            if (statusC)
            {
                PrecriptionList.Items.Add(PPatients.Id);
            }



            Medicine medicines = new Medicine();
            bool IsMdcn = false;
            foreach (var Mmedicine in DbContext.MedicineList)
            {
                if (Convert.ToInt32(mdc1Txt.Text) == Mmedicine.Id)
                {
                    medicines = Mmedicine;
                    IsMdcn = true;
                    break;
                }
            }


            if (IsMdcn)
            {
                PrecriptionList.Items.Add(medicines.Name);
            }

            foreach (var Mmedicine in DbContext.MedicineList)
            {
                if (Convert.ToInt32(mdc2Txt.Text) == Mmedicine.Id)
                {
                    medicines = Mmedicine;
                    IsMdcn = true;
                    break;
                }
            }


            if (IsMdcn)

            {
                PrecriptionList.Items.Add(medicines.Name);
            }
            foreach (var Mmedicine in DbContext.MedicineList)
            {
                if (Convert.ToInt32(mdc3Txt.Text) == Mmedicine.Id)
                {
                    medicines = Mmedicine;
                    IsMdcn = true;
                    break;
                }
            }
            if (IsMdcn)

            {
                PrecriptionList.Items.Add(medicines.Name);
            }
            foreach (var Mmedicine in DbContext.MedicineList)
            {
                if (Convert.ToInt32(mdc4Txt.Text) == Mmedicine.Id)
                {
                    medicines = Mmedicine;
                    IsMdcn = true;
                    break;
                }
            }
            if (IsMdcn)
            {
                PrecriptionList.Items.Add(medicines.Name);
            }
            
        }

        private void mdc4Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void mdc3Txt_TextChanged(object sender, EventArgs e)
        {

        }
        public void searchList()
        {
            SearchList.Items.Clear();
           foreach (var search in medicineProccess.List().ToList())
          {
              SearchList.Items.Add(search.Id + "  Total Price: " + search.Price + " TL");
           }
          
        }

        public void rçtİsleBTn_Click(object sender, EventArgs e)
        {
            
            foreach (var order1 in DbContext.OrderList.ToList())
            {
                if (order1.MedicineId==Convert.ToInt32(mdc1Txt.Text) &&  order1.MedicineId2== Convert.ToInt32(mdc2Txt.Text)
                    && order1.MedicineId3 == Convert.ToInt32(mdc3Txt.Text) && order1.MedicineId4 == Convert.ToInt32(mdc4Txt.Text))
                {
                    foreach (var patient in DbContext.PatientList.ToList())
                    {
                        if (patient.Id == Convert.ToInt32(PtntidTxt.Text))
                        {
                           
                                MessageBox.Show("Satış başarılı");
                            searchList();
                            
                            
                        }
                    }
                    break;
                  
                }
            }

        }

        private void Reçete_Load(object sender, EventArgs e)
        {
            DbContext dbContext = new DbContext();
        }
    }
}












