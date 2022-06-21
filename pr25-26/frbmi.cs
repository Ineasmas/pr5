using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr25_26
{
    public partial class frbmi : Form
    {
        bool gender = true;
        public frbmi()
        {
            InitializeComponent();
        }
        double bmivolume = 0;
        double xPoint;
        private void frbmi_Load(object sender, EventArgs e)
        {

        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btcalc_Click(object sender, EventArgs e)
        {

            bmivolume = Math.Round(Convert.ToDouble(tbves.Text) / Math.Pow(Convert.ToDouble(tbrost.Text) / 100, 2), 2);
            double x1 = (120 / 18.5 * bmivolume) - 25;
            double x2 = (120 / 6.5 * (bmivolume - 18.5)) - 25;
            double x3 = (120 / 5 * (bmivolume - 25)) - 25;
            double x4 = (120 / 15 * (bmivolume - 30)) - 25;
            
            if (bmivolume < 18.5)
            {
                lbhealth.Text = "Недостаточный";
                pbarrow.Location = new Point(490 + (int)x1, 475);
                lbhealth.Location = new Point(490 + (int)x1, 435);
                pbhealthstatus.BackgroundImage = Properties.Resources.underweigt;
            }
            if (bmivolume >= 18.5 && bmivolume < 25)
            {
                lbhealth.Text = "Норма";
                pbarrow.Location = new Point(610 + (int)x2, 475);
                lbhealth.Location = new Point(610 + (int)x2, 435);
                pbhealthstatus.BackgroundImage = Properties.Resources.healthy;
            }
            if (bmivolume >= 25 && bmivolume < 30)
            {
                lbhealth.Text = "Избыточный";
                pbarrow.Location = new Point(730 + (int)x3, 475);
                lbhealth.Location = new Point(730 + (int)x3, 435);
                pbhealthstatus.BackgroundImage = Properties.Resources.over;
            }
            if (bmivolume >= 30 && bmivolume < 45)
            {
                lbhealth.Text = "Ожирение";
                pbarrow.Location = new Point(850 + (int)x4, 475);
                lbhealth.Location = new Point(850 + (int)x4, 435);
                pbhealthstatus.BackgroundImage = Properties.Resources.obese;
            }
            if (bmivolume > 45)
                MessageBox.Show("вы слишком жирный");
            lbhealth.Text=bmivolume.ToString();
        }

        private void btmg_Click(object sender, EventArgs e)
        {
            gender = true;
            btmg.FlatAppearance.BorderSize = 3;
            btfg.FlatAppearance.BorderSize = 0;
        }

        private void btfg_Click(object sender, EventArgs e)
        {
            gender = false;
            btmg.FlatAppearance.BorderSize = 0;
            btfg.FlatAppearance.BorderSize = 3;
        }
    }
}

