using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Zainab
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();

        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            txtYear.Text = DateTime.Now.Year.ToString();
            #region Booking
            List<string> degree = Booking.GetDegree();
            foreach (var item in degree)
            {
                
                
            }
            
            
            List<string> rooms = Booking.GetRoomNumber();
            foreach (var item in rooms)
            {
                cmbRoomNo.Items.Add(item.ToString());
            }
            cmbRoomNo.SelectedIndex = 0;
            DataSet ds = Booking.LoadData();
            dgvBooking.DataSource = ds.Tables[0].DefaultView;
            dgvBooking.Columns[0].Visible = false;
            #endregion
            #region FeeSubmission

            DataSet dsFee = FeeSubmission.DataLoad();
            dgvFeeSubmission.DataSource = dsFee.Tables[0].DefaultView;
            dgvFeeSubmission.Columns[0].Visible = false;

            #endregion


        }

        private void cmbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            List<string> department = Booking.GetDepartment();
            foreach (var item in department)
            {
                
                
            }
            
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCapacity.Text = Booking.RoomCapactiy(cmbRoomNo.Text).ToString();
            txtRent.Text = Booking.RoomRent(cmbRoomNo.Text).ToString();
        }
        #region RoomSave
        private void btnRoomSave_Click(object sender, EventArgs e)
        {
            
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
            
            if (ErrorCNIC.Text == "" && txtCapacity.Text != "0")
            {
                //BookingMember booking = new BookingMember();
                //booking.StudentName = cmbStudent.Text;
                //booking.RoomNo = cmbRoomNo.Text;
                //Booking.BookRoom(booking);
                string cnic = string.Concat(txtfcnci.Text.Trim(), "-",
                txtmcnic.Text.Trim(), "-", txtlcnic.Text.Trim());
                string roomNo = cmbRoomNo.Text;
                using (var db = new dbZainabEntities1())
                {
                    var student = db.tblStudentInformations.SingleOrDefault(x => x.CNIC == cnic);
                    if (student != null)
                    {
                        var studentId = student.Id;
                        var studentVerify = db.tblBookingRooms.SingleOrDefault(x => x.StudentId == studentId);
                        if (studentVerify == null)
                        {
                            var room = db.tblRooms.SingleOrDefault(x => x.RoomNo_ == roomNo);
                            if (room != null)
                            {
                                var roomId = room.Id;

                                db.tblBookingRooms.Add(new tblBookingRoom()
                                    {
                                        RoomId = roomId,
                                        StudentId = studentId
                                    });
                                db.SaveChanges();
                                MessageBox.Show("Data has been saved", "S A V E",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ppd.Document = pd;
                                ppd.ShowDialog();
                                txtCapacity.Text = Booking.RoomCapactiy(cmbRoomNo.Text).ToString();
                                //cmbStudent.SelectedIndex = -1;
                                //cmbDegree.SelectedIndex = 0;
                                DataSet ds = Booking.LoadData();
                                dgvBooking.DataSource = ds.Tables[0].DefaultView;
                                dgvBooking.Columns[0].Visible = false;

                            }
                            else
                            {
                                MessageBox.Show("Invalid RoomNo#", "ERROR", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You have already reserved one room for this student", "ERROR", MessageBoxButtons.OK);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Invalid CNIC", "ERROR", MessageBoxButtons.OK);
                    }
                }





            }
        }
        #endregion
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateBookingRoom f = new frmUpdateBookingRoom();
            f.ShowDialog();
            this.Close();
        }

        private void cmbFeeDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Text = "0";
            
            
        }

        private void cmbFeeDegee_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            List<string> department = Booking.GetDepartment();
            foreach (var item in department)
            {
                
            }
            
        }

        private void cmbFeeStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        #region Submit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtffcnic.Text == "" || txtfmcnic.Text == "" || txtflcnic.Text == "")
            {
                ErrorfCNIC.Text = "*";
            }
            else
            {
                Int32 fcnic = 0, lcnic = 0, mcnic = 0;
                bool checkfcnic, checkmcnic, checklcnic;
                checkfcnic = int.TryParse(txtffcnic.Text, out fcnic);
                checkmcnic = int.TryParse(txtfmcnic.Text, out mcnic);
                checklcnic = int.TryParse(txtflcnic.Text, out lcnic);
                if (checkfcnic && checkmcnic && checklcnic)
                {
                    ErrorfCNIC.Text = "";
                }
                else
                {
                    ErrorfCNIC.Text = "* ";

                    txtffcnic.Text = "";
                    txtfmcnic.Text = "";
                    txtflcnic.Text = "";
                }
            }
            if (ErrorfCNIC.Text==""&&txtRoomNo.Text != "0" && cmbMonth.SelectedIndex != -1&&lblStudentId.Text!="0")
            {
                //FeeSubmission.FeeSubmissionStudent(cmbFeeStudent.Text, txtRoomNo.Text,
                //    cmbMonth.Text, txtYear.Text);

                using (var db = new dbZainabEntities1())
                {
                    int monthId = int.Parse(lblMonth.Text);
                    int studentId = int.Parse(lblStudentId.Text);
                    int roomId = int.Parse(txtRoomNo.Text);
                    int year = int.Parse(txtYear.Text);
                    db.tblFeeSubmissions.Add(new tblFeeSubmission()
                        {
                            MonthId = monthId,
                            StudentId = studentId,
                            RoomId = roomId,
                            Year = year
                        });
                    db.SaveChanges();
                    txtffcnic.Text = "";
                    txtfmcnic.Text = "";
                    txtflcnic.Text = "";
                    MessageBox.Show("Fee has been Submited", "Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRoomNo.Text = "0";
                    DataSet dsFee = FeeSubmission.DataLoad();
                    dgvFeeSubmission.DataSource = dsFee.Tables[0].DefaultView;
                    dgvFeeSubmission.Columns[0].Visible = false;
                    ppdFee.Document = pdFee;
                    ppdFee.ShowDialog();

                }
            }
        }
        #endregion
        #region FeeSubmissionSearch
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = FeeSubmission.DataLoadSearch(cmbSearchMonth.Text, txtSearchYear.Text);
            dgvFeeSubmission.DataSource = ds.Tables[0].DefaultView;
            dgvFeeSubmission.Columns[0].Visible = false;
            txtSearchYear.Text = "";
            cmbSearchMonth.SelectedIndex = -1;
        }
        #endregion

        private void btnSearchRoomNo_Click(object sender, EventArgs e)
        {
            DataSet ds = Booking.LoadDataSearch(txtSearchRoomNo.Text);
            dgvBooking.DataSource = ds.Tables[0].DefaultView;
            dgvBooking.Columns[0].Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f = new frmMenu();
            f.ShowDialog();
            this.Close();
        }

        #region RoomBooking
        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string cnic = string.Concat(txtfcnci.Text.Trim(), "-",
                txtmcnic.Text.Trim(), "-", txtlcnic.Text.Trim());
            string studentName = null;
            using (var db = new dbZainabEntities1())
            {
                var student = db.tblStudentInformations.SingleOrDefault(x => x.CNIC == cnic);
                if (student != null)
                {
                    studentName = student.Full_Name;
                }
            }


            using (SqlConnection con = Student.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from vwCompleteStudentSlip where studentName=@name", con);
                da.SelectCommand.Parameters.AddWithValue("@name", studentName);
                DataSet ds = new DataSet();
                da.Fill(ds, "student");

                e.Graphics.DrawString("Zainab", new Font("Goudy Old Style", 62, FontStyle.Italic), Brushes.Black, new Point(150, 50));
                e.Graphics.DrawString("Hall", new Font("Goudy Old Style", 50, FontStyle.Italic), Brushes.Black, new Point(350, 125));
                e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Goudy Old Style", 28, FontStyle.Italic), Brushes.Black, new Point(550, 145));
                e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                                   new Point(0, 200));
                e.Graphics.DrawString("Student Name", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 250));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[0], new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 250));
                e.Graphics.DrawString("Student CNIC", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 330));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[1], new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 330));
                e.Graphics.DrawString("Contact No#", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 410));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[2], new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 410));
                e.Graphics.DrawString("Session", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 490));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[3], new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 490));
                e.Graphics.DrawString("Degree", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 570));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[5]
                    + "(" + (string)ds.Tables[0].Rows[0].ItemArray[4] + ")", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 570));
                e.Graphics.DrawString("Room No#", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 650));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[6], new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 650));
                e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                                   new Point(0, 700));


                e.Graphics.DrawString("Student Signature", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 755));
                e.Graphics.DrawString("-------------------------------", new Font("Arial", 16, FontStyle.Italic), Brushes.Black, new Point(550, 780));
                e.Graphics.DrawString("Asistant Superintendent Signature", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 835));
                e.Graphics.DrawString("-------------------------------", new Font("Arial", 16, FontStyle.Italic), Brushes.Black, new Point(550, 860));
                e.Graphics.DrawString("Superintendent Signature", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 915));
                e.Graphics.DrawString("-------------------------------", new Font("Arial", 16, FontStyle.Italic), Brushes.Black, new Point(550, 940));
                
            }
        }
        #endregion
        #region FeeSubmission
        private void pdFee_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (SqlConnection con = Student.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select top 1 [Student Name],CNIC,RoomNo#,Room_Rent,Contact_No#,Month,Year" +
                                                       " from vwFeeSubmisstionComplete order by Id desc",
                                                       con);
                DataSet ds = new DataSet();
                da.Fill(ds, "student");

                e.Graphics.DrawString("Zainab", new Font("Goudy Old Style", 62, FontStyle.Italic), Brushes.Black,
                                      new Point(150, 50));
                e.Graphics.DrawString("Hall", new Font("Goudy Old Style", 50, FontStyle.Italic), Brushes.Black,
                                      new Point(350, 125));
                e.Graphics.DrawString(DateTime.Now.ToShortDateString(),
                                      new Font("Goudy Old Style", 28, FontStyle.Italic), Brushes.Black,
                                      new Point(550, 145));
                e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                                      new Point(0, 200));
                e.Graphics.DrawString("Student Name", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 250));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[0], new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 250));
                e.Graphics.DrawString("Student CNIC", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 330));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[1], new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 330));
                e.Graphics.DrawString("Contact No#", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 410));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[4], new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 410));
                e.Graphics.DrawString("Room No#", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 490));
                e.Graphics.DrawString(ds.Tables[0].Rows[0].ItemArray[2].ToString(), new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 490));
                e.Graphics.DrawString("Room Rent", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 570));
                e.Graphics.DrawString(ds.Tables[0].Rows[0].ItemArray[3].ToString(),
                    new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 570));
                e.Graphics.DrawString("Month and Year", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 650));
                e.Graphics.DrawString((string)ds.Tables[0].Rows[0].ItemArray[5] + " " +
                    (string)ds.Tables[0].Rows[0].ItemArray[6].ToString(),
                    new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(550, 650));
                e.Graphics.DrawString(lbldashes.Text, new Font("Goudy Old Style", 16, FontStyle.Italic), Brushes.Black,
                                   new Point(0, 700));
                e.Graphics.DrawString("Student Signature", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 755));
                e.Graphics.DrawString("-------------------------------", new Font("Arial", 16, FontStyle.Italic), Brushes.Black, new Point(550, 780));
                e.Graphics.DrawString("Asistant Superintendent Signature", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 835));
                e.Graphics.DrawString("-------------------------------", new Font("Arial", 16, FontStyle.Italic), Brushes.Black, new Point(550, 860));
                e.Graphics.DrawString("Superintendent Signature", new Font("Goudy Old Style", 24, FontStyle.Italic), Brushes.Black, new Point(100, 915));
                e.Graphics.DrawString("-------------------------------", new Font("Arial", 16, FontStyle.Italic), Brushes.Black, new Point(550, 940));
            }
        }
        #endregion

        private void txtflcnic_TextChanged(object sender, EventArgs e)
         {
             if (txtffcnic.Text != "" && txtfmcnic.Text != "")
             {
                 string cnic = string.Concat(txtffcnic.Text.Trim(), "-",
                     txtfmcnic.Text.Trim(), "-", txtflcnic.Text.Trim());
                 using (var db = new dbZainabEntities1())
                 {
                     var student = db.tblStudentInformations.SingleOrDefault(x => x.CNIC == cnic);
                     if (student != null)
                     {
                         var studentId = student.Id;
                         var room = db.tblBookingRooms.SingleOrDefault(x => x.StudentId == studentId);
                         if (room != null)
                         {
                             txtRoomNo.Text = room.Id.ToString();
                             lblStudentId.Text = student.Id.ToString();
                         }
                     }
                 }
                 
             }
        }

        private void txtfmcnic_TextChanged(object sender, EventArgs e)
        {
            txtlcnic.Text = "";
        }

        private void txtffcnic_TextChanged(object sender, EventArgs e)
        {
            txtfcnci.Text = "";
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new dbZainabEntities1())
            {
                var month = db.tblMonths.SingleOrDefault(x => x.Month == cmbMonth.Text);
                if (month != null)
                {
                    lblMonth.Text = month.Id.ToString();
                }
            }
        }
    }
}
