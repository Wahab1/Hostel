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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int check = Login.UserLogin(txtUserName.Text, txtPassword.Text);
            if (check == 1)
            {
                this.Hide();
                frmMenu f = new frmMenu();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid UserName Or Password", "E R R O R",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangePassword f=new frmChangePassword();
            f.ShowDialog();
            this.Close();
        }
    }
}
