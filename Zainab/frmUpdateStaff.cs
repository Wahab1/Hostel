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
    public partial class frmUpdateStaff : Form
    {
        StaffMember staffMember = new StaffMember();
        public frmUpdateStaff()
        {
            InitializeComponent();
        }

        public void PassValue(StaffMember staff)
        {
            staffMember = staff;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
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
                StaffMember staff = new StaffMember();
                staff.Id = Convert.ToInt32(lblId.Text);
                staff.FullName = txtFullName.Text.Trim();
                staff.CNIC = string.Concat(txtfcnci.Text.Trim(), "-",
                txtmcnic.Text.Trim(), "-", txtlcnic.Text.Trim());
                staff.Mobile = txtnumber.Text.Trim();
                staff.Gender = rdmale.Checked ? rdmale.Text : rdfemale.Text;
                staff.ImageUrl = txtImageUrl.Text.Trim();
                staff.Address = txtAddress.Text.Trim();
                DialogResult dialog = MessageBox.Show("Do you want to update?", "U P D A T E", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Staff.UpdateStaff(staff);
                    MessageBox.Show("Data has been Updated", "U P D A T E",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmStaff f = new frmStaff();
                    f.ShowDialog();
                    this.Close();
                }
                
            }
            
        }

        private void frmUpdateStaff_Load(object sender, EventArgs e)
        {
            lblId.Text = staffMember.Id.ToString();
            txtFullName.Text = staffMember.FullName;
            txtfcnci.Text = staffMember.CNIC.Substring(0, 5);
            txtmcnic.Text = staffMember.CNIC.Substring(6, 7);
            txtlcnic.Text = staffMember.CNIC.Substring(8, 1);
            txtImageUrl.Text = staffMember.ImageUrl;
            txtnumber.Text = staffMember.Mobile;
            if (staffMember.Gender == "Male")
                rdmale.Checked = true;
            else
                rdfemale.Checked = true;
            txtAddress.Text = staffMember.Address;
            picStaff.ImageLocation = txtImageUrl.Text;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImageUrl.Text = ofd.FileName.ToString();
                picStaff.ImageLocation = txtImageUrl.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaff f=new frmStaff();
            f.ShowDialog();
            this.Close();

        }
    }
}
