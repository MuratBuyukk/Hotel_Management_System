using HMS.Business.Repository.Concrete;
using HMS.Entities;
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

namespace HMS.GUI.Forms
{
    public partial class RoomTypesTotalForm : Form
    {
        public RoomTypesTotalForm()
        {
            InitializeComponent();
        }

        RoomBusiness roomBusiness = new RoomBusiness();
        private void ReportMainForm_Load(object sender, EventArgs e)
        {
            HMSDataSet hmsDataSet = new HMSDataSet();
            
            foreach (var t in roomBusiness.GetRoomTypesTotal())
            {
                hmsDataSet.RoomTypesTotal.AddRoomTypesTotalRow(t.RoomTypeName, (int)t.NumberOfRoom);
            }

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            localReport.ReportPath = "Reports/RoomTypesTotal.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("HMSDataSet");
            reportDataSource.Name = "HMSDataSet";
            reportDataSource.Value = hmsDataSet.RoomTypesTotal;
            localReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
 
    }
}
