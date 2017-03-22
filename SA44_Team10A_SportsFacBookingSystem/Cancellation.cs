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
    public partial class Cancellation : Form
    {

        private int facilityId;
        private DateTime bookingDate;
        BookingSystemEntities entityContext = null;
        public Cancellation()
        {
            InitializeComponent();
        }

        public Cancellation(int facilityId, DateTime bookingDate, String facilityName, String location)
        {
            InitializeComponent();

            this.facilityId = facilityId;
            this.bookingDate = bookingDate;
            entityContext = new BookingSystemEntities();
            txtFacility.Text = facilityName;
            txtLocation.Text = location;
            txtSlot.Text = bookingDate.ToString();
        }

        private void CancelEventHandler(object sender, EventArgs e)
        {
            BookingTransaction booking = entityContext.BookingTransactions.Where(x => x.FacilityId == facilityId && x.SlotTime == bookingDate && x.Status=="Booked").First();
           // MessageBox.Show("Transaction Id :" + booking.TransactionId);
            booking.Status = "Cancelled";
            entityContext.SaveChanges();
            CloseEventHandler(sender, e);
        }

        private void CloseEventHandler(object sender, EventArgs e)
        {
            Cancellation.ActiveForm.Close();
        }
    }
}
