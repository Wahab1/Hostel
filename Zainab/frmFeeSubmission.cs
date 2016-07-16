using System;
using System.Linq;
using System.Windows.Forms;
namespace Zainab
{
    public partial class frmFeeSubmission : Form
    {
        public frmFeeSubmission()
        {
            InitializeComponent();
        }

        private void frmFeeSubmission_Load(object sender, EventArgs e)
        {
            txtMonth.Text = DateTime.Now.Month.ToString();
            txtYear.Text = DateTime.Now.Year.ToString();
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
        #region Search


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new dbZainabEntities1())
            {
                int y = Convert.ToInt32(txtYear.Text);
                var result = db.tblFeeSubmissions.Where(x => x.Year == y).ToList();
                if (result != null)
                {
                    if (chkNPaid.Checked)
                    {
                        int m = int.Parse(txtMonth.Text);
                        var month = db.tblFeeSubmissions.Where(x => x.MonthId != m).Select(x => new
                            {
                                StudentName = x.tblStudentInformation.Full_Name,
                                StudentCNIC = x.tblStudentInformation.CNIC,
                                ContectNo = x.tblStudentInformation.Contact_No_

                            }).Distinct().ToList();
                        dgvStudent.DataSource = month;
                        dgvStudent.Columns[0].Width = 250;
                        dgvStudent.Columns[1].Width = 300;
                        dgvStudent.Columns[2].Width = 300;

                    }
                    else
                    {
                        int m = int.Parse(txtMonth.Text);
                        var month = db.tblFeeSubmissions.Where(x => x.MonthId == m).Select(x => new
                        {
                            StudentName = x.tblStudentInformation.Full_Name,
                            StudentCNIC = x.tblStudentInformation.CNIC,
                            Rooms = x.tblRoom.RoomNo_,
                            Months = x.tblMonth.Month,
                            ContectNo = x.tblStudentInformation.Contact_No_

                        }).ToList();
                        dgvStudent.DataSource = month;
                        dgvStudent.Columns[0].Width = 150;
                        dgvStudent.Columns[1].Width = 200;
                        dgvStudent.Columns[3].Width = 150;
                        dgvStudent.Columns[4].Width = 200;

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

    
    }
}
