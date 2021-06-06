
namespace DonsElectricCostCalculator
{
    partial class formCost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwrConsumption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoursUsed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWattCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDailyCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMontlyCost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblYearlyCost = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.costToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // costToolStripMenuItem
            // 
            this.costToolStripMenuItem.Name = "costToolStripMenuItem";
            this.costToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.costToolStripMenuItem.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Power Consumption:\r\n";
            // 
            // txtPwrConsumption
            // 
            this.txtPwrConsumption.Location = new System.Drawing.Point(6, 37);
            this.txtPwrConsumption.Name = "txtPwrConsumption";
            this.txtPwrConsumption.Size = new System.Drawing.Size(100, 23);
            this.txtPwrConsumption.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hours used a day:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHoursUsed
            // 
            this.txtHoursUsed.Location = new System.Drawing.Point(6, 81);
            this.txtHoursUsed.Name = "txtHoursUsed";
            this.txtHoursUsed.Size = new System.Drawing.Size(100, 23);
            this.txtHoursUsed.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kilowatt Cost:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtWattCost
            // 
            this.txtWattCost.Location = new System.Drawing.Point(6, 125);
            this.txtWattCost.Name = "txtWattCost";
            this.txtWattCost.Size = new System.Drawing.Size(100, 23);
            this.txtWattCost.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(154, 204);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 36);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 36);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPwrConsumption);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtWattCost);
            this.groupBox1.Controls.Add(this.txtHoursUsed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 171);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblYearlyCost);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblMontlyCost);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDailyCost);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(154, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 171);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Daily Cost:";
            // 
            // lblDailyCost
            // 
            this.lblDailyCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDailyCost.Location = new System.Drawing.Point(7, 37);
            this.lblDailyCost.Name = "lblDailyCost";
            this.lblDailyCost.Size = new System.Drawing.Size(100, 23);
            this.lblDailyCost.TabIndex = 1;
            this.lblDailyCost.Text = "\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monthly Cost:";
            // 
            // lblMontlyCost
            // 
            this.lblMontlyCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontlyCost.Location = new System.Drawing.Point(7, 78);
            this.lblMontlyCost.Name = "lblMontlyCost";
            this.lblMontlyCost.Size = new System.Drawing.Size(100, 23);
            this.lblMontlyCost.TabIndex = 3;
            this.lblMontlyCost.Text = "\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Yearly Cost:";
            // 
            // lblYearlyCost
            // 
            this.lblYearlyCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYearlyCost.Location = new System.Drawing.Point(7, 125);
            this.lblYearlyCost.Name = "lblYearlyCost";
            this.lblYearlyCost.Size = new System.Drawing.Size(100, 23);
            this.lblYearlyCost.TabIndex = 5;
            this.lblYearlyCost.Text = "\r\n";
            // 
            // formCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 257);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.menuStrip1);
            this.Name = "formCost";
            this.Text = "Calculate Cost!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwrConsumption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoursUsed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWattCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblYearlyCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMontlyCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDailyCost;
        private System.Windows.Forms.Label label4;
    }
}