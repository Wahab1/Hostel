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
    public partial class frmAttendenceSearch : Form
    {
        public frmAttendenceSearch()
        {
            InitializeComponent();
        }

        private void frmAttendenceSearch_Load(object sender, EventArgs e)
        {
            txtMonth.Text = DateTime.Now.Month.ToString();
            txtYear.Text = DateTime.Now.Year.ToString();
            using (var db = new dbZainabEntities1())
            {
                List<string> staff = db.tblStaffs.Select(x => x.Name).ToList();
                foreach (var i in staff)
                {
                    cmbStaff.Items.Add(i);
                }
            }
        }

        private void btnfMonth_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMonth.Text) < 12)
            {
                txtMonth.Text = Convert.ToString(Convert.ToInt32(txtMonth.Text) + 1);
            }
        }

        private void btnrMonth_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMonth.Text) > 1)
            {
                txtMonth.Text = Convert.ToString(Convert.ToInt32(txtMonth.Text) - 1);
            }
        }

        private void btnfYear_Click(object sender, EventArgs e)
        {
            txtYear.Text = Convert.ToString(Convert.ToInt32(txtYear.Text) + 1);
        }

        private void btnrYear_Click(object sender, EventArgs e)
        {
            txtYear.Text = Convert.ToString(Convert.ToInt32(txtYear.Text) - 1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            #region CheckBoxIntialize
            
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;
            chk6.Checked = false; 
            chk7.Checked = false;
            chk8.Checked = false;
            chk9.Checked = false;
            chk10.Checked = false;
            chk11.Checked = false;
            chk12.Checked = false;
            chk13.Checked = false;
            chk14.Checked = false;
            chk15.Checked = false;
            chk16.Checked = false;
            chk17.Checked = false;
            chk18.Checked = false;
            chk19.Checked = false;
            chk20.Checked = false;
            chk21.Checked = false;
            chk22.Checked = false;
            chk23.Checked = false;
            chk24.Checked = false;
            chk25.Checked = false;
            chk26.Checked = false;
            chk27.Checked = false;
            chk28.Checked = false;
            chk29.Checked = false;
            chk30.Checked = false;
            chk31.Checked = false;
            #endregion

            chk29.Visible = true;
            chk30.Visible = true;
            chk31.Visible = true;
            using (var db = new dbZainabEntities1())
            {
                if (txtMonth.Text == "4" || txtMonth.Text == "6" || txtMonth.Text == "9" || txtMonth.Text == "11")
                {
                    chk31.Visible = false;
                }
                else if (txtMonth.Text == "2")
                {
                    if (Convert.ToInt32(txtYear.Text) % 4 == 0)
                    {
                        chk30.Visible = false;
                        chk31.Visible = false;

                    }
                    else
                    {
                        chk29.Visible = false;
                        chk30.Visible = false;
                        chk31.Visible = false;
                    }
                }
                var result = db.tblAttendences.Select(x => new
                    {
                        Year = x.Date.Substring(x.Date.Length-4,4),
                        Month = x.Date.Substring(x.Date.IndexOf("-") + 1, x.Date.Length - 6 - x.Date.IndexOf("-")),
                        day = x.Date.Substring(0, x.Date.IndexOf("-")),
                        Name=x.Name
                    }).Where(x=>x.Name==cmbStaff.Text && x.Year==txtYear.Text &&x.Month==txtMonth.Text);
                foreach (var i in result)
                {
                    
                    #region Attendence
                    
                    if (i.day == "1")
                        chk1.Checked=true;
                    else if(i.day=="2")
                         chk2.Checked = true;
                    else if (i.day == "3")
                        chk3.Checked = true;
                    else if (i.day == "4")
                        chk4.Checked = true;
                    else if (i.day == "5")
                        chk5.Checked = true;
                    else if (i.day == "6")
                        chk6.Checked = true;
                    else if (i.day == "7")
                        chk7.Checked = true;
                    else if (i.day == "8")
                        chk8.Checked = true;
                    else if (i.day == "9")
                        chk9.Checked = true;
                    else if (i.day == "10")
                        chk10.Checked = true;
                    else if (i.day == "11")
                        chk11.Checked = true;
                    else if (i.day == "12")
                        chk12.Checked = true;
                    else if (i.day == "13")
                        chk13.Checked = true;
                    else if (i.day == "14")
                        chk14.Checked = true;
                    else if (i.day == "15")
                        chk15.Checked = true;
                    else if (i.day == "16")
                        chk16.Checked = true;
                    else if (i.day == "17")
                        chk17.Checked = true;
                    else if (i.day == "18")
                        chk18.Checked = true;
                    else if (i.day == "19")
                        chk19.Checked = true;
                    else if (i.day == "20")
                        chk20.Checked = true;
                    else if (i.day == "21")
                        chk21.Checked = true;
                    else if (i.day == "22")
                        chk22.Checked = true;
                    else if (i.day == "23")
                        chk23.Checked = true;
                    else if (i.day == "24")
                        chk24.Checked = true;
                    else if (i.day == "25")
                        chk25.Checked = true;
                    else if (i.day == "26")
                        chk26.Checked = true;
                    else if (i.day == "27")
                        chk27.Checked = true;
                    else if (i.day == "28")
                        chk28.Checked = true;
                    else if (i.day == "29")
                        chk29.Checked = true;
                    else if (i.day == "30")
                        chk30.Checked = true;
                    else if (i.day == "31")
                        chk31.Checked = true;
                    #endregion
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f=new frmAttendence();
            f.ShowDialog();
            this.Close();
        }
    }
}
