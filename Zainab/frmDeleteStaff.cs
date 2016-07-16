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
    public partial class frmDeleteStaff : Form
    {
        StaffMember staffMember=new StaffMember();
        public frmDeleteStaff()
        {
            InitializeComponent();
        }

        public void PassValue(StaffMember staff)
        {
            staffMember = staff;
        }

        private void frmDeleteStaff_Load(object sender, EventArgs e)
        {
            lblId.Text = staffMember.Id.ToString();
            lblFullName.Text = staffMember.FullName;
            lblCNIC.Text = staffMember.CNIC;
            lblMobile.Text = staffMember.Mobile;
            lblGender.Text = staffMember.Gender;
            picStaff.ImageLocation = staffMember.ImageUrl;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete?", "D E L E T E", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                 Staff.DeleteStaff(lblId.Text);
            MessageBox.Show("Data has been Deleted", "D E L E T E",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            frmStaff f=new frmStaff();
            f.ShowDialog();
            this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaff f = new frmStaff();
            f.ShowDialog();
            this.Close();
        }
    }
}
