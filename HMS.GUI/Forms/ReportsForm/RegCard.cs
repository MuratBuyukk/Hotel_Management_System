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
    public partial class RegCard : Form
    {
        public RegCard()
        {
            InitializeComponent();
        }

        private void RegCard_Load(object sender, EventArgs e)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            localReport.ReportPath = "Reports/RegCard.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
