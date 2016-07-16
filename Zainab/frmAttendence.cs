using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Zainab
{
    public partial class frmAttendence : Form
    {
        private List<CheckBox> _check;

        public frmAttendence()
        {
            InitializeComponent();
        }

        private void frmAttendence_Load(object sender, EventArgs e)
        {
            #region Attendence Load
            txtDate.Text = DateTime.Now.Day.ToString();
            txtMonth.Text = DateTime.Now.Month.ToString();
            txtYear.Text = DateTime.Now.Year.ToString();
            using (var db = new dbZainabEntities1())
            {
                var result = db.tblStaffs;
                int i = 50;
                int j = 50;
                _check = new List<CheckBox>();
                foreach (var tblStaff in result)
                {
                    if (j == 600)
                    {
                        i += 150;
                        j = 100;
                    }

                    if (j == 600 && i == 200)
                    {
                        i += 150;
                        j = 100;
                    }
                    j += 50;
                    var checkBox = new CheckBox()
                    {
                        Text = tblStaff.Name,
                        Width = 200,
                        Location = new Point(i, j)
                    };
                    _check.Add(checkBox);
                    this.Controls.Add(checkBox);
                    var attendence = db.tblAttendences.Select(x => x).Where
                        (x => x.Date == (txtDate.Text + "-" + txtMonth.Text + "-" + txtYear.Text));
                    foreach (var tblAttendence in attendence)
                    {
                        foreach (var box in _check)
                        {
                            if (box.Text == tblAttendence.Name)
                            {
                                box.Checked = true;
                                box.Enabled = false;
                            }

                        }
                    }
            #endregion
                }


            }
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            foreach (var checkBox in _check)
            {

                using (var db = new dbZainabEntities1())
                {
                    if (checkBox.Checked && checkBox.Enabled)
                    {
                        var attend = new tblAttendence()
                       {
                           Name = checkBox.Text,
                           Date = string.Concat(txtDate.Text, "-", txtMonth.Text, "-", txtYear.Text)
                       };
                        db.tblAttendences.Add(attend);
                        db.SaveChanges();
                        
                        checkBox.Enabled = false;
                    }
                    
                }
                
            }
            MessageBox.Show("Done", "Attendence", MessageBoxButtons.OK);
        }
        #region DateUpdate
        private void btnfDate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtDate.Text) < 31)
            {
                txtDate.Text = Convert.ToString(Convert.ToInt32(txtDate.Text) + 1);
            }
        }

        private void btnrDate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtDate.Text) > 1)
            {
                txtDate.Text = Convert.ToString(Convert.ToInt32(txtDate.Text) - 1);
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
        #endregion

        #region Previous

        private void btnaPrevious_Click(object sender, EventArgs e)
        {
            foreach (var checkBox in _check)
            {
                checkBox.Checked = false;
                if (txtDate.Text == DateTime.Now.Day.ToString() &&
                    txtMonth.Text == DateTime.Now.Month.ToString() && txtYear.Text == DateTime.Now.Year.ToString())
                    checkBox.Enabled = true;
                else
                    checkBox.Enabled = false;
            }
            using (var db = new dbZainabEntities1())
            {
                var attendence = db.tblAttendences.Select(x => x).Where
                        (x => x.Date == (txtDate.Text + "-" + txtMonth.Text + "-" + txtYear.Text));
                foreach (var tblAttendence in attendence)
                {
                    foreach (var box in _check)
                    {
                        if (box.Text == tblAttendence.Name)
                        {
                            box.Checked = true;
                            box.Enabled = false;
                        }

                    }
                }


            }
        }
        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f = new frmMenu();
            f.ShowDialog();
            this.Close();
        }

        private void btnViewAttendence_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new frmAttendenceSearch();
            f.ShowDialog();
            this.Close();
        }

    }
}
