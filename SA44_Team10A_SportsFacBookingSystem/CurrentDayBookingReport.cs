using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA44_Team10A_SportsFacBookingSystem
{
    public partial class CurrentDayBookingReport : Form
    {
        public CurrentDayBookingReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                BookingDataSet ds = new BookingDataSet();

                BookingDataSetTableAdapters.FacilityTableAdapter fa = new BookingDataSetTableAdapters.FacilityTableAdapter();
                BookingDataSetTableAdapters.CurrentDayBookingsReport_ViewTableAdapter dailyBookReport = new BookingDataSetTableAdapters.CurrentDayBookingsReport_ViewTableAdapter();
                BookingDataSetTableAdapters.DateVsBookingsCountReport_ViewTableAdapter dateVsBookingCountReport = new BookingDataSetTableAdapters.DateVsBookingsCountReport_ViewTableAdapter();
                dailyBookReport.Fill(ds.CurrentDayBookingsReport_View);
                dateVsBookingCountReport.Fill(ds.DateVsBookingsCountReport_View);
                fa.Fill(ds.Facility);
                CRCurrentDayBookingReport report = new CRCurrentDayBookingReport();
                report.SetDataSource(ds);
                crystalReportViewer1.ReportSource = report;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
