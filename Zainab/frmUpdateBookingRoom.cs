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
    public partial class frmUpdateBookingRoom : Form
    {
        public frmUpdateBookingRoom()
        {
            InitializeComponent();
        }

        private void frmUpdateBookingRoom_Load(object sender, EventArgs e)
        {
            List<string> degree = Booking.GetDegree();
            foreach (var item in degree)
            {
                cmbDegree.Items.Add(item);
            }
            cmbDegree.SelectedIndex = 0;
            List<string> rooms = Booking.GetRoomNumber();
            foreach (var item in rooms)
            {
                cmbRoomNo.Items.Add(item.ToString());
            }
            cmbRoomNo.SelectedIndex = 0;
        }

        private void cmbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDepartment.Items.Clear();
            List<string> department = Booking.GetDepartment();
            foreach (var item in department)
            {
                cmbDepartment.Items.Add(item);
            }
            cmbDepartment.SelectedIndex = 0;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudent.Items.Clear();
            List<string> student = Booking.GetUpdateStudent(cmbDepartment.Text, cmbDegree.Text);
            foreach (var item in student)
            {
                cmbStudent.Items.Add(item);
            }
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomNo.Items.Remove(Booking.GetStudentRoomNo(cmbStudent.Text));
            txtId.Text = Booking.UpdateStudentId(cmbStudent.Text).ToString();
        }

        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCapacity.Text = Booking.RoomCapactiy(cmbRoomNo.Text).ToString();
            txtRent.Text = Booking.RoomRent(cmbRoomNo.Text).ToString();
        }

        private void btnRoomSave_Click(object sender, EventArgs e)
        {
            ErrorStudent.Text = cmbStudent.SelectedIndex == -1 ? "*" : ""; 
            if (cmbStudent.SelectedIndex != -1 && txtCapacity.Text != "0")
            {
                Booking.UpdateStudentRoom(cmbRoomNo.Text, txtId.Text);
                MessageBox.Show("Data has been updated", "U P D A T E",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmBooking f = new frmBooking();
                f.ShowDialog();
                this.Close();
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBooking f = new frmBooking();
            f.ShowDialog();
            this.Close();
        }
    }
}
