using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DonsElectricCostCalculator
{
    public partial class formCost : Form
    {
        float varDaily;
        float varMonthly;
        float varYearly;

        float varHoursUsed;
        float varPwrConsumption;
        float varWattCost;
        float varTotalPower;

        public formCost()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            formMain formMain = new formMain();
            formMain.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {



            float.TryParse(txtHoursUsed.Text, out varHoursUsed);
            float.TryParse(txtPwrConsumption.Text, out varPwrConsumption);
            float.TryParse(txtWattCost.Text, out varWattCost);

            varTotalPower = (varPwrConsumption * varHoursUsed) / 1000;
            

            varDaily = (varTotalPower * varWattCost) / 100;
            MessageBox.Show(varDaily.ToString());
            varMonthly = varDaily * 30;
            varYearly = varMonthly * 12;
    



            lblDailyCost.Text = varDaily.ToString() ;
            lblMontlyCost.Text = varMonthly.ToString();
            lblYearlyCost.Text = varYearly.ToString();
        }
    }
}
