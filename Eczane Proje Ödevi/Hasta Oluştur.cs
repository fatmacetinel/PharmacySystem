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
    public partial class Hasta_Oluştur : Form
    {
        int PatientId = 0;
        PatientProccess patientProccess=new PatientProccess(); 
        public Hasta_Oluştur()
        {
            InitializeComponent();
        }

        private void Hasta_Oluştur_Load(object sender, EventArgs e)
        {

        }
        
        private void patientaddBTN_Click(object sender, EventArgs e)
        {
            Patient ppatient = new Patient();

            if (!String.IsNullOrWhiteSpace(patientnameTXT.Text) && !String.IsNullOrWhiteSpace(patientsrnTXT.Text))
            {
                ppatient.Id = Convert.ToInt32(patientidTXT.Text);
                ppatient.Name = patientnameTXT.Text;
                ppatient.Surname = patientsrnTXT.Text;
                //customer.Balance = Convert.ToDouble(customerBalanceNud.Value);

                if (patientProccess.Add(ppatient))
                {
                    MessageBox.Show("Patient Add Successful");
                    PatientId++;
                    patientidTXT.Text = PatientId.ToString();
                    patientidTXT.Clear();
                    patientnameTXT.Clear();
                    patientsrnTXT.Clear();
                    //customerBalanceNud.Value = 0;
                    patientnameTXT.Focus();
                    PatientList.Items.Add(ppatient.Id+" "+ppatient.Name+" "+ppatient.Surname);
                    //PatientList.Items.Add(ppatient.Name);
                    //PatientList.Items.Add(ppatient.Surname);

                }
                else
                {
                    MessageBox.Show("Patient Add Failed");
                }
            }
           
        }

        private void patientidTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void HstBackBTn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}