namespace Zainab
{
    partial class frmFeeSubmission
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnrMonth = new System.Windows.Forms.Button();
            this.btnfMonth = new System.Windows.Forms.Button();
            this.btnrYear = new System.Windows.Forms.Button();
            this.btnfYear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.chkNPaid = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(559, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 22);
            this.label9.TabIndex = 151;
            this.label9.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(616, 46);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(62, 29);
            this.txtYear.TabIndex = 148;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 155;
            this.label8.Text = "Month";
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(510, 45);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.ReadOnly = true;
            this.txtMonth.Size = new System.Drawing.Size(40, 29);
            this.txtMonth.TabIndex = 152;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Zainab.Properties.Resources.search;
            this.btnSave.Location = new System.Drawing.Point(698, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(37, 32);
            this.btnSave.TabIndex = 156;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnrMonth
            // 
            this.btnrMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrMonth.Image = global::Zainab.Properties.Resources.down;
            this.btnrMonth.Location = new System.Drawing.Point(522, 80);
            this.btnrMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnrMonth.Name = "btnrMonth";
            this.btnrMonth.Size = new System.Drawing.Size(19, 23);
            this.btnrMonth.TabIndex = 154;
            this.btnrMonth.UseVisualStyleBackColor = true;
            this.btnrMonth.Click += new System.EventHandler(this.btnrMonth_Click);
            // 
            // btnfMonth
            // 
            this.btnfMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfMonth.Image = global::Zainab.Properties.Resources.up;
            this.btnfMonth.Location = new System.Drawing.Point(522, 20);
            this.btnfMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnfMonth.Name = "btnfMonth";
            this.btnfMonth.Size = new System.Drawing.Size(19, 23);
            this.btnfMonth.TabIndex = 153;
            this.btnfMonth.UseVisualStyleBackColor = true;
            this.btnfMonth.Click += new System.EventHandler(this.btnfMonth_Click);
            // 
            // btnrYear
            // 
            this.btnrYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrYear.Image = global::Zainab.Properties.Resources.down;
            this.btnrYear.Location = new System.Drawing.Point(631, 81);
            this.btnrYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnrYear.Name = "btnrYear";
            this.btnrYear.Size = new System.Drawing.Size(19, 23);
            this.btnrYear.TabIndex = 150;
            this.btnrYear.UseVisualStyleBackColor = true;
            this.btnrYear.Click += new System.EventHandler(this.btnrYear_Click);
            // 
            // btnfYear
            // 
            this.btnfYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfYear.Image = global::Zainab.Properties.Resources.up;
            this.btnfYear.Location = new System.Drawing.Point(631, 21);
            this.btnfYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnfYear.Name = "btnfYear";
            this.btnfYear.Size = new System.Drawing.Size(19, 23);
            this.btnfYear.TabIndex = 149;
            this.btnfYear.UseVisualStyleBackColor = true;
            this.btnfYear.Click += new System.EventHandler(this.btnfYear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.dgvStudent);
            this.groupBox1.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 324);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Record";
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(11, 37);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(801, 281);
            this.dgvStudent.TabIndex = 0;
            // 
            // chkNPaid
            // 
            this.chkNPaid.AutoSize = true;
            this.chkNPaid.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNPaid.Location = new System.Drawing.Point(698, 47);
            this.chkNPaid.Name = "chkNPaid";
            this.chkNPaid.Size = new System.Drawing.Size(91, 26);
            this.chkNPaid.TabIndex = 1;
            this.chkNPaid.Text = "Not Paid";
            this.chkNPaid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 158;
            this.label1.Text = "Fee Report";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(752, 105);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(53, 32);
            this.btnMenu.TabIndex = 159;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmFeeSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(817, 451);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNPaid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnrMonth);
            this.Controls.Add(this.btnfMonth);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnrYear);
            this.Controls.Add(this.btnfYear);
            this.Controls.Add(this.txtYear);
            this.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmFeeSubmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FeeSubmission";
            this.Load += new System.EventHandler(this.frmFeeSubmission_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnrYear;
        private System.Windows.Forms.Button btnfYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnrMonth;
        private System.Windows.Forms.Button btnfMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.CheckBox chkNPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
    }
}