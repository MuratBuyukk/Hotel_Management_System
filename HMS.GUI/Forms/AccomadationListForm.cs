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
    public partial class AccomadationListForm : Form
    {
        UpdateBookingForm updateBookingForm;
        int bookingIdValue;
        int roomIdValue;
        int guestIdValue;
        public AccomadationListForm()
        {
            InitializeComponent();
        }
        BookingBusiness bookingBusiness = new BookingBusiness();
        RoomBusiness roomBusiness = new RoomBusiness();
        private void bindAccomadation()
        {
            var accomadations = bookingBusiness.GetAcommadationList();
            dgvBooking.DataSource = accomadations;
            dgvBooking.Cursor = Cursors.Default;
        }

        private void AccomadationListForm_Load(object sender, EventArgs e)
        {
            bindAccomadation();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            bookingBusiness.ChangeBookingStatus(bookingIdValue, 3);
            roomBusiness.ChangeRoomStatus(roomIdValue, 2);
            dgvBooking.DataSource = bookingBusiness.GetAcommadationList();
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
            bindAccomadation();
        }
    }
}
