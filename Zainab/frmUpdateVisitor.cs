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
    public partial class frmUpdateVisitor : Form
    {
        public frmUpdateVisitor()
        {
            InitializeComponent();
        }
        VisitorMember visitor = new VisitorMember();
        public void PassValue(VisitorMember staff)
        {
            visitor = staff;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            ErrorFullName.Text = txtFullName.Text.Trim() == "" ? "*" : ("");
            //ErrorCNIC.Text = (txtfcnci.Text.Trim() == "" || txtmcnic.Text.Trim()
            //                                                == "" || txtlcnic.Text.Trim() == ""
            //                      ? "*"
            //                      : "");
            //ErrorMobile.Text = cmbsno.SelectedIndex == -1 ||
            //                   txtnumber.Text.Trim() == ""
            //                       ? "*"
            //                       : "";
            AddressError.Text = txtAddress.Text.Trim() == "" ? "*" : "";
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
                ErrorImageUrl.Text == "" && AddressError.Text == "")
            {
                VisitorMember staff = new VisitorMember();
                staff.Id = Convert.ToInt32(lblId.Text);
                staff.FullName = txtFullName.Text.Trim();
                staff.CNIC = string.Concat(txtfcnci.Text.Trim(), "-",
                                           txtmcnic.Text.Trim(), "-", txtlcnic.Text.Trim());
                staff.Mobile = txtnumber.Text.Trim();
                staff.Address = txtAddress.Text.Trim();
                DialogResult dialog = MessageBox.Show("Do you want to update", "U P D A T E", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Visitor.UpdateStaff(staff);
                    MessageBox.Show("Data has been updated", "U P D A T E",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmVisitor f = new frmVisitor();
                    f.ShowDialog();
                    this.Close();

                }
            }
        }

        private void frmUpdateVisitor_Load(object sender, EventArgs e)
        {
            lblId.Text = visitor.Id.ToString();
            txtFullName.Text = visitor.FullName;
            txtfcnci.Text = visitor.CNIC.Substring(0, 5);
            txtmcnic.Text = visitor.CNIC.Substring(6, 7);
            txtlcnic.Text = visitor.CNIC.Substring(8, 1);
            
            txtnumber.Text = visitor.Mobile;
            txtAddress.Text = visitor.Address;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVisitor f = new frmVisitor();
            f.ShowDialog();
            this.Close();
        }
    }
}
