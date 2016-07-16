using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Zainab
{
    public partial class frmMess : Form
    {
        public frmMess()
        {
            InitializeComponent();
        }

        private void frmMess_Load(object sender, EventArgs e)
        {
            #region Mess
            using (var db = new dbZainabEntities1())
            {
                int j = 100;
                int i = 50;
                var result = db.tblMesses.ToList();
                foreach (var tblMess in result)
                {
                    var day = new Label()
                    {
                        Text = tblMess.Day,
                        Location = new Point(i, j),
                        Width = 100,
                        Height = 50,
                        Font = new Font("Perpetua", 14)
                    };
                    this.Controls.Add(day);

                    var dish = new Label()
                    {
                        Text = tblMess.Dish,
                        Location = new Point(i + 150, j),
                        Width = 100,
                        Height = 50,
                        Font = new Font("Perpetua", 14)
                    };
                    this.Controls.Add(dish);

                    var rate = new Label()
                    {
                        Text = tblMess.Rate.ToString(),
                        Location = new Point(i + 300, j),
                        Width = 100,
                        Height = 50,
                        Font = new Font("Perpetua", 14)
                    };
                    this.Controls.Add(rate);
                    j += 50;
                }
            }
            #endregion

            txtMonth.Text = DateTime.Now.Month.ToString();
            txtYear.Text = DateTime.Now.Year.ToString();
            txtEMonth.Text = DateTime.Now.Month.ToString();
            txtEYear.Text = DateTime.Now.Year.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int rate = 0;
            bool converstion = int.TryParse(txtRate.Text, out rate);
            lblError.Text = converstion ? "" : "*";
            lblError.Text = txtDish.Text != "" ? "" : "*";
            lblError.Text = cmbDay.SelectedIndex != -1 ? "" : "*";

            if (lblError.Text == "")
            {
                using (var db = new dbZainabEntities1())
                {
                    var result = db.tblMesses.SingleOrDefault(x => x.Day == cmbDay.Text);
                    if (result != null)
                    {
                        result.Dish = txtDish.Text;
                        result.Rate = rate;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Mess Has Been Updated..", "Message", MessageBoxButtons.OK);
                    this.Hide();
                    var f = new frmMess();
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new dbZainabEntities1())
            {
                var result = db.tblMesses.SingleOrDefault(x => x.Day == cmbDay.Text);
                if (result != null)
                {
                    txtDish.Text = result.Dish;
                    txtRate.Text = result.Rate.ToString();

                }
            }
        }
        #region MessRecord

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region CNIC Validation

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

            using (var db = new dbZainabEntities1())
            {
                string cnic = string.Concat(txtfcnci.Text.Trim(), "-",
                txtmcnic.Text.Trim(), "-", txtlcnic.Text.Trim());
                var result = db.tblStudentInformations.SingleOrDefault(x => x.CNIC == cnic);
                if (result != null)
                {
                    var day = db.tblMesses.SingleOrDefault(x => x.Day == cmbSDay.Text);
                    if (day != null)
                    {
                        var mess = new tblMessRecord()
                            {
                                StudentId = result.Id,
                                Month = Convert.ToInt32(txtMonth.Text),
                                Year = Convert.ToInt32(txtYear.Text),
                                MessId = day.Id
                            };
                        db.tblMessRecords.Add(mess);
                        db.SaveChanges();
                        MessageBox.Show("Data has been saved", "SAVE", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid CNIC", "Error", MessageBoxButtons.OK);
                }
            }
        }
        #endregion


        private void btnEfMonth_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtEMonth.Text) < 12)
            {
                txtEMonth.Text = Convert.ToString(Convert.ToInt32(txtEMonth.Text) + 1);
            }
        }

        private void btnERMonth_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtEMonth.Text) > 1)
            {
                txtEMonth.Text = Convert.ToString(Convert.ToInt32(txtEMonth.Text) - 1);
            }
        }

        private void btnEFYear_Click(object sender, EventArgs e)
        {
            txtEYear.Text = Convert.ToString(Convert.ToInt32(txtEYear.Text) + 1);
        }

        private void btnRMYear_Click(object sender, EventArgs e)
        {
            txtEYear.Text = Convert.ToString(Convert.ToInt32(txtEYear.Text) - 1);
        }

        private void btnESave_Click(object sender, EventArgs e)
        {
            int exp = 0;
            bool converstion = int.TryParse(txtExpensive.Text, out exp);
            lblExpensiveError.Text = txtExpensive.Text != "" && converstion && txtExpensive.Text != "0" ? "" : "*";
            lblExpensiveError.Text = exp > 0 ? "" : "*";
            if (lblExpensiveError.Text == "")
            {
                using (var db = new dbZainabEntities1())
                {
                    db.tblExpensives.Add(new tblExpensive()
                        {
                            Expensive = exp,
                            Month = Convert.ToInt32(txtEMonth.Text),
                            Year = Convert.ToInt32(txtEYear.Text)
                        });
                    db.SaveChanges();
                    MessageBox.Show("Data Has Been Saved", "SAVE", MessageBoxButtons.OK);
                }
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
