namespace BaudRate_Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonMegaCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMegaAcBaud = new System.Windows.Forms.TextBox();
            this.cbMegaExBaud = new System.Windows.Forms.ComboBox();
            this.cbMegaModuleClk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMegaError = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMegaUbrrVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.tbXmegaBscaleVal = new System.Windows.Forms.TextBox();
            this.buttonXmegaCalc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbXmegaAcBaud = new System.Windows.Forms.TextBox();
            this.cbXmegaExBaud = new System.Windows.Forms.ComboBox();
            this.cbXmegaModuleClk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbXmegaError = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbXmegaBselVal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tbLpcFdrVal = new System.Windows.Forms.TextBox();
            this.buttonLpcCalc = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLpcAcBaud = new System.Windows.Forms.TextBox();
            this.cbLpcExBaud = new System.Windows.Forms.ComboBox();
            this.cbLpcModuleClk = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbLpcError = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbLpcDlmlVal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 271);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonMegaCalc);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbMegaAcBaud);
            this.tabPage1.Controls.Add(this.cbMegaExBaud);
            this.tabPage1.Controls.Add(this.cbMegaModuleClk);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbMegaError);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbMegaUbrrVal);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(286, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MEGA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonMegaCalc
            // 
            this.buttonMegaCalc.Location = new System.Drawing.Point(130, 152);
            this.buttonMegaCalc.Name = "buttonMegaCalc";
            this.buttonMegaCalc.Size = new System.Drawing.Size(105, 48);
            this.buttonMegaCalc.TabIndex = 5;
            this.buttonMegaCalc.Text = "Calculate";
            this.buttonMegaCalc.UseVisualStyleBackColor = true;
            this.buttonMegaCalc.Click += new System.EventHandler(this.ButtonMegaCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Actual BaudRate";
            // 
            // tbMegaAcBaud
            // 
            this.tbMegaAcBaud.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbMegaAcBaud.Location = new System.Drawing.Point(130, 74);
            this.tbMegaAcBaud.Name = "tbMegaAcBaud";
            this.tbMegaAcBaud.ReadOnly = true;
            this.tbMegaAcBaud.Size = new System.Drawing.Size(105, 20);
            this.tbMegaAcBaud.TabIndex = 2;
            // 
            // cbMegaExBaud
            // 
            this.cbMegaExBaud.FormattingEnabled = true;
            this.cbMegaExBaud.Location = new System.Drawing.Point(130, 47);
            this.cbMegaExBaud.Name = "cbMegaExBaud";
            this.cbMegaExBaud.Size = new System.Drawing.Size(105, 21);
            this.cbMegaExBaud.TabIndex = 1;
            // 
            // cbMegaModuleClk
            // 
            this.cbMegaModuleClk.FormattingEnabled = true;
            this.cbMegaModuleClk.Location = new System.Drawing.Point(130, 20);
            this.cbMegaModuleClk.Name = "cbMegaModuleClk";
            this.cbMegaModuleClk.Size = new System.Drawing.Size(105, 21);
            this.cbMegaModuleClk.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ErrorRate (%)";
            // 
            // tbMegaError
            // 
            this.tbMegaError.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbMegaError.Location = new System.Drawing.Point(130, 126);
            this.tbMegaError.Name = "tbMegaError";
            this.tbMegaError.ReadOnly = true;
            this.tbMegaError.Size = new System.Drawing.Size(105, 20);
            this.tbMegaError.TabIndex = 4;
            this.tbMegaError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "UBRR Value";
            // 
            // tbMegaUbrrVal
            // 
            this.tbMegaUbrrVal.Location = new System.Drawing.Point(130, 100);
            this.tbMegaUbrrVal.Name = "tbMegaUbrrVal";
            this.tbMegaUbrrVal.Size = new System.Drawing.Size(105, 20);
            this.tbMegaUbrrVal.TabIndex = 3;
            this.tbMegaUbrrVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMegaUbrrVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbRegValue_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Expected Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "F_CPU (Hz)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbXmegaBscaleVal);
            this.tabPage2.Controls.Add(this.buttonXmegaCalc);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbXmegaAcBaud);
            this.tabPage2.Controls.Add(this.cbXmegaExBaud);
            this.tabPage2.Controls.Add(this.cbXmegaModuleClk);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbXmegaError);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbXmegaBselVal);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(286, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XMEGA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "BSCALE Value";
            // 
            // tbXmegaBscaleVal
            // 
            this.tbXmegaBscaleVal.Location = new System.Drawing.Point(130, 100);
            this.tbXmegaBscaleVal.Name = "tbXmegaBscaleVal";
            this.tbXmegaBscaleVal.Size = new System.Drawing.Size(105, 20);
            this.tbXmegaBscaleVal.TabIndex = 22;
            this.tbXmegaBscaleVal.Text = "0";
            this.tbXmegaBscaleVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonXmegaCalc
            // 
            this.buttonXmegaCalc.Location = new System.Drawing.Point(130, 178);
            this.buttonXmegaCalc.Name = "buttonXmegaCalc";
            this.buttonXmegaCalc.Size = new System.Drawing.Size(105, 48);
            this.buttonXmegaCalc.TabIndex = 16;
            this.buttonXmegaCalc.Text = "Calculate";
            this.buttonXmegaCalc.UseVisualStyleBackColor = true;
            this.buttonXmegaCalc.Click += new System.EventHandler(this.ButtonXmegaCalc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Actual BaudRate";
            // 
            // tbXmegaAcBaud
            // 
            this.tbXmegaAcBaud.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbXmegaAcBaud.Location = new System.Drawing.Point(130, 74);
            this.tbXmegaAcBaud.Name = "tbXmegaAcBaud";
            this.tbXmegaAcBaud.ReadOnly = true;
            this.tbXmegaAcBaud.Size = new System.Drawing.Size(105, 20);
            this.tbXmegaAcBaud.TabIndex = 13;
            // 
            // cbXmegaExBaud
            // 
            this.cbXmegaExBaud.FormattingEnabled = true;
            this.cbXmegaExBaud.Location = new System.Drawing.Point(130, 47);
            this.cbXmegaExBaud.Name = "cbXmegaExBaud";
            this.cbXmegaExBaud.Size = new System.Drawing.Size(105, 21);
            this.cbXmegaExBaud.TabIndex = 12;
            // 
            // cbXmegaModuleClk
            // 
            this.cbXmegaModuleClk.FormattingEnabled = true;
            this.cbXmegaModuleClk.Location = new System.Drawing.Point(130, 20);
            this.cbXmegaModuleClk.Name = "cbXmegaModuleClk";
            this.cbXmegaModuleClk.Size = new System.Drawing.Size(105, 21);
            this.cbXmegaModuleClk.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "ErrorRate (%)";
            // 
            // tbXmegaError
            // 
            this.tbXmegaError.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbXmegaError.Location = new System.Drawing.Point(130, 152);
            this.tbXmegaError.Name = "tbXmegaError";
            this.tbXmegaError.ReadOnly = true;
            this.tbXmegaError.Size = new System.Drawing.Size(105, 20);
            this.tbXmegaError.TabIndex = 15;
            this.tbXmegaError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "BSEL Value";
            // 
            // tbXmegaBselVal
            // 
            this.tbXmegaBselVal.Location = new System.Drawing.Point(130, 126);
            this.tbXmegaBselVal.Name = "tbXmegaBselVal";
            this.tbXmegaBselVal.Size = new System.Drawing.Size(105, 20);
            this.tbXmegaBselVal.TabIndex = 14;
            this.tbXmegaBselVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbXmegaBselVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbXmegaBselVal_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Expected Baudrate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "F_CPU (Hz)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tbLpcFdrVal);
            this.tabPage3.Controls.Add(this.buttonLpcCalc);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.tbLpcAcBaud);
            this.tabPage3.Controls.Add(this.cbLpcExBaud);
            this.tabPage3.Controls.Add(this.cbLpcModuleClk);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tbLpcError);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.tbLpcDlmlVal);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(286, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LPC";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Fractinal FDR Value";
            // 
            // tbLpcFdrVal
            // 
            this.tbLpcFdrVal.Location = new System.Drawing.Point(130, 100);
            this.tbLpcFdrVal.Name = "tbLpcFdrVal";
            this.tbLpcFdrVal.Size = new System.Drawing.Size(105, 20);
            this.tbLpcFdrVal.TabIndex = 35;
            this.tbLpcFdrVal.Text = "1.00";
            this.tbLpcFdrVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLpcCalc
            // 
            this.buttonLpcCalc.Location = new System.Drawing.Point(130, 178);
            this.buttonLpcCalc.Name = "buttonLpcCalc";
            this.buttonLpcCalc.Size = new System.Drawing.Size(105, 48);
            this.buttonLpcCalc.TabIndex = 29;
            this.buttonLpcCalc.Text = "Calculate";
            this.buttonLpcCalc.UseVisualStyleBackColor = true;
            this.buttonLpcCalc.Click += new System.EventHandler(this.ButtonLpcCalc_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Actual BaudRate";
            // 
            // tbLpcAcBaud
            // 
            this.tbLpcAcBaud.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLpcAcBaud.Location = new System.Drawing.Point(130, 74);
            this.tbLpcAcBaud.Name = "tbLpcAcBaud";
            this.tbLpcAcBaud.ReadOnly = true;
            this.tbLpcAcBaud.Size = new System.Drawing.Size(105, 20);
            this.tbLpcAcBaud.TabIndex = 26;
            // 
            // cbLpcExBaud
            // 
            this.cbLpcExBaud.FormattingEnabled = true;
            this.cbLpcExBaud.Location = new System.Drawing.Point(130, 47);
            this.cbLpcExBaud.Name = "cbLpcExBaud";
            this.cbLpcExBaud.Size = new System.Drawing.Size(105, 21);
            this.cbLpcExBaud.TabIndex = 25;
            // 
            // cbLpcModuleClk
            // 
            this.cbLpcModuleClk.FormattingEnabled = true;
            this.cbLpcModuleClk.Location = new System.Drawing.Point(130, 20);
            this.cbLpcModuleClk.Name = "cbLpcModuleClk";
            this.cbLpcModuleClk.Size = new System.Drawing.Size(105, 21);
            this.cbLpcModuleClk.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "ErrorRate (%)";
            // 
            // tbLpcError
            // 
            this.tbLpcError.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLpcError.Location = new System.Drawing.Point(130, 152);
            this.tbLpcError.Name = "tbLpcError";
            this.tbLpcError.ReadOnly = true;
            this.tbLpcError.Size = new System.Drawing.Size(105, 20);
            this.tbLpcError.TabIndex = 28;
            this.tbLpcError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "DLM/L Value";
            // 
            // tbLpcDlmlVal
            // 
            this.tbLpcDlmlVal.Location = new System.Drawing.Point(130, 126);
            this.tbLpcDlmlVal.Name = "tbLpcDlmlVal";
            this.tbLpcDlmlVal.Size = new System.Drawing.Size(105, 20);
            this.tbLpcDlmlVal.TabIndex = 27;
            this.tbLpcDlmlVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLpcDlmlVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLpcDlmlVal_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Expected Baudrate";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "UART Clock (Hz)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BaudRate Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMegaUbrrVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMegaError;
        private System.Windows.Forms.ComboBox cbMegaExBaud;
        private System.Windows.Forms.ComboBox cbMegaModuleClk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMegaAcBaud;
        private System.Windows.Forms.Button buttonMegaCalc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonXmegaCalc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbXmegaAcBaud;
        private System.Windows.Forms.ComboBox cbXmegaExBaud;
        private System.Windows.Forms.ComboBox cbXmegaModuleClk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbXmegaError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbXmegaBselVal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbXmegaBscaleVal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbLpcFdrVal;
        private System.Windows.Forms.Button buttonLpcCalc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLpcAcBaud;
        private System.Windows.Forms.ComboBox cbLpcExBaud;
        private System.Windows.Forms.ComboBox cbLpcModuleClk;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbLpcError;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbLpcDlmlVal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
    }
}

