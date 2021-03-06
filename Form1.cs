using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonsElectricCostCalculator
{
    public partial class formMain : Form
    {

        int varAmps = 0;
        int varWatts = 0;
        int varVolts = 0;

 
           
        public formMain()
        {
            
            InitializeComponent();

            this.CenterToScreen();

            radAmps.Checked = false;
            radVolts.Checked = false;
            radWatts.Checked = false;
        }

        private void radWatts_CheckedChanged(object sender, EventArgs e)
        {
            txtWatts.Enabled = false;
            txtAmps.Enabled = true;
            txtVolts.Enabled = true;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (radWatts.Checked)
            {
                //calculate watts. Amps x Watts
                int.TryParse(txtAmps.Text, out varAmps);
                int.TryParse(txtVolts.Text, out varVolts);
                varWatts = varAmps * varVolts;
                txtWatts.Text = varWatts.ToString();
            }
            else if(radVolts.Checked) {
                //calculate volts. watts/amps
                int.TryParse(txtWatts.Text, out varWatts);
                int.TryParse(txtAmps.Text, out varAmps);
                varVolts = varWatts/varAmps;
                txtVolts.Text = varVolts.ToString();

            }
            else if (radAmps.Checked)
            {
                //calculate amps. Watts/Volts
                int.TryParse(txtWatts.Text, out varWatts);
                int.TryParse(txtVolts.Text, out varVolts);
                varAmps = varWatts / varVolts;
                txtAmps.Text = varAmps.ToString();

            }
            else
            {
                MessageBox.Show("ERORR!");
            }
        }

        private void radAmps_CheckedChanged(object sender, EventArgs e)
        {
            //uiser selected amps, disable textbox
            txtWatts.Enabled = true;
            txtAmps.Enabled = false;
            txtVolts.Enabled = true;
        }

        private void radVolts_CheckedChanged(object sender, EventArgs e)
        {
            //user selected volts, disable the textbox
            txtWatts.Enabled = true;
            txtAmps.Enabled = true;
            txtVolts.Enabled = false; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all text fields
            txtWatts.Text = "";
            txtAmps.Text = "";
            txtVolts.Text = "";

            //disable all checked buttons
            radAmps.Checked = false;
            radVolts.Checked = false;
            radWatts.Checked = false;

            //enable all text fields
            txtWatts.Enabled = true;
            txtAmps.Enabled = true;
            txtVolts.Enabled = true;
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            formCost formCost = new formCost();
            formCost.Show();
        }
    }
}
