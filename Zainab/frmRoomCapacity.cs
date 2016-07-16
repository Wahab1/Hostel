using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Zainab
{
    public partial class frmRoomCapacity : Form
    {
        public frmRoomCapacity()
        {
            InitializeComponent();
        }

        private void frmRoomCapacity_Load(object sender, EventArgs e)
        {
            //{
            //    var result = db.tblBookingRooms.Join(db.tblStudentInformations, x => x.StudentId, y => y.Id,
            //                                         (b, s) => new
            //                                             {
            //                                                 Id = s.Id,
            //                                                 Name = s.Full_Name,
            //                                                 RoomId = b.RoomId
            //                                             }).Join(db.tblRooms, x => x.RoomId, y => y.Id, (s, r) => new
            //                                                 {
            //                                                     Id = s.Id,
            //                                                     room = r.RoomNo_
            //                                                 }).GroupBy(x => x.room);
            List<CheckRoomMember> result = CheckRoomBooking.GetRoom().ToList();

            int xi = 50;
            int yj = 100;

            foreach (var item in result)
            {
                if (yj == 500)
                {
                    xi += 350;
                    yj = 100;
                }
                else if (yj == 500 && xi == 400)
                {
                    xi += 350;
                    yj = 100;
                }
                var rn = new Label()
                {
                    Text = "RoomNo. " + item.RoomNo,
                    Location = new Point(xi, yj),
                    Width = 120
                };
                this.Controls.Add(rn);

                var r = new Label()
                    {
                        Text = "R.Seat: " + item.Capacity.ToString(),
                        Location = new Point(xi + 120, yj),
                        Width = 90
                    };
                this.Controls.Add(r);
                var un = new Label()
                    {
                        Text = "UR.Seat: " + (4 - int.Parse(item.Capacity)).ToString(),
                        Location = new Point(xi + 220, yj),
                        Width = 90
                    };
                this.Controls.Add(un);
                yj += 50;
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

