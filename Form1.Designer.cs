
namespace DonsElectricCostCalculator
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.radWatts = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radVolts = new System.Windows.Forms.RadioButton();
            this.radAmps = new System.Windows.Forms.RadioButton();
            this.txtWatts = new System.Windows.Forms.TextBox();
            this.txtAmps = new System.Windows.Forms.TextBox();
            this.txtVolts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radWatts
            // 
            this.radWatts.AutoSize = true;
            this.radWatts.Location = new System.Drawing.Point(7, 22);
            this.radWatts.Name = "radWatts";
            this.radWatts.Size = new System.Drawing.Size(55, 19);
            this.radWatts.TabIndex = 0;
            this.radWatts.TabStop = true;
            this.radWatts.Text = "Watts";
            this.radWatts.UseVisualStyleBackColor = true;
            this.radWatts.CheckedChanged += new System.EventHandler(this.radWatts_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radVolts);
            this.groupBox1.Controls.Add(this.radAmps);
            this.groupBox1.Controls.Add(this.radWatts);
            this.groupBox1.Location = new System.Drawing.Point(158, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options:";
            // 
            // radVolts
            // 
            this.radVolts.AutoSize = true;
            this.radVolts.Location = new System.Drawing.Point(7, 73);
            this.radVolts.Name = "radVolts";
            this.radVolts.Size = new System.Drawing.Size(50, 19);
            this.radVolts.TabIndex = 2;
            this.radVolts.TabStop = true;
            this.radVolts.Text = "Volts";
            this.radVolts.UseVisualStyleBackColor = true;
            this.radVolts.CheckedChanged += new System.EventHandler(this.radVolts_CheckedChanged);
            // 
            // radAmps
            // 
            this.radAmps.AutoSize = true;
            this.radAmps.Location = new System.Drawing.Point(7, 48);
            this.radAmps.Name = "radAmps";
            this.radAmps.Size = new System.Drawing.Size(56, 19);
            this.radAmps.TabIndex = 1;
            this.radAmps.TabStop = true;
            this.radAmps.Text = "Amps";
            this.radAmps.UseVisualStyleBackColor = true;
            this.radAmps.CheckedChanged += new System.EventHandler(this.radAmps_CheckedChanged);
            // 
            // txtWatts
            // 
            this.txtWatts.Location = new System.Drawing.Point(52, 48);
            this.txtWatts.Name = "txtWatts";
            this.txtWatts.Size = new System.Drawing.Size(100, 23);
            this.txtWatts.TabIndex = 2;
            // 
            // txtAmps
            // 
            this.txtAmps.Location = new System.Drawing.Point(52, 77);
            this.txtAmps.Name = "txtAmps";
            this.txtAmps.Size = new System.Drawing.Size(100, 23);
            this.txtAmps.TabIndex = 3;
            // 
            // txtVolts
            // 
            this.txtVolts.Location = new System.Drawing.Point(52, 106);
            this.txtVolts.Name = "txtVolts";
            this.txtVolts.Size = new System.Drawing.Size(100, 23);
            this.txtVolts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Watts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amps:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Volts:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(127, 135);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(115, 43);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 43);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(253, 24);
            this.menuStrip1.TabIndex = 10;
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
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 188);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVolts);
            this.Controls.Add(this.txtAmps);
            this.Controls.Add(this.txtWatts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radWatts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radVolts;
        private System.Windows.Forms.RadioButton radAmps;
        private System.Windows.Forms.TextBox txtWatts;
        private System.Windows.Forms.TextBox txtAmps;
        private System.Windows.Forms.TextBox txtVolts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costToolStripMenuItem;
    }
}

