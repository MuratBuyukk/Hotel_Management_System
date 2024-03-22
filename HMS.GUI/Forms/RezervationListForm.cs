using HMS.Business.Repository.Concrete;
using HMS.GUI.Forms.ReportsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.GUI.Forms
{
    public partial class RezervationListForm : Form
    {
        UpdateBookingForm updateBookingForm;
        int bookingIdValue;
        int roomIdValue;
        int guestIdValue;
        public RezervationListForm()
        {
            InitializeComponent();
        }

        BookingBusiness bookingBusiness = new BookingBusiness();
        RoomBusiness roomBusiness = new RoomBusiness();

        private void bindBooking()
        {
            var bookings = bookingBusiness.GetRezervationList();
            dgvBooking.DataSource = bookings;
            dgvBooking.Cursor= Cursors.Default;
        }

        private void RezervationListForm_Load(object sender, EventArgs e)
        {
            bindBooking();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            bookingBusiness.ChangeBookingStatus(bookingIdValue,2);
            roomBusiness.ChangeRoomStatus(roomIdValue,3);
            dgvBooking.DataSource = bookingBusiness.GetRezervationList();
        }

        private void dgvBooking_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvBooking.Rows[e.RowIndex];
            bookingIdValue = (int)selectedRow.Cells["BookingId"].Value;
            roomIdValue = (int)selectedRow.Cells["RoomId"].Value;
            guestIdValue = (int)selectedRow.Cells["GuestId"].Value;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateBookingForm = new UpdateBookingForm();
            updateBookingForm.bookingIdUpdate = bookingIdValue;
            updateBookingForm.guestIdUpdate = guestIdValue;
            updateBookingForm.Owner = this;
            updateBookingForm.Show();
            
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            bindBooking();
        }
    }
}
