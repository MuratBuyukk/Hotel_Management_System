using HMS.Business.Repository.Concrete;
using HMS.GUI.Datasets;
using Microsoft.Reporting.WinForms;
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
    public partial class ReportByBookingForm : Form
    {
        public ReportByBookingForm()
        {
            InitializeComponent();
        }

        BookingBusiness bookingBusiness = new BookingBusiness();
        private void ReportByBookingForm_Load(object sender, EventArgs e)
        {
            HMSDataSet hmsDataSet = new HMSDataSet();

            foreach (var b in bookingBusiness.GetReportByBookingReport())
            {
                hmsDataSet.RoomTypeReportByBooking.AddRoomTypeReportByBookingRow(b.RoomTypeName, (int)b.NumberOfBookings);
            }

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            localReport.ReportPath = "Reports/ReportByBooking.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("HMSDataSet");
            reportDataSource.Name = "HMSDataSet";
            reportDataSource.Value = hmsDataSet.RoomTypeReportByBooking;
            localReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
