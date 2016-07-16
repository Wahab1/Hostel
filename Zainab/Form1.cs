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
    public partial class frmStudentInformation : Form
    {
        public frmStudentInformation()
        {
            InitializeComponent();
        }
        #region ImageUpLoad
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
        #endregion

        private void frmStudentInformation_Load(object sender, EventArgs e)
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
            DataSet ds = Student.LoadData();
            dgvStudent.DataSource = ds.Tables["Student"].DefaultView;
            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[16].Visible = false;
        }
        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {
#region Validation
            ErrorFullName.Text = txtFullName.Text.Trim() == "" ? "*" : ("");
            //ErrorCNIC.Text = (txtfcnci.Text.Trim() == "" || txtmcnic.Text.Trim()
            //    == "" || txtlcnic.Text.Trim() == "" ? "*" : "");
            //ErrorMobile.Text = cmbsno.SelectedIndex == -1 ||
            //    txtnumber.Text.Trim() == "" ? "*" : "";
            ErrorDegree.Text = cmbDegree.SelectedIndex == -1 ? "*" : "";
            ErrorDepartment.Text = cmbdepartment.SelectedIndex == -1 ? "*" : "";
            ErrorRollNo.Text = txtRollNo.Text.Trim() == "" ? "*" : "";

            //ErrorSession.Text = txtSessionStart.Text.Length < 4
            //    || txtSessionEnd.Text.Length < 4 ? "*" : "";


            ErrorAge.Text = txtAge.Text.Trim() == "" ? "*" : "";
            ErrorOccupation.Text = txtOccupation.Text.Trim() == "" ? "*" : "";
            ErrorAddress.Text = txtAddress.Text.Trim() == "" ? "*" : "";
            ErrorNationality.Text = txtNationality.Text.Trim() == "" ? "*" : "";
            ErrorImageUrl.Text = txtImageUrl.Text.Trim() == "" ? "*" : "";
            ErrorFather.Text = txtFather.Text.Trim() == "" ? "*" : "";
            ErrorIncome.Text = txtIncome.Text.Trim() == "" ? "*" : "";
            if ( txtnumber.Text == "")
            {
                ErrorMobile.Text = "*";
            }
            else
            {
                int number = 0;
                bool conversionNumber = int.TryParse(txtnumber.Text, out number);
                //ErrorMobile.Text = conversionNumber ? "" : "*";
                if (conversionNumber)
                {
                    ErrorMobile.Text = "";
                }
                else
                {
                    ErrorMobile.Text = "*";
                    txtnumber.Text = "";
                }
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
                //ErrorSession.Text = sessionStart && sessionEnd ? "" : "*";
                if (sessionStart && sessionEnd)
                {

                    //ErrorSession.Text = "";
                    ErrorSession.Text = txtSessionStart.Text.Length < 4
                || txtSessionEnd.Text.Length < 4 ? "*" : "";
                }
                else
                {
                    ErrorSession.Text = "*";
                    txtSessionStart.Text = "";
                    txtSessionEnd.Text = "";
                }
            }
#endregion
            if (ErrorFullName.Text == ""&&ErrorCNIC.Text==""&&ErrorDegree.Text==""&&
                ErrorRollNo.Text==""&&ErrorDepartment.Text==""&&ErrorMobile.Text==""
                &&ErrorSession.Text==""&&ErrorAge.Text==""&&ErrorOccupation.Text==""
                &&ErrorAddress.Text==""&&ErrorNationality.Text==""&&ErrorImageUrl.Text==""
                &&ErrorFather.Text==""&&ErrorIncome.Text=="")
            {
                StudentMember student = new StudentMember();
                student.FullName = txtFullName.Text.Trim();
                student.CNIC = string.Concat(txtfcnci.Text.Trim(), "-",
                txtmcnic.Text.Trim(), "-", txtlcnic.Text.Trim());
                student.Mobile = txtnumber.Text.Trim();
                student.Degree = cmbDegree.Text;
                student.Department = cmbdepartment.Text;
                student.Gender = rdmale.Checked ? rdmale.Text : rdfemale.Text;
                student.RollNo = txtRollNo.Text.Trim();
                student.Sesssion = string.Concat(txtSessionStart.Text, "-", txtSessionEnd.Text);
                int age=0,income;
                bool ageConvertion = int.TryParse(txtAge.Text.Trim(), out age);
                if (ageConvertion)
                {
                    student.Age = age;
                    ErrorAge.Text = "";
                }
                
                else
                    ErrorAge.Text = "*";

                student.Religion = rdMuslim.Checked ? rdMuslim.Text : rdNonMuslim.Text;
                student.Occupation = txtOccupation.Text.Trim();
                student.Address = txtAddress.Text.Trim();
                student.ImageUrl = txtImageUrl.Text.Trim();
                student.FatherName = txtFather.Text.Trim();
                student.Nationality = txtNationality.Text.Trim();
                bool incomeConvertion = int.TryParse(txtIncome.Text.Trim(), out income);
                if (incomeConvertion)
                {
                    student.Income = income;
                    ErrorIncome.Text = "";
                }
                else
                    ErrorIncome.Text = "*";
                if (ErrorIncome.Text == "" && ErrorAge.Text == "")
                {
                    Student.AddStudent(student);
                    MessageBox.Show("Data has been saved", "S A V E",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFullName.Text = "";
                    txtfcnci.Text = "";
                    txtmcnic.Text = "";
                    txtlcnic.Text = "";
                    txtImageUrl.Text = "";
                    txtnumber.Text = "";
                    cmbDegree.SelectedIndex = -1;
                    rdmale.Checked = true;
                    cmbdepartment.SelectedIndex = -1;
                    txtRollNo.Text = "";
                    txtSessionStart.Text = "";
                    txtSessionEnd.Text = "";
                    txtAge.Text = "";
                    txtFather.Text = "";
                    txtIncome.Text = "";
                    rdMuslim.Checked = true;
                    txtOccupation.Text = "";
                    txtNationality.Text = "";
                    txtAddress.Text = "";
                    DataSet ds = Student.LoadData();
                    dgvStudent.DataSource = ds.Tables["Student"].DefaultView;
                    dgvStudent.Columns[0].Visible = false;
                    dgvStudent.Columns[16].Visible = false;
                }
               
            }

        }
        #endregion

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudent.Rows.Count > 1)
            {

                StudentMember student = new StudentMember();
                student.StudnetId = (int)dgvStudent.SelectedRows[0].Cells[0].Value;
                student.ImageUrl = (string)dgvStudent.SelectedRows[0].Cells[16].Value;
                student.FullName = (string)dgvStudent.SelectedRows[0].Cells[1].Value;
                student.CNIC = (string)dgvStudent.SelectedRows[0].Cells[2].Value;
                student.Gender = (string)dgvStudent.SelectedRows[0].Cells[5].Value;
                student.Sesssion = (string)dgvStudent.SelectedRows[0].Cells[8].Value;
                student.RollNo = (string)dgvStudent.SelectedRows[0].Cells[7].Value;
                student.Degree = (string)dgvStudent.SelectedRows[0].Cells[4].Value;
                student.Department = (string)dgvStudent.SelectedRows[0].Cells[6].Value;
                student.FatherName = (string)dgvStudent.SelectedRows[0].Cells[10].Value;
                student.Mobile = (string)dgvStudent.SelectedRows[0].Cells[3].Value;
                student.Age = (int)dgvStudent.SelectedRows[0].Cells[9].Value;
                student.Religion = (string)dgvStudent.SelectedRows[0].Cells[12].Value;
                this.Hide();
                frmSelectOption f = new frmSelectOption();
                f.PassValue(student, "Student");
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f=new frmMenu();
            f.ShowDialog();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = Student.SearchLoadData(txtSearch.Text);
            dgvStudent.DataSource = ds.Tables["Student"].DefaultView;
            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[16].Visible = false;
        }
    }
}
