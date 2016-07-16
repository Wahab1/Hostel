namespace Zainab
{
    partial class frmAttendence
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnrDate = new System.Windows.Forms.Button();
            this.btnfDate = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.btnfMonth = new System.Windows.Forms.Button();
            this.btnfYear = new System.Windows.Forms.Button();
            this.btnrMonth = new System.Windows.Forms.Button();
            this.btnrYear = new System.Windows.Forms.Button();
            this.btnaPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnViewAttendence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(535, 38);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(39, 29);
            this.txtDate.TabIndex = 125;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(582, 38);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.ReadOnly = true;
            this.txtMonth.Size = new System.Drawing.Size(40, 29);
            this.txtMonth.TabIndex = 126;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(630, 38);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(62, 29);
            this.txtYear.TabIndex = 127;
            // 
            // btnrDate
            // 
            this.btnrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrDate.Image = global::Zainab.Properties.Resources.down;
            this.btnrDate.Location = new System.Drawing.Point(546, 73);
            this.btnrDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnrDate.Name = "btnrDate";
            this.btnrDate.Size = new System.Drawing.Size(19, 23);
            this.btnrDate.TabIndex = 129;
            this.btnrDate.UseVisualStyleBackColor = true;
            this.btnrDate.Click += new System.EventHandler(this.btnrDate_Click);
            // 
            // btnfDate
            // 
            this.btnfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfDate.Image = global::Zainab.Properties.Resources.up;
            this.btnfDate.Location = new System.Drawing.Point(546, 13);
            this.btnfDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnfDate.Name = "btnfDate";
            this.btnfDate.Size = new System.Drawing.Size(19, 23);
            this.btnfDate.TabIndex = 128;
            this.btnfDate.UseVisualStyleBackColor = true;
            this.btnfDate.Click += new System.EventHandler(this.btnfDate_Click);
            // 
            // btnAttendence
            // 
            this.btnAttendence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAttendence.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendence.ForeColor = System.Drawing.Color.Black;
            this.btnAttendence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendence.Location = new System.Drawing.Point(594, 202);
            this.btnAttendence.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(149, 51);
            this.btnAttendence.TabIndex = 124;
            this.btnAttendence.Text = "Attendence";
            this.btnAttendence.UseVisualStyleBackColor = false;
            this.btnAttendence.Click += new System.EventHandler(this.btnAttendence_Click);
            // 
            // btnfMonth
            // 
            this.btnfMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfMonth.Image = global::Zainab.Properties.Resources.up;
            this.btnfMonth.Location = new System.Drawing.Point(594, 13);
            this.btnfMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnfMonth.Name = "btnfMonth";
            this.btnfMonth.Size = new System.Drawing.Size(19, 23);
            this.btnfMonth.TabIndex = 134;
            this.btnfMonth.UseVisualStyleBackColor = true;
            this.btnfMonth.Click += new System.EventHandler(this.btnfMonth_Click);
            // 
            // btnfYear
            // 
            this.btnfYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfYear.Image = global::Zainab.Properties.Resources.up;
            this.btnfYear.Location = new System.Drawing.Point(645, 13);
            this.btnfYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnfYear.Name = "btnfYear";
            this.btnfYear.Size = new System.Drawing.Size(19, 23);
            this.btnfYear.TabIndex = 135;
            this.btnfYear.UseVisualStyleBackColor = true;
            this.btnfYear.Click += new System.EventHandler(this.btnfYear_Click);
            // 
            // btnrMonth
            // 
            this.btnrMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrMonth.Image = global::Zainab.Properties.Resources.down;
            this.btnrMonth.Location = new System.Drawing.Point(594, 73);
            this.btnrMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnrMonth.Name = "btnrMonth";
            this.btnrMonth.Size = new System.Drawing.Size(19, 23);
            this.btnrMonth.TabIndex = 136;
            this.btnrMonth.UseVisualStyleBackColor = true;
            this.btnrMonth.Click += new System.EventHandler(this.btnrMonth_Click);
            // 
            // btnrYear
            // 
            this.btnrYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrYear.Image = global::Zainab.Properties.Resources.down;
            this.btnrYear.Location = new System.Drawing.Point(645, 73);
            this.btnrYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnrYear.Name = "btnrYear";
            this.btnrYear.Size = new System.Drawing.Size(19, 23);
            this.btnrYear.TabIndex = 137;
            this.btnrYear.UseVisualStyleBackColor = true;
            this.btnrYear.Click += new System.EventHandler(this.btnrYear_Click);
            // 
            // btnaPrevious
            // 
            this.btnaPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnaPrevious.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnaPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaPrevious.Location = new System.Drawing.Point(594, 131);
            this.btnaPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnaPrevious.Name = "btnaPrevious";
            this.btnaPrevious.Size = new System.Drawing.Size(149, 51);
            this.btnaPrevious.TabIndex = 138;
            this.btnaPrevious.Text = "Previous";
            this.btnaPrevious.UseVisualStyleBackColor = false;
            this.btnaPrevious.Click += new System.EventHandler(this.btnaPrevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(245, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 139;
            this.label1.Text = "Attendence Sheet";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenu.Location = new System.Drawing.Point(594, 274);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(149, 54);
            this.btnMenu.TabIndex = 160;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnViewAttendence
            // 
            this.btnViewAttendence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewAttendence.Location = new System.Drawing.Point(594, 353);
            this.btnViewAttendence.Name = "btnViewAttendence";
            this.btnViewAttendence.Size = new System.Drawing.Size(149, 61);
            this.btnViewAttendence.TabIndex = 161;
            this.btnViewAttendence.Text = "View Attendence";
            this.btnViewAttendence.UseVisualStyleBackColor = false;
            this.btnViewAttendence.Click += new System.EventHandler(this.btnViewAttendence_Click);
            // 
            // frmAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(760, 680);
            this.Controls.Add(this.btnViewAttendence);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaPrevious);
            this.Controls.Add(this.btnrYear);
            this.Controls.Add(this.btnrMonth);
            this.Controls.Add(this.btnfYear);
            this.Controls.Add(this.btnfMonth);
            this.Controls.Add(this.btnrDate);
            this.Controls.Add(this.btnfDate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnAttendence);
            this.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmAttendence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendence";
            this.Load += new System.EventHandler(this.frmAttendence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttendence;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnfDate;
        private System.Windows.Forms.Button btnrDate;
        private System.Windows.Forms.Button btnfMonth;
        private System.Windows.Forms.Button btnfYear;
        private System.Windows.Forms.Button btnrMonth;
        private System.Windows.Forms.Button btnrYear;
        private System.Windows.Forms.Button btnaPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnViewAttendence;

    }
}