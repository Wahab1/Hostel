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
    public partial class frmDeleteVisitor : Form
    {
        public frmDeleteVisitor()
        {
            InitializeComponent();
        }
        VisitorMember visitor=new VisitorMember();
        public void PassValue(VisitorMember staff)
        {
            visitor = staff;
        }

        private void frmDeleteVisitor_Load(object sender, EventArgs e)
        {
            lblId.Text = visitor.Id.ToString();
            lblFullName.Text = visitor.FullName;
            lblCNIC.Text = visitor.CNIC;
            lblMobile.Text = visitor.Mobile;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to delete?", "D E L E T E", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                Visitor.DeleteStaff(lblId.Text);
                MessageBox.Show("Data has been deleted", "D E L E T E", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Hide();
                frmVisitor f=new frmVisitor();
                f.ShowDialog();
                this.Close();
            }
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
