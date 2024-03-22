using HMS.Business.Repository.Concrete;
using HMS.Entities;
using HMS.GUI.Forms.ReportsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.GUI.Forms
{
    public partial class CreateBookingForm : Form
    {
        public CreateBookingForm()
        {
            InitializeComponent();
            cbGuestNationality.SelectedIndex = -1;
            bindRoom();
        }
        

        GuestBussiness guestBussiness = new GuestBussiness();
        RoomBusiness roomBusiness = new RoomBusiness();
        BookingBusiness bookingBusiness = new BookingBusiness();
        UserBusiness userBusiness = new UserBusiness();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbGuestName.Text == ""
                            || tbGuestLastName.Text == ""
                            || tbGuestTelNo.Text == ""
                            || tbGuestEmail.Text == ""
                            || cbGuestNationality.SelectedIndex == 0
                            || tbGuestPassaportNo.Text == ""
                            || cbRoom.SelectedIndex == -1
                            || tbTotalNight.Text == ""
                            || tbPrice.Text == "")
            {
                MessageBox.Show("Please Fill All Required Fields",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to open a new reservation?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    guestBussiness.Add(new Guest
                    {
                        GuestName = tbGuestName.Text,
                        GuestLastName = tbGuestLastName.Text,
                        GuestTelNo = tbGuestTelNo.Text,
                        GuestEmail = tbGuestEmail.Text,
                        GuestNationality = cbGuestNationality.Text,
                        GuestPassaport = tbGuestPassaportNo.Text
                    });
                    bookingBusiness.Add(new Booking
                    {
                        RoomId = Convert.ToInt32(cbRoom.SelectedValue),
                        CinDate = Convert.ToDateTime(dtpCin.Value),
                        CoutDate = Convert.ToDateTime(dtpCout.Value),
                        TotalNight = Convert.ToInt32(tbTotalNight.Text),
                        DailyPrice = Convert.ToDecimal(tbPrice.Text),
                        TotalRoomCharge = Convert.ToInt32(tbTotalNight.Text) * Convert.ToDecimal(tbPrice.Text),
                        BookingStatusId = 1,
                        GuestId = guestBussiness.LastGuestId(),
                        UserId = userBusiness.ActiveUserID(),
                    }); 
                    int roomid = Convert.ToInt32(cbRoom.SelectedValue);
                    roomBusiness.ChangeRoomStatus(roomid,4);
                    tbGuestName.Clear();
                    tbGuestLastName.Clear();
                    tbGuestTelNo.Clear();
                    tbGuestEmail.Clear();
                    cbGuestNationality.SelectedIndex = 0;
                    tbGuestPassaportNo.Clear();
                    cbRoom.SelectedIndex = 0;
                    tbTotalNight.Clear();
                    tbPrice.Clear();
                    dtpCin.Value = DateTime.Now;
                    dtpCout.Value = DateTime.Now;

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

        }
        private void bindRoom()
        {
            var rooms = roomBusiness.getAvailableRoom();
            cbRoom.DataSource = rooms;
            cbRoom.DisplayMember = "RoomNo";
            cbRoom.ValueMember = "RoomId";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RegCard regCard = new RegCard();
            regCard.Show();
        }
    }
}

