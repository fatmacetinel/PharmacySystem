namespace Eczane_Proje_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DbContext dbcontext = new DbContext();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (EmailTxt.Text == "fcetinel")

            {
                Menü menü=new Menü();
                

                if (passwordTxt.Text == "111")

                {
                    menü.ShowDialog();
                
                }

                else

                {
                    status= false;
                    EmailTxt.Clear();
                    passwordTxt.Clear(); 
                }
            }
        }

        private void usernmLBL_Click(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
