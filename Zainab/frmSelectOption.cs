using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zainab
{
    public partial class frmSelectOption : Form
    {
        private StudentMember student = new StudentMember();
        StaffMember staff=new StaffMember();
        VisitorMember visitor=new VisitorMember();
        public frmSelectOption()
        {
            InitializeComponent();
        }
        public void PassValue(StudentMember stud,string option)
        {
            if (option == "Student")
                rdStudent.Checked = true;
            student = stud;
        }
        public void PassValue(StaffMember staffMember, string option)
        {
            if (option == "Staff")
                rdStaff.Checked = true;
            staff = staffMember;
        }
        public void PassValue(VisitorMember visit, string option)
        {
            if (option == "Visitor")
                rdVisitor.Checked = true;
            visitor = visit;
        }
        private void rdUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdStudent.Checked)
            {
                this.Hide();
                frmStudentUpdate f = new frmStudentUpdate();
                f.PassValue(student);
                f.ShowDialog();
                this.Close();
            }
            else if (rdStaff.Checked)
            {
                this.Hide();
                frmUpdateStaff f=new frmUpdateStaff();
                f.PassValue(staff);
                f.ShowDialog();
                this.Close();
            }
            else if (rdVisitor.Checked)
            {
                this.Hide();
                frmUpdateVisitor f=new frmUpdateVisitor();
                f.PassValue(visitor);
                f.ShowDialog();
                this.Close();
            }
        }

        private void rdDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdStudent.Checked)
            {
                this.Hide();
                frmStudentDelete f = new frmStudentDelete();
                f.PassValue(student);
                f.ShowDialog();
                this.Close();
            }
            else if (rdStaff.Checked)
            {
                this.Hide();
                frmDeleteStaff f = new frmDeleteStaff();
                f.PassValue(staff);
                f.ShowDialog();
                this.Close();
            }
            else if (rdVisitor.Checked)
            {
                this.Hide();
                frmDeleteVisitor f = new frmDeleteVisitor();
                f.PassValue(visitor);
                f.ShowDialog();
                this.Close();
            }
           
        }

        private void frmSelectOption_Load(object sender, EventArgs e)
        {

        }
    }
}
