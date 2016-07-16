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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImageUrl.Text = ofd.FileName.ToString();
                picStaff.ImageLocation = txtImageUrl.Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ErrorFullName.Text = txtFullName.Text.Trim() == "" ? "*" : ("");
            //ErrorCNIC.Text = (txtfcnci.Text.Trim() == "" || txtmcnic.Text.Trim()
            //    == "" || txtlcnic.Text.Trim() == "" ? "*" : "");
            //ErrorMobile.Text = cmbsno.SelectedIndex == -1 ||
            //    txtnumber.Text.Trim() == "" ? "*" : "";
            ErrorImageUrl.Text = txtImageUrl.Text.Trim() == "" ? "*" : "";
            ErrorAddress.Text = txtAddress.Text.Trim() == "" ? "*" : "";
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
            if (ErrorFullName.Text == "" && ErrorCNIC.Text == "" && ErrorMobile.Text == "" &&
                ErrorImageUrl.Text == "" && ErrorAddress.Text == "")
            {
                StaffMember staff=new StaffMember();
                staff.FullName = txtFullName.Text.Trim();
                staff.CNIC = string.Concat(txtfcnci.Text.Trim(), "-",
                txtmcnic.Text.Trim(), "-", txtlcnic.Text.Trim());
                staff.Mobile =txtnumber.Text.Trim();
                staff.Gender = rdmale.Checked ? rdmale.Text : rdfemale.Text;
                staff.ImageUrl = txtImageUrl.Text.Trim();
                staff.Address = txtAddress.Text.Trim();
                staff.Salary = Convert.ToInt32(txtSalary.Text.Trim());
                Staff.AddStaff(staff);
                MessageBox.Show("Data has been saved", "S A V E",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds = Staff.DataLoad();
                dgvStaff.DataSource = ds.Tables[0].DefaultView;
                dgvStaff.Columns[0].Visible = false;
                dgvStaff.Columns[6].Visible = false;
            }
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            DataSet ds = Staff.DataLoad();
            dgvStaff.DataSource = ds.Tables[0].DefaultView;
            dgvStaff.Columns[0].Visible = false;
            dgvStaff.Columns[6].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DataSet ds = Staff.DataSearch(txtSearch.Text);
                dgvStaff.DataSource = ds.Tables[0].DefaultView;
                dgvStaff.Columns[0].Visible = false;
                dgvStaff.Columns[6].Visible = false;
            }
            else
            {
                DataSet ds = Staff.DataLoad();
                dgvStaff.DataSource = ds.Tables[0].DefaultView;
                dgvStaff.Columns[6].Visible = false;
                dgvStaff.Columns[0].Visible = false;
            }

        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaff.Rows.Count > 1)
            {
                StaffMember staff = new StaffMember();
                staff.Id = (int)dgvStaff.SelectedRows[0].Cells[0].Value;
                staff.FullName = (string)dgvStaff.SelectedRows[0].Cells[1].Value;
                staff.CNIC = (string)dgvStaff.SelectedRows[0].Cells[2].Value;
                staff.Mobile = (string)dgvStaff.SelectedRows[0].Cells[3].Value;
                staff.Address = (string)dgvStaff.SelectedRows[0].Cells[4].Value;
                staff.Gender = (string)dgvStaff.SelectedRows[0].Cells[5].Value;
                staff.ImageUrl = (string)dgvStaff.SelectedRows[0].Cells[6].Value;
                this.Hide();
                frmSelectOption f = new frmSelectOption();
                f.PassValue(staff,"Staff");
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
    }
}
