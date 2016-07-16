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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Update", "U P D A T E", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                int confirm=Login .ChangePassword(txtUserName.Text,
                    txtOldPassword.Text,txtNewPassword.Text);
                if (confirm == 1)
                {
                    this.Hide();
                    frmLogin f = new frmLogin();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or OldPassword", "E R R O R", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f=new frmLogin();
            f.ShowDialog();
            this.Close();
        }
    }
}
