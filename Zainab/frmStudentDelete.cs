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
    public partial class frmStudentDelete : Form
    {
        private StudentMember student=new StudentMember();
        public frmStudentDelete()
        {
            InitializeComponent();
        }

        public void PassValue(StudentMember stud)
        {
            student = stud;
        }

        private void frmStudentDelete_Load(object sender, EventArgs e)
        {
            lblId.Text = student.StudnetId.ToString();
            lblImageUrl.Text = student.ImageUrl;
            lblFullName.Text = student.FullName;
            lblCNIC.Text = student.CNIC;
            lblGender.Text = student.Gender;
            lblSession.Text = student.Sesssion;
            lblRollNo.Text = student.RollNo;
            lblDegree.Text = student.Degree;
            lblDepartment.Text = student.Department;
            lblFather.Text = student.FatherName;
            picStudent.ImageLocation = lblImageUrl.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete?", "D E L E T E", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Student.DeleteStudent(Convert.ToInt32(lblId.Text));
                MessageBox.Show("Data has been deleted", "D E L E T E",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Hide();
                frmStudentInformation f=new frmStudentInformation();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentInformation f = new frmStudentInformation();
            f.ShowDialog();
            this.Close();
        }
    }
}
