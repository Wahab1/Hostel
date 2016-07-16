using System;
using System.Data;
using System.Windows.Forms;

namespace Zainab
{
    public partial class frmVisitor : Form
    {
        public frmVisitor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Validation

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
            if ( txtnumber.Text == "")
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
            #endregion
            if (ErrorFullName.Text == "" && ErrorCNIC.Text == "" && ErrorMobile.Text == "" &&
                ErrorImageUrl.Text == "" && AddressError.Text == "")
            {
                VisitorMember staff = new VisitorMember();
                staff.FullName = txtFullName.Text.Trim();
                staff.CNIC = string.Concat(txtfcnci.Text.Trim(), "-",
                                           txtmcnic.Text.Trim(), "-", txtlcnic.Text.Trim());
                staff.Mobile = txtnumber.Text.Trim();
                staff.Address = txtAddress.Text.Trim();
                Visitor.AddVisitor(staff);
                MessageBox.Show("Data has been saved", "S A V E",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds = Visitor.LoadData();
                dgvVisitor.DataSource = ds.Tables[0].DefaultView;
                dgvVisitor.Columns[0].Visible = false;
                txtFullName.Text = "";
                txtfcnci.Text = "";
                txtmcnic.Text = "";
                txtlcnic.Text = "";
                txtnumber.Text = "";
                txtAddress.Text = "";
            }
        }

        private void frmVisitor_Load(object sender, EventArgs e)
        {
            DataSet ds = Visitor.LoadData();
            dgvVisitor.DataSource = ds.Tables[0].DefaultView;
            dgvVisitor.Columns[0].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = Visitor.SearchLoadData(txtSearch.Text);
            dgvVisitor.DataSource = ds.Tables[0].DefaultView;
            dgvVisitor.Columns[0].Visible = false;
        }

        private void dgvVisitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVisitor.Rows.Count > 1)
            {
                VisitorMember visitor = new VisitorMember();
                visitor.Id = (int)dgvVisitor.SelectedRows[0].Cells[0].Value;
                visitor.FullName = (string)dgvVisitor.SelectedRows[0].Cells[1].Value;
                visitor.CNIC = (string)dgvVisitor.SelectedRows[0].Cells[2].Value;
                visitor.Mobile = (string)dgvVisitor.SelectedRows[0].Cells[3].Value;
                visitor.Address = (string)dgvVisitor.SelectedRows[0].Cells[4].Value;
                this.Hide();
                frmSelectOption f = new frmSelectOption();
                f.PassValue(visitor, "Visitor");
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f = new frmMenu();
            f.ShowDialog();
            this.Close();
        }
    }
}
