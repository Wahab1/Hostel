namespace Zainab
{
    partial class frmMess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMess));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.txtDish = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnrYear = new System.Windows.Forms.Button();
            this.btnrMonth = new System.Windows.Forms.Button();
            this.btnfYear = new System.Windows.Forms.Button();
            this.btnfMonth = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtlcnic = new System.Windows.Forms.TextBox();
            this.txtmcnic = new System.Windows.Forms.TextBox();
            this.txtfcnci = new System.Windows.Forms.TextBox();
            this.cmbSDay = new System.Windows.Forms.ComboBox();
            this.ErrorCNIC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblExpensiveError = new System.Windows.Forms.Label();
            this.btnESave = new System.Windows.Forms.Button();
            this.txtExpensive = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRMYear = new System.Windows.Forms.Button();
            this.btnERMonth = new System.Windows.Forms.Button();
            this.btnEFYear = new System.Windows.Forms.Button();
            this.btnEfMonth = new System.Windows.Forms.Button();
            this.txtEYear = new System.Windows.Forms.TextBox();
            this.txtEMonth = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbDay.Location = new System.Drawing.Point(431, 57);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(121, 26);
            this.cmbDay.TabIndex = 1;
            this.cmbDay.SelectedIndexChanged += new System.EventHandler(this.cmbDay_SelectedIndexChanged);
            // 
            // txtDish
            // 
            this.txtDish.Location = new System.Drawing.Point(431, 120);
            this.txtDish.Name = "txtDish";
            this.txtDish.Size = new System.Drawing.Size(132, 26);
            this.txtDish.TabIndex = 2;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(597, 120);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(57, 26);
            this.txtRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dish Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select Day";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(660, 125);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnrYear);
            this.groupBox1.Controls.Add(this.btnrMonth);
            this.groupBox1.Controls.Add(this.btnfYear);
            this.groupBox1.Controls.Add(this.btnfMonth);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtMonth);
            this.groupBox1.Controls.Add(this.txtlcnic);
            this.groupBox1.Controls.Add(this.txtmcnic);
            this.groupBox1.Controls.Add(this.txtfcnci);
            this.groupBox1.Controls.Add(this.cmbSDay);
            this.groupBox1.Location = new System.Drawing.Point(431, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 246);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mess Order";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Zainab.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(298, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(37, 32);
            this.btnSave.TabIndex = 148;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 147;
            this.label9.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 146;
            this.label8.Text = "Month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 145;
            this.label7.Text = "CNIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 144;
            this.label6.Text = "Select Day";
            // 
            // btnrYear
            // 
            this.btnrYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrYear.Image = global::Zainab.Properties.Resources.down;
            this.btnrYear.Location = new System.Drawing.Point(247, 174);
            this.btnrYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnrYear.Name = "btnrYear";
            this.btnrYear.Size = new System.Drawing.Size(19, 23);
            this.btnrYear.TabIndex = 143;
            this.btnrYear.UseVisualStyleBackColor = true;
            this.btnrYear.Click += new System.EventHandler(this.btnrYear_Click);
            // 
            // btnrMonth
            // 
            this.btnrMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrMonth.Image = global::Zainab.Properties.Resources.down;
            this.btnrMonth.Location = new System.Drawing.Point(125, 174);
            this.btnrMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnrMonth.Name = "btnrMonth";
            this.btnrMonth.Size = new System.Drawing.Size(19, 23);
            this.btnrMonth.TabIndex = 142;
            this.btnrMonth.UseVisualStyleBackColor = true;
            this.btnrMonth.Click += new System.EventHandler(this.btnrMonth_Click);
            // 
            // btnfYear
            // 
            this.btnfYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfYear.Image = global::Zainab.Properties.Resources.up;
            this.btnfYear.Location = new System.Drawing.Point(247, 114);
            this.btnfYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnfYear.Name = "btnfYear";
            this.btnfYear.Size = new System.Drawing.Size(19, 23);
            this.btnfYear.TabIndex = 141;
            this.btnfYear.UseVisualStyleBackColor = true;
            this.btnfYear.Click += new System.EventHandler(this.btnfYear_Click);
            // 
            // btnfMonth
            // 
            this.btnfMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfMonth.Image = global::Zainab.Properties.Resources.up;
            this.btnfMonth.Location = new System.Drawing.Point(125, 114);
            this.btnfMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnfMonth.Name = "btnfMonth";
            this.btnfMonth.Size = new System.Drawing.Size(19, 23);
            this.btnfMonth.TabIndex = 140;
            this.btnfMonth.UseVisualStyleBackColor = true;
            this.btnfMonth.Click += new System.EventHandler(this.btnfMonth_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(232, 139);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(62, 26);
            this.txtYear.TabIndex = 139;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(113, 139);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.ReadOnly = true;
            this.txtMonth.Size = new System.Drawing.Size(40, 26);
            this.txtMonth.TabIndex = 138;
            // 
            // txtlcnic
            // 
            this.txtlcnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlcnic.Location = new System.Drawing.Point(306, 74);
            this.txtlcnic.Margin = new System.Windows.Forms.Padding(4);
            this.txtlcnic.MaxLength = 1;
            this.txtlcnic.Name = "txtlcnic";
            this.txtlcnic.Size = new System.Drawing.Size(37, 24);
            this.txtlcnic.TabIndex = 6;
            // 
            // txtmcnic
            // 
            this.txtmcnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmcnic.Location = new System.Drawing.Point(202, 75);
            this.txtmcnic.Margin = new System.Windows.Forms.Padding(4);
            this.txtmcnic.MaxLength = 7;
            this.txtmcnic.Name = "txtmcnic";
            this.txtmcnic.Size = new System.Drawing.Size(87, 24);
            this.txtmcnic.TabIndex = 5;
            // 
            // txtfcnci
            // 
            this.txtfcnci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfcnci.Location = new System.Drawing.Point(127, 75);
            this.txtfcnci.Margin = new System.Windows.Forms.Padding(4);
            this.txtfcnci.MaxLength = 5;
            this.txtfcnci.Name = "txtfcnci";
            this.txtfcnci.Size = new System.Drawing.Size(59, 24);
            this.txtfcnci.TabIndex = 4;
            // 
            // cmbSDay
            // 
            this.cmbSDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSDay.FormattingEnabled = true;
            this.cmbSDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cmbSDay.Location = new System.Drawing.Point(127, 40);
            this.cmbSDay.Name = "cmbSDay";
            this.cmbSDay.Size = new System.Drawing.Size(121, 26);
            this.cmbSDay.TabIndex = 2;
            // 
            // ErrorCNIC
            // 
            this.ErrorCNIC.AutoSize = true;
            this.ErrorCNIC.ForeColor = System.Drawing.Color.Red;
            this.ErrorCNIC.Location = new System.Drawing.Point(781, 348);
            this.ErrorCNIC.Name = "ErrorCNIC";
            this.ErrorCNIC.Size = new System.Drawing.Size(0, 18);
            this.ErrorCNIC.TabIndex = 149;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblExpensiveError);
            this.groupBox2.Controls.Add(this.btnESave);
            this.groupBox2.Controls.Add(this.txtExpensive);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnRMYear);
            this.groupBox2.Controls.Add(this.btnERMonth);
            this.groupBox2.Controls.Add(this.btnEFYear);
            this.groupBox2.Controls.Add(this.btnEfMonth);
            this.groupBox2.Controls.Add(this.txtEYear);
            this.groupBox2.Controls.Add(this.txtEMonth);
            this.groupBox2.Location = new System.Drawing.Point(431, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 152);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mess Expenses";
            // 
            // lblExpensiveError
            // 
            this.lblExpensiveError.AutoSize = true;
            this.lblExpensiveError.ForeColor = System.Drawing.Color.Red;
            this.lblExpensiveError.Location = new System.Drawing.Point(201, 109);
            this.lblExpensiveError.Name = "lblExpensiveError";
            this.lblExpensiveError.Size = new System.Drawing.Size(0, 18);
            this.lblExpensiveError.TabIndex = 159;
            // 
            // btnESave
            // 
            this.btnESave.Image = global::Zainab.Properties.Resources.save;
            this.btnESave.Location = new System.Drawing.Point(269, 100);
            this.btnESave.Name = "btnESave";
            this.btnESave.Size = new System.Drawing.Size(37, 32);
            this.btnESave.TabIndex = 158;
            this.btnESave.UseVisualStyleBackColor = true;
            this.btnESave.Click += new System.EventHandler(this.btnESave_Click);
            // 
            // txtExpensive
            // 
            this.txtExpensive.Location = new System.Drawing.Point(125, 106);
            this.txtExpensive.Name = "txtExpensive";
            this.txtExpensive.Size = new System.Drawing.Size(70, 26);
            this.txtExpensive.TabIndex = 157;
            this.txtExpensive.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 156;
            this.label12.Text = "Expenses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 155;
            this.label10.Text = "Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 154;
            this.label11.Text = "Month";
            // 
            // btnRMYear
            // 
            this.btnRMYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRMYear.Image = global::Zainab.Properties.Resources.down;
            this.btnRMYear.Location = new System.Drawing.Point(269, 71);
            this.btnRMYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnRMYear.Name = "btnRMYear";
            this.btnRMYear.Size = new System.Drawing.Size(19, 23);
            this.btnRMYear.TabIndex = 153;
            this.btnRMYear.UseVisualStyleBackColor = true;
            this.btnRMYear.Click += new System.EventHandler(this.btnRMYear_Click);
            // 
            // btnERMonth
            // 
            this.btnERMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnERMonth.Image = global::Zainab.Properties.Resources.down;
            this.btnERMonth.Location = new System.Drawing.Point(147, 71);
            this.btnERMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnERMonth.Name = "btnERMonth";
            this.btnERMonth.Size = new System.Drawing.Size(19, 23);
            this.btnERMonth.TabIndex = 152;
            this.btnERMonth.UseVisualStyleBackColor = true;
            this.btnERMonth.Click += new System.EventHandler(this.btnERMonth_Click);
            // 
            // btnEFYear
            // 
            this.btnEFYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEFYear.Image = global::Zainab.Properties.Resources.up;
            this.btnEFYear.Location = new System.Drawing.Point(269, 11);
            this.btnEFYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnEFYear.Name = "btnEFYear";
            this.btnEFYear.Size = new System.Drawing.Size(19, 23);
            this.btnEFYear.TabIndex = 151;
            this.btnEFYear.UseVisualStyleBackColor = true;
            this.btnEFYear.Click += new System.EventHandler(this.btnEFYear_Click);
            // 
            // btnEfMonth
            // 
            this.btnEfMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfMonth.Image = global::Zainab.Properties.Resources.up;
            this.btnEfMonth.Location = new System.Drawing.Point(147, 11);
            this.btnEfMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnEfMonth.Name = "btnEfMonth";
            this.btnEfMonth.Size = new System.Drawing.Size(19, 23);
            this.btnEfMonth.TabIndex = 150;
            this.btnEfMonth.UseVisualStyleBackColor = true;
            this.btnEfMonth.Click += new System.EventHandler(this.btnEfMonth_Click);
            // 
            // txtEYear
            // 
            this.txtEYear.Location = new System.Drawing.Point(254, 36);
            this.txtEYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtEYear.Name = "txtEYear";
            this.txtEYear.ReadOnly = true;
            this.txtEYear.Size = new System.Drawing.Size(62, 26);
            this.txtEYear.TabIndex = 149;
            // 
            // txtEMonth
            // 
            this.txtEMonth.Location = new System.Drawing.Point(135, 36);
            this.txtEMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtEMonth.Name = "txtEMonth";
            this.txtEMonth.ReadOnly = true;
            this.txtEMonth.Size = new System.Drawing.Size(40, 26);
            this.txtEMonth.TabIndex = 148;
            // 
            // btnChange
            // 
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(558, 152);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(39, 35);
            this.btnChange.TabIndex = 8;
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(194, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 33);
            this.label13.TabIndex = 151;
            this.label13.Text = "IQBAL Mess";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(711, 140);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(70, 32);
            this.btnMenu.TabIndex = 161;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmMess
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(803, 600);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ErrorCNIC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtDish);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmMess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mess";
            this.Load += new System.EventHandler(this.frmMess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.TextBox txtDish;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSDay;
        private System.Windows.Forms.TextBox txtlcnic;
        private System.Windows.Forms.TextBox txtmcnic;
        private System.Windows.Forms.TextBox txtfcnci;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnrYear;
        private System.Windows.Forms.Button btnrMonth;
        private System.Windows.Forms.Button btnfYear;
        private System.Windows.Forms.Button btnfMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label ErrorCNIC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExpensive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRMYear;
        private System.Windows.Forms.Button btnERMonth;
        private System.Windows.Forms.Button btnEFYear;
        private System.Windows.Forms.Button btnEfMonth;
        private System.Windows.Forms.TextBox txtEYear;
        private System.Windows.Forms.TextBox txtEMonth;
        private System.Windows.Forms.Button btnESave;
        private System.Windows.Forms.Label lblExpensiveError;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMenu;
    }
}