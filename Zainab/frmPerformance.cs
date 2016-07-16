using System;
using System.Linq;
using System.Windows.Forms;
namespace Zainab
{
    public partial class frmPerformance : Form
    {
        public frmPerformance()
        {
            InitializeComponent();
        }

        private void frmPerformance_Load(object sender, EventArgs e)
        {
            txtMonth.Text = DateTime.Now.Month.ToString();
            txtYear.Text = DateTime.Now.Year.ToString();
            using (var db = new dbZainabEntities1())
            {
                var rent = db.tblBookingRooms.Select(x => new
                {
                    rent = x.tblRoom.tblRoomType.Room_Rent,
                }).Sum(x => x.rent);
                var salary = db.tblStaffs.Sum(x => x.Salary);
                lblRoomRent.Text = rent.ToString();
                lblStaffSalary.Text = salary.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new dbZainabEntities1())
            {
                int year = int.Parse(txtYear.Text);
                int month = int.Parse(txtMonth.Text);

                var record = db.tblMessRecords.Join(db.tblMesses, x => x.MessId, y => y.Id, (r, m) => new
                    {
                        Month = r.Month,
                        Year = r.Year,
                        Sale = m.Rate
                    }).ToList();

                var sale = record.Where(x => x.Year == year).Where(x => x.Month == month).Sum(x => x.Sale);
                lblMessSale.Text = sale.ToString();

                var expensive =
                    db.tblExpensives.Where(x => x.Year == year).Where(x => x.Month == month).Sum(x => x.Expensive);
                lblMessExpensive.Text = expensive.ToString();
                if (lblMessExpensive.Text == "")
                {
                    lblMessExpensive.Text = "0";
                }

            }
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            int income = int.Parse(lblRoomRent.Text) + int.Parse(lblMessSale.Text);
            int expensive = int.Parse(lblStaffSalary.Text) + int.Parse(lblMessExpensive.Text);
            if (income > expensive)
            {
                lblProfit.Text = (income - expensive).ToString();
                lblLoss.Text = "0";
            }
            else
            {
                lblProfit.Text = "0";
                lblLoss.Text = (expensive - income).ToString();
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
