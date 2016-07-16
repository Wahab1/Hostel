namespace Zainab
{
    partial class frmSelectOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectOption));
            this.rdDefault = new System.Windows.Forms.RadioButton();
            this.rdDelete = new System.Windows.Forms.RadioButton();
            this.rdUpdate = new System.Windows.Forms.RadioButton();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.rdVisitor = new System.Windows.Forms.RadioButton();
            this.rdStaff = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdDefault
            // 
            this.rdDefault.AutoSize = true;
            this.rdDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDefault.Location = new System.Drawing.Point(88, 158);
            this.rdDefault.Name = "rdDefault";
            this.rdDefault.Size = new System.Drawing.Size(79, 24);
            this.rdDefault.TabIndex = 0;
            this.rdDefault.TabStop = true;
            this.rdDefault.Text = "Default";
            this.rdDefault.UseVisualStyleBackColor = true;
            // 
            // rdDelete
            // 
            this.rdDelete.AutoSize = true;
            this.rdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDelete.Location = new System.Drawing.Point(137, 101);
            this.rdDelete.Name = "rdDelete";
            this.rdDelete.Size = new System.Drawing.Size(74, 24);
            this.rdDelete.TabIndex = 1;
            this.rdDelete.TabStop = true;
            this.rdDelete.Text = "Delete";
            this.rdDelete.UseVisualStyleBackColor = true;
            this.rdDelete.CheckedChanged += new System.EventHandler(this.rdDelete_CheckedChanged);
            // 
            // rdUpdate
            // 
            this.rdUpdate.AutoSize = true;
            this.rdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUpdate.Location = new System.Drawing.Point(29, 101);
            this.rdUpdate.Name = "rdUpdate";
            this.rdUpdate.Size = new System.Drawing.Size(80, 24);
            this.rdUpdate.TabIndex = 2;
            this.rdUpdate.TabStop = true;
            this.rdUpdate.Text = "Update";
            this.rdUpdate.UseVisualStyleBackColor = true;
            this.rdUpdate.CheckedChanged += new System.EventHandler(this.rdUpdate_CheckedChanged);
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.rdVisitor);
            this.gbOption.Controls.Add(this.rdStaff);
            this.gbOption.Controls.Add(this.rdStudent);
            this.gbOption.Location = new System.Drawing.Point(12, 13);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(78, 123);
            this.gbOption.TabIndex = 3;
            this.gbOption.TabStop = false;
            this.gbOption.Visible = false;
            // 
            // rdVisitor
            // 
            this.rdVisitor.AutoSize = true;
            this.rdVisitor.Location = new System.Drawing.Point(6, 88);
            this.rdVisitor.Name = "rdVisitor";
            this.rdVisitor.Size = new System.Drawing.Size(53, 17);
            this.rdVisitor.TabIndex = 2;
            this.rdVisitor.TabStop = true;
            this.rdVisitor.Text = "Visitor";
            this.rdVisitor.UseVisualStyleBackColor = true;
            // 
            // rdStaff
            // 
            this.rdStaff.AutoSize = true;
            this.rdStaff.Location = new System.Drawing.Point(8, 53);
            this.rdStaff.Name = "rdStaff";
            this.rdStaff.Size = new System.Drawing.Size(47, 17);
            this.rdStaff.TabIndex = 1;
            this.rdStaff.TabStop = true;
            this.rdStaff.Text = "Staff";
            this.rdStaff.UseVisualStyleBackColor = true;
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(7, 20);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(62, 17);
            this.rdStudent.TabIndex = 0;
            this.rdStudent.TabStop = true;
            this.rdStudent.Text = "Student";
            this.rdStudent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = " Select Option";
            // 
            // frmSelectOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(249, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbOption);
            this.Controls.Add(this.rdUpdate);
            this.Controls.Add(this.rdDelete);
            this.Controls.Add(this.rdDefault);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSelectOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectOption";
            this.Load += new System.EventHandler(this.frmSelectOption_Load);
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdDefault;
        private System.Windows.Forms.RadioButton rdDelete;
        private System.Windows.Forms.RadioButton rdUpdate;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.RadioButton rdStaff;
        private System.Windows.Forms.RadioButton rdStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdVisitor;
    }
}