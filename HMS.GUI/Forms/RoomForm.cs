using HMS.Business.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HMS.GUI.Forms
{
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        RoomTypeBusiness roomTypeBusiness = new RoomTypeBusiness();
        RoomBusiness roomBusiness = new RoomBusiness();

        private void BindRoom()
        {
            var rooms = roomBusiness.GetRooms();
            dgvRoom.DataSource = rooms;
            dgvRoom.Cursor = Cursors.Default;
        }

        private void BindRoomType()
        {
            var types = roomTypeBusiness.GetAll();
            types.Insert(0, new Entities.RoomType
            {
                RoomTypeId = 0,
                RoomTypeName = "Select..."
            });
            cbRoomType.DataSource = types;
            cbRoomType.DisplayMember = "RoomTypeName";
            cbRoomType.ValueMember = "RoomTypeId";
            cbRoomType.SelectedIndex = 0;
        }
        
        

        private void RoomForm_Load(object sender, EventArgs e)
        {
            BindRoom();
            BindRoomType();
        }

        private void dgvRooms_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvRoom.Rows[e.RowIndex];
            cbRoomType.SelectedValue = selectedRow.Cells["RoomTypeId"].Value;
            tbRoomFloor.Text = selectedRow.Cells["Floor"].Value.ToString();
            tbRoomNo.Text = selectedRow.Cells["RoomNo"].Value.ToString();
            lblRoomId.Text = selectedRow.Cells["RoomId"].Value.ToString();
            lblStatusId.Text = selectedRow.Cells["RoomStatusId"].Value.ToString();
        }

        private void btnClearRoom_Click(object sender, EventArgs e)
        {
            cbRoomType.SelectedIndex = 0;
            tbRoomFloor.Clear();
            tbRoomNo.Clear();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (cbRoomType.SelectedIndex == 0 ||
                tbRoomFloor.Text == "" ||
                tbRoomNo.Text == ""
                )
            {
                MessageBox.Show("Please Fill All Required Fields",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to add new room?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    roomBusiness.Add(new Entities.Room
                    {
                        RoomStatusId = 1,
                        RoomTypeId = Convert.ToInt32(cbRoomType.SelectedValue),
                        Floor = Convert.ToInt32(tbRoomFloor.Text),
                        RoomNo = Convert.ToInt32(tbRoomNo.Text)
                    });
                    dgvRoom.DataSource = roomBusiness.GetRooms();
                }
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            var items = roomBusiness.GetAll();
            foreach (var item in items)
            {
                if (item.RoomId == Convert.ToInt32(lblRoomId.Text))
                {
                    if (item.RoomStatusId == 3 || item.RoomStatusId == 4)
                    {
                        MessageBox.Show("You cannot remove this room. Because this room is either booked or someone is staying inside.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Do you want to remove this room?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            roomBusiness.Delete(Convert.ToInt32(lblRoomId.Text));
                            dgvRoom.DataSource = roomBusiness.GetRooms();
                        }
                    }
                }
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (cbRoomType.SelectedIndex == 0 ||
                tbRoomFloor.Text == "" ||
                tbRoomNo.Text == ""
                )
            {
                MessageBox.Show("Please Fill All Required Fields",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to update this room?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    roomBusiness.Update(new Entities.Room
                    {
                        RoomId = Convert.ToInt32(lblRoomId.Text),
                        RoomTypeId = Convert.ToInt32(cbRoomType.SelectedValue),
                        RoomStatusId = Convert.ToInt32(lblStatusId.Text),
                        Floor = Convert.ToInt32(tbRoomFloor.Text),
                        RoomNo = Convert.ToInt32(tbRoomNo.Text)
                    });
                    dgvRoom.DataSource = roomBusiness.GetRooms();
                }
            }
        }

        private void btnTakeToClean_Click(object sender, EventArgs e)
        {
            var items = roomBusiness.GetAll();
            foreach (var item in items)
            {
                if(item.RoomId == Convert.ToInt32(lblRoomId.Text))
                {
                    if (item.RoomStatusId == 2)
                    {
                        DialogResult dialogResult = MessageBox.Show("Do you want to change status to 'clean' for this room?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            roomBusiness.ChangeRoomStatus(Convert.ToInt32(lblRoomId.Text), 1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot change to 'clean' for this room Status. Because this room is either booked or someone is staying inside.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }  
            }
            dgvRoom.DataSource = roomBusiness.GetRooms();
        }
    }
}
