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
    public partial class Menü : Form
    {
        Reçete reçete=new Reçete();
        Hasta_Oluştur hstols = new Hasta_Oluştur();
        İlaç_Ekleme ilaç_ekl=new İlaç_Ekleme();


        public Menü()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
           reçete.ShowDialog();
        }

        private void HstolTxt_Click(object sender, EventArgs e)
        {
            hstols.ShowDialog();
        }

        private void İlçeklTxt_Click(object sender, EventArgs e)
        {
            ilaç_ekl.ShowDialog();
        }

        private void Menü_Load(object sender, EventArgs e)
        {

        }
    }
}
