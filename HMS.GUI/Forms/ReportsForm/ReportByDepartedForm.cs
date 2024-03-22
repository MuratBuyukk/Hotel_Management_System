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
    public partial class ReportByDepartedForm : Form
    {
        public ReportByDepartedForm()
        {
            InitializeComponent();
        }

        BookingBusiness bookingBusiness = new BookingBusiness();
        private void ReportByDepartedForm_Load(object sender, EventArgs e)
        {

            HMSDataSet hmsDataSet = new HMSDataSet();

            foreach (var d in bookingBusiness.GetReportByDepartedReport())
            {
                hmsDataSet.RoomTypeReportByDeparted.AddRoomTypeReportByDepartedRow(d.RoomTypeName, (int)d.NumberOfDeparted);
            }

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            localReport.ReportPath = "Reports/ReportByDeparted.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("HMSDataSet");
            reportDataSource.Name = "HMSDataSet";
            reportDataSource.Value = hmsDataSet.RoomTypeReportByDeparted;
            localReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
