using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zainab
{
    public partial class frmStudentUpdate : Form
    {
        private StudentMember student = new StudentMember();

        public frmStudentUpdate()
        {
            InitializeComponent();
        }

        public void PassValue(StudentMember stud)
        {
            student = stud;
        }

        private void frmStudentUpdate_Load(object sender, EventArgs e)
        {
            List<string> degree = Student.GetDegree();
            foreach (var item in degree)
            {
                cmbDegree.Items.Add(item);
            }
            List<string> department = Student.GetDepartment();
            foreach (var item in department)
            {
                cmbdepartment.Items.Add(item);
            }

            lblId.Text = student.StudnetId.ToString();
            txtFullName.Text = student.FullName;
            txtfcnci.Text = student.CNIC.Substring(0, 5);
            txtmcnic.Text = student.CNIC.Substring(6, 7);
            txtlcnic.Text = student.CNIC.Substring(8, 1);
            cmbdepartment.Text = student.Department;
            txtImageUrl.Text = student.ImageUrl;
            txtnumber.Text = student.Mobile;
            txtSessionStart.Text = student.Sesssion.Substring(0, 4);
            txtSessionEnd.Text = student.Sesssion.Substring(5, 4);
            txtAge.Text = student.Age.ToString();
            cmbDegree.Text = student.Degree;
            if (student.Gender == "Male")
                rdmale.Checked = true;
            else
                rdfemale.Checked = true;
            cmbdepartment.Text = student.Department;
            txtRollNo.Text = student.RollNo;
            txtFather.Text = student.FatherName;
            if (student.Religion == "Muslim")
                rdMuslim.Checked = true;
            else
                rdNonMuslim.Checked = true;
            picStudent.ImageLocation = student.ImageUrl;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.* ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImageUrl.Text = ofd.FileName.ToString();
                picStudent.ImageLocation = txtImageUrl.Text;
            }
        }
        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ErrorFullName.Text = txtFullName.Text.Trim() == "" ? "*" : ("");
            //ErrorCNIC.Text = (txtfcnci.Text.Trim() == "" && txtmcnic.Text.Trim()
            //                                                == "" && txtlcnic.Text.Trim() == ""
            //                      ? "*"
            //                      : "");
            //ErrorMobile.Text = cmbsno.SelectedIndex == -1 &&
            //                   txtnumber.Text.Trim() == ""
            //                       ? "*"
            //                       : "";
            ErrorDegree.Text = cmbDegree.SelectedIndex == -1 ? "*" : "";
            ErrorDepartment.Text = cmbdepartment.SelectedIndex == -1 ? "*" : "";
            ErrorRollNo.Text = txtRollNo.Text.Trim() == "" ? "*" : "";
            //ErrorSession.Text = txtSessionStart.Text == ""
            //                    && txtSessionEnd.Text == ""
            //                        ? "*"
            //                        : "";
            ErrorAge.Text = txtAge.Text.Trim() == "" ? "*" : "";
            ErrorImageUrl.Text = txtImageUrl.Text.Trim() == "" ? "*" : "";
            ErrorFather.Text = txtFather.Text.Trim() == "" ? "*" : "";
            if (txtnumber.Text == "")
            {
                ErrorMobile.Text = "*";
            }
            else
            {
                int number = 0;
                bool conversionNumber = int.TryParse(txtnumber.Text, out number);
                ErrorMobile.Text = conversionNumber ? "" : "*";
            }
            if (txtfcnci.Text == "" || txtmcnic.Text == "" || txtlcnic.Text == "")
            {
                ErrorCNIC.Text = "*";
            }
            else
            {
                Int32 fcnic = 0, lcnic = 0, mcnic = 0;
                bool checkfcnic, checkmcnic, checklcnic;
                checkfcnic = int.TryParse(txtfcnci.Text, out fcnic);
                checkmcnic = int.TryParse(txtmcnic.Text, out mcnic);
                checklcnic = int.TryParse(txtlcnic.Text, out lcnic);
                if (checkfcnic && checkmcnic && checklcnic)
                {
                    ErrorCNIC.Text = "";
                }
                else
                {
                    ErrorCNIC.Text = "* ";

                    txtfcnci.Text = "";
                    txtmcnic.Text = "";
                    txtlcnic.Text = "";
                }
            }

            if (txtSessionStart.Text == "" || txtSessionEnd.Text == "")
            {
                ErrorSession.Text = "*";
            }
            else
            {
                int start = 0, end = 0;
                bool sessionStart = int.TryParse(txtSessionStart.Text, out start);
                bool sessionEnd = int.TryParse(txtSessionEnd.Text, out end);
                ErrorSession.Text = sessionStart && sessionEnd ? "" : "*";
            }

            if (ErrorFullName.Text == "" && ErrorCNIC.Text == "" && ErrorDegree.Text == "" &&
                ErrorRollNo.Text == "" && ErrorDepartment.Text == "" && ErrorMobile.Text == ""
                && ErrorSession.Text == "" && ErrorAge.Text == "" && ErrorImageUrl.Text == ""
                && ErrorFather.Text == "")
            {
                StudentMember student = new StudentMember();
                student.StudnetId = Convert.ToInt32(lblId.Text);
                student.FullName = txtFullName.Text.Trim();
                student.CNIC = string.Concat(txtfcnci.Text.Trim(), "-",
                                             txtmcnic.Text.Trim(), "-", txtlcnic.Text.Trim());
                student.Mobile = txtnumber.Text.Trim();
                student.Degree = cmbDegree.Text;
                student.Department = cmbdepartment.Text;
                student.Gender = rdmale.Checked ? rdmale.Text : rdfemale.Text;
                student.RollNo = txtRollNo.Text.Trim();
                student.Sesssion = string.Concat(txtSessionStart.Text, "-", txtSessionEnd.Text);
                int age = 0;
                bool ageConvertion = int.TryParse(txtAge.Text.Trim(), out age);
                if (ageConvertion)
                {
                    student.Age = age;
                    ErrorAge.Text = "";
                }

                else
                    ErrorAge.Text = "*";

                student.Religion = rdMuslim.Checked ? rdMuslim.Text : rdNonMuslim.Text;
                student.ImageUrl = txtImageUrl.Text.Trim();
                student.FatherName = txtFather.Text.Trim();
                if (ErrorAge.Text == "")
                {
                    Student.UpdateStudent(student);
                    MessageBox.Show("Data has been updated", "Update",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmStudentInformation f = new frmStudentInformation();
                    f.ShowDialog();
                    this.Close();
                }
            }
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentInformation f = new frmStudentInformation();
            f.ShowDialog();
            this.Close();
        }
    }
}
