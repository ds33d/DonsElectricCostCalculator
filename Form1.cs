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
        }

        private void radWatts_CheckedChanged(object sender, EventArgs e)
        {
            radAmps.Enabled = false;
            radVolts.Enabled = false;
            txtWatts.Enabled = false;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            varAmps = Convert.ToInt32(txtAmps.ToString());
            varVolts = Convert.ToInt32(txtVolts.ToString());
            varWatts = varAmps * varVolts;
            txtWatts.Text = varWatts.ToString();
        }
    }
}
