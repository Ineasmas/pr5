namespace pr25_26
{
    public partial class frmain : Form
    {
        public frmain()
        {
            InitializeComponent();
        }

        private void btBMI_Click(object sender, EventArgs e)
        {
            frbmi bmi = new frbmi();
            bmi.Show();
           

        }

        private void btBMR_Click(object sender, EventArgs e)
        {
            frbmr bmr = new frbmr();
            bmr.Show();
        }

        private void btMS2016_Click(object sender, EventArgs e)
        {
           frinfo info =new frinfo();
            info.Show();
        }
    }
}