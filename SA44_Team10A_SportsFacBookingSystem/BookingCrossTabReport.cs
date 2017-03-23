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
    public partial class BookingCrossTabReport : Form
    {
        public BookingCrossTabReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                BookingDataSet ds = new BookingDataSet();

                BookingDataSetTableAdapters.FacilityBookingCount_viewTableAdapter dateVsBookingCountReport = new BookingDataSetTableAdapters.FacilityBookingCount_viewTableAdapter();
                dateVsBookingCountReport.Fill(ds.FacilityBookingCount_view);
                CRBookCrossTabascrossFacilitiesReport report = new CRBookCrossTabascrossFacilitiesReport();
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
