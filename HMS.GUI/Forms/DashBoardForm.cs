using HMS.Business.Repository.Concrete;
using HMS.Entities;
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
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }
        HotelManagementSystemEntities db = new HotelManagementSystemEntities();
        RoomBusiness roomBusiness = new RoomBusiness();
        BookingBusiness bookingBusiness = new BookingBusiness();
            
        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            int reservedRoom = roomBusiness.NumberOfRooms(4);
            int fullRoom = roomBusiness.NumberOfRooms(3);
            int emptyRoom = roomBusiness.NumberOfRooms(2) + roomBusiness.NumberOfRooms(1);
            lblReservedRoom.Text = reservedRoom.ToString();
            lblFullRoom.Text = fullRoom.ToString();
            lblEmptyRoom.Text = emptyRoom.ToString();
            lblTotalRoom.Text = db.Rooms.Count().ToString();
            lblSingleBooking.Text = bookingBusiness.NumberOfLists(1, 1).ToString();
            lblSingleAccommodation.Text = bookingBusiness.NumberOfLists(1, 2).ToString();
            lblSingleDeparted.Text = bookingBusiness.NumberOfLists(1, 3).ToString();
            lblTotalBooking.Text = bookingBusiness.NumberOfTotals(1).ToString();
            lblDoubleBooking.Text = bookingBusiness.NumberOfLists(2, 1).ToString();
            lblDoubleAccommodation.Text = bookingBusiness.NumberOfLists(2, 2).ToString();
            lblDoubleDeparted.Text =  bookingBusiness.NumberOfLists(2, 3).ToString();
            lblTotalAccommodation.Text = bookingBusiness.NumberOfTotals(2).ToString();
            lblTwinBooking.Text = bookingBusiness.NumberOfLists(3, 1).ToString();
            lblTwinAccommodation.Text = bookingBusiness.NumberOfLists(3, 2).ToString();
            lblTwinDeparted.Text = bookingBusiness.NumberOfLists(3, 3).ToString();
            lblTotalDeparted.Text = bookingBusiness.NumberOfTotals(3).ToString();
        }

        private void btnRoomReport_Click(object sender, EventArgs e)
        {
            RoomTypesTotalForm reportMainForm = new RoomTypesTotalForm();
            reportMainForm.Show();
        }

        private void btnBookingReport_Click(object sender, EventArgs e)
        {
            ReportByBookingForm reportByBookingForm = new ReportByBookingForm();
            reportByBookingForm.Show();
        }

        private void btnAccomodationReport_Click(object sender, EventArgs e)
        {
            ReportByAccommadationForm reportByAccommadationForm = new ReportByAccommadationForm();
            reportByAccommadationForm.Show();
        }

        private void btnDepartedReport_Click(object sender, EventArgs e)
        {
            ReportByDepartedForm reportByDepartedForm = new ReportByDepartedForm();
            reportByDepartedForm.Show();
        }
    }
}
