using HMS.Business.Repository.Concrete;
using HMS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.GUI.Forms.ReportsForm
{
    public partial class UpdateBookingForm : Form
    {
        public int bookingIdUpdate;
        int roomIdUpdate;
        DateTime cinDateUpdate;
        DateTime coutDateUpdate;
        int totalNightUpdate;
        decimal dailyPriceUpdate;
        decimal totalRoomChargeUpdate;
        int bookingStatusIdUpdate;
        public int guestIdUpdate;
        int userIdUpdate;
        string guestNameUpdate;
        string guestLastNameUpdate;
        string guestTelnoUpdate;
        string guestEmailUpdate;
        string guestNationalityUpdate;
        string guestPassaportUpdate;
        
        public UpdateBookingForm()
        {
            InitializeComponent();
        }

        BookingBusiness bookingBusiness = new BookingBusiness();
        GuestBussiness guestBussiness = new GuestBussiness();
        UserBusiness userBusiness = new UserBusiness();
        private void UpdateBookingForm_Load(object sender, EventArgs e)
        {
            foreach (var b in bookingBusiness.GetAll())
            {
                if(b.BookingId == bookingIdUpdate)
                {
                    roomIdUpdate = (int)b.RoomId;
                    cinDateUpdate = b.CinDate;
                    coutDateUpdate = b.CoutDate;
                    totalNightUpdate = (int)b.TotalNight;
                    dailyPriceUpdate = b.DailyPrice;
                    totalRoomChargeUpdate = (decimal)b.TotalRoomCharge;
                    bookingStatusIdUpdate = b.BookingStatusId;
                    guestIdUpdate = b.GuestId;
                    userIdUpdate = b.UserId;
                }
            }
            foreach (var g in guestBussiness.GetAll())
            {
                if(g.GuestId == guestIdUpdate)
                {
                    guestNameUpdate = g.GuestName;
                    guestLastNameUpdate = g.GuestLastName;
                    guestTelnoUpdate = g.GuestTelNo;
                    guestEmailUpdate = g.GuestEmail;
                    guestNationalityUpdate = g.GuestNationality;
                    guestPassaportUpdate = g.GuestPassaport;
                }
            }
            
            tbTotalNight.Text = totalNightUpdate.ToString();
            tbPrice.Text = dailyPriceUpdate.ToString();
            dtpCin.Value = cinDateUpdate;
            dtpCout.Value = coutDateUpdate;
            tbGuestName.Text = guestNameUpdate;
            tbGuestLastName.Text = guestLastNameUpdate;
            tbGuestTelNo.Text = guestTelnoUpdate;
            tbGuestEmail.Text = guestEmailUpdate;
            cbGuestNationality.SelectedItem = guestNationalityUpdate;
            tbGuestPassaportNo.Text = guestPassaportUpdate;
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            if (tbGuestName.Text == ""
                            || tbGuestLastName.Text == ""
                            || tbGuestTelNo.Text == ""
                            || tbGuestEmail.Text == ""
                            || cbGuestNationality.SelectedIndex == 0
                            || tbGuestPassaportNo.Text == ""
                            || tbTotalNight.Text == ""
                            || tbPrice.Text == "")
            {
                MessageBox.Show("Please Fill All Required Fields",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to update this reservation?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    guestBussiness.Update(new Guest
                    {
                        GuestId = guestIdUpdate,
                        GuestName = tbGuestName.Text,
                        GuestLastName = tbGuestLastName.Text,
                        GuestTelNo = tbGuestTelNo.Text,
                        GuestEmail = tbGuestEmail.Text,
                        GuestNationality = cbGuestNationality.Text,
                        GuestPassaport = tbGuestPassaportNo.Text
                    });
                    bookingBusiness.Update(new Booking
                    {
                        BookingId= bookingIdUpdate,
                        RoomId = roomIdUpdate,
                        CinDate = Convert.ToDateTime(dtpCin.Value),
                        CoutDate = Convert.ToDateTime(dtpCout.Value),
                        TotalNight = Convert.ToInt32(tbTotalNight.Text),
                        DailyPrice = Convert.ToDecimal(tbPrice.Text),
                        TotalRoomCharge = Convert.ToInt32(tbTotalNight.Text) * Convert.ToDecimal(tbPrice.Text),
                        BookingStatusId = bookingStatusIdUpdate,
                        GuestId = guestIdUpdate,
                        UserId = userBusiness.ActiveUserID(),
                    });
                    tbGuestName.Clear();
                    tbGuestLastName.Clear();
                    tbGuestTelNo.Clear();
                    tbGuestEmail.Clear();
                    cbGuestNationality.SelectedIndex = 0;
                    tbGuestPassaportNo.Clear();
                    tbTotalNight.Clear();
                    tbPrice.Clear();
                    dtpCin.Value = DateTime.Now;
                    dtpCout.Value = DateTime.Now;
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }
    }
}
