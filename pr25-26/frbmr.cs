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
    public partial class frbmr : Form
    {
        bool gender=true;
        public frbmr()
        {
            InitializeComponent();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btvoff_Click(object sender, EventArgs e)
        {
            pninfo.Visible = false;
        }

        private void btinfo_Click(object sender, EventArgs e)
        {
            pninfo.Visible = true;
        }

        private void btcalc_Click(object sender, EventArgs e)
        { 
            double bmr = 10 * Convert.ToInt32(tbves.Text) + 6.25 * Convert.ToInt32(tbrost.Text) - 5 * Convert.ToInt32(tbage.Text);
            if (gender) bmr += 5;
            else bmr -= 161;
            
            lbbmr.Text ="Ваш BMR: "+ Convert.ToString(Math.Round(bmr));
            lbseat.Text = "Сидячий: " + (Math.Round(bmr * 1.2)).ToString();
            lbsmalla.Text="Маленькая активность: "+ (Math.Round(bmr * 1.4)).ToString();
            lbmida.Text = "Средняя активность: " + (Math.Round(bmr * 1.6)).ToString();
            lbhigha.Text = "Высокая активность: " + (Math.Round(bmr * 1.8)).ToString();
            lbmaxa.Text = "Максимальная активность: " + (Math.Round(bmr * 1.9)).ToString();

        }

        private void btmen_Click(object sender, EventArgs e)
        {
            gender = true;
            btmen.FlatAppearance.BorderSize = 3;
            btwomen.FlatAppearance.BorderSize = 0;
        }

        private void btwomen_Click(object sender, EventArgs e)
        {
            gender = false;
            btmen.FlatAppearance.BorderSize = 0;
            btwomen.FlatAppearance.BorderSize = 3;
        }
    }
}
