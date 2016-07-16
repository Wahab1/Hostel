using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Zainab
{
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();

        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            txtroomno.Text = Room.GetRoomNumber().ToString();
            List<string> list = Room.GetRoomType();
            foreach (var item in list)
            {
                cmbroomtype.Items.Add(item);
            }
            cmbroomtype.SelectedIndex = 0;
            DataSet ds = Room.DataLoad();
            dgvRoom.DataSource = ds.Tables[0].DefaultView;
            dgvRoom.Columns[0].Visible = false;
        }

        private void cmbroomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtroomrent.Text = Room.RoomRent(cmbroomtype.Text).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ErrorRoomDescription.Text = txtroomDescription.SelectedIndex == -1 ? "*" : "";
            if (ErrorRoomDescription.Text == "")
            {

                RoomMember room = new RoomMember();
                room.RoomNo = Convert.ToInt32(txtroomno.Text);
                room.RoomType = cmbroomtype.Text;
                room.RoomCapacity = Convert.ToInt32(txtCapacity.Text);
                room.RoomDescription = txtroomDescription.Text;
                Room.AddRoom(room);
                MessageBox.Show("Data has been saved", "S A V E",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtroomDescription.SelectedIndex = -1;
                cmbroomtype.SelectedIndex = 0;
                txtroomno.Text = Room.GetRoomNumber().ToString();
                DataSet ds = Room.DataLoad();
                dgvRoom.DataSource = ds.Tables[0].DefaultView;
                dgvRoom.Columns[0].Visible = false;
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
