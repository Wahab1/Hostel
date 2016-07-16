using System;
using System.Windows.Forms;

namespace Zainab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmStudentInformation());
            // Application.Run(new frmRoom());
           //Application.Run(new frmBooking());
            //  Application.Run(new frmUpdateBookingRoom());
            // Application.Run(new frmStaff());
            //  Application.Run(new frmUpdateStaff());
            //  Application.Run(new frmVisitor());
             Application.Run(new frmMenu());
           // Application.Run(new frmLogin());
           // Application.Run(new frmAttendence());
            //Application.Run(new frmRoomCapacity());
           // Application.Run(new frmMess());
           // Application.Run(new frmFeeSubmission());
           // Application.Run(new frmPerformance());
           // Application.Run(new frmAttendenceSearch());
        }
    }
}
