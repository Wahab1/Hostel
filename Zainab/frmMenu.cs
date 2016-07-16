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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoom f=new frmRoom();
            f.ShowDialog();
            this.Close();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentInformation f=new frmStudentInformation();
            f.ShowDialog();
            this.Close();
        }

        private void btnFeeBookinRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBooking f=new frmBooking();
            f.ShowDialog();
            this.Close();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaff f=new frmStaff();
            f.ShowDialog();
            this.Close();
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVisitor f=new frmVisitor();
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f=new frmLogin();
            f.ShowDialog();
            this.Close();
        }

        private void btnStaffAttendence_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAttendence f=new frmAttendence();
            f.ShowDialog();
            this.Close();
        }

        private void btnRoomRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoomCapacity f=new frmRoomCapacity();
            f.ShowDialog();
            this.Close();
        }

        private void btnFeeDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFeeSubmission f=new frmFeeSubmission();
            f.ShowDialog();
            this.Close();
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMess f=new frmMess();
            f.ShowDialog();
            this.Close();
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPerformance f=new frmPerformance();
            f.ShowDialog();
            this.Close();
        }
    }
}
