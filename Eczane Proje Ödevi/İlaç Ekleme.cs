using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane_Proje_Ödevi
{
    public partial class İlaç_Ekleme : Form
    {
        MedicineProccess MmedicineProccess = new MedicineProccess();
        public İlaç_Ekleme()
        {
            InitializeComponent();
        }

        private void İlcekleBtn_Click(object sender, EventArgs e)
        {
            Medicine medicineS = new Medicine();
            Patient patientS = new Patient();
           
            if (!String.IsNullOrWhiteSpace(ilçNmTXT.Text))
            {
                medicineS.Id = Convert.ToInt32(İlçIdTxt.Text);
                medicineS.Name = ilçNmTXT.Text;
                medicineS.Price = Convert.ToDouble(İlçPrcTxt.Text);
                medicineS.Stock = Convert.ToInt32(İlçstckTxt.Text);



                if (MmedicineProccess.Add(medicineS))
                {
                    MessageBox.Show("Medicine Add Successful");

                }

                else
                {
                    MessageBox.Show("Try Again");
                }
            }
           
        }

        private void İlçBackBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void İlçNmLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
