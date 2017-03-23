using System;
using System.Collections;
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
    public partial class Home : Form
    {
        BookingSystemEntities entityContext;
        List<SlotAvailStructureTemplate_Procedure_Result> transactions = null;
        public static int transactionsCount = 0;
        public Home()
        {
            InitializeComponent();
            entityContext = new BookingSystemEntities();
            progressBar.Maximum = 10;
        }


        //Initial form load event handler
        private void Home_Load(object sender, EventArgs e)
        {
            statusLabel.Text = Constants.READY;
            progressBar.PerformStep();
            progressBar.Step = 10;
        }
       
        // Home tab event handler
        private void HomeLoadEvent(object sender, EventArgs e)
        {

        }

        // Manage members view mode event handler method
        private void ManageMembersLoadEventHandler(object sender, EventArgs e)
        {

        }

        // Manage mebers view mode screen event handler
        private void ManageFacilityLoadEventHandler(object sender, EventArgs e)
        {

        }

        // Manage booking/Cancellation/Search view mode screen event handler
        private void ManageBookingEventHandler(object sender, EventArgs e)
        {
            // Load combo box with facilites by fetching Facilities entity
            combo_FacilityName.Items.Clear();
            var query = entityContext.Facilities.Select(x => x.FacilityName).Distinct();
            combo_FacilityName.Items.AddRange(query.ToArray());

            // Date picker customization to facilitate only Future dates selection
            dateTimePicker_Facility.MinDate = DateTime.Today.AddDays(1);
            dateTimePicker_Facility.MaxDate = DateTime.Today.AddDays(10);
            
        }

        // Search button event handler to fetch & display the avalable slots in Grid
        public  void SearchFacilityEventHandler(object sender, EventArgs e)
        {
            // Read input fileds
            label3.Text = "";
            if ("" == combo_FacilityName.Text.ToString())
            {
                label3.Text = "Select the Facility";
            }
            String facilityName = combo_FacilityName.Text.Trim();
            DateTime bookingDate = dateTimePicker_Facility.Value;
            DateTime bookdateTime = new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day);
            try
            {
                // Retrive the booking transactions
                Ibooking bookings = new SlotBooking();
                transactions = bookings.GetSlotStructure(bookdateTime, facilityName);
                transactionsCount = transactions.Count;
            } catch(Exception exception)
            {
                statusLabel.Text = "Operation failed due to : " + exception.Message;
            }
            // Update Datagrid with booiking slot layout
            dataGridView_Facilities.DataSource = transactions;
            dataGridView_Facilities.ReadOnly = true;
            //statusLabel.Text = Constants.LOADED;

            //Access each & every cell & Add colour to cells
            for (int rowPosition = 0; rowPosition < transactions.Count; rowPosition++)
            {
                foreach (DataGridViewCell cell in dataGridView_Facilities.Rows[rowPosition].Cells)
                {
                    try
                    {
                        String cellcontent = (cell.Value == null ? "0" : cell.Value.ToString());
                        if (cellcontent.Equals("0"))
                        {
                            cell.Value = "Available";
                            cell.Style.BackColor = Color.Green;
                        }
                        else if (cellcontent.Contains("-"))
                        {
                                cell.Value = "Booked";
                                cell.Style.BackColor = Color.Red;
                        }
                    } catch(Exception exception)
                    {
                        statusLabel.Text = "Operation failed due to :" + exception.Message;
                    }
                }
            }
        }


        // Event handler for Booking & cancellation operations
        private void GetSlotDetailsEventHandler(object sender, DataGridViewCellEventArgs e)
        {
            progressBar.Step = 2;
            SlotAvailStructureTemplate_Procedure_Result result;
            if (e.RowIndex >= 0)
            {
                 result = transactions[e.RowIndex];
            } else
            {
                return;
            }

            //Retrieve the cell positions
            int slot = e.ColumnIndex + 5;
            String facilityName = result.FacilityName;
            String location = result.Location;
            DateTime bookingDate = dateTimePicker_Facility.Value;
            DateTime bookdateTime = new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day, slot,bookingDate.Minute,bookingDate.Second);
            Facility facility = entityContext.Facilities.Where(x => x.FacilityName == facilityName && x.Location == location).First();
            BookingTransaction booking = null;
            // validate against existing booking transactions
            try
            {
                 booking = entityContext.BookingTransactions.Where(x => x.FacilityId == facility.FacilityId && x.SlotTime == bookdateTime && x.Status == "Booked").First();
            }
            catch (Exception exception)
            {
              //  statusLabel.Text = "Operation failed due to " + exception.Message;
            }
            if( booking != null && slot == booking.SlotTime.Hour && booking.Status == "Booked")
            {
                // Cancellation
                try
                {
                    Cancellation cancelform = new Cancellation(facility.FacilityId, bookdateTime, facility.FacilityName, facility.Location);
                    cancelform.ShowDialog();
                    SearchFacilityEventHandler(sender, e);
                    statusLabel.Text = "Successfully Cancelled :" + slot + " Slot [" + location + " - " + facilityName + "]";
                    progressBar.Step = 10;
                } catch(Exception exception)
                {
                    statusLabel.Text = "Operation failed due to : " + exception.Message;
                }
            } else
            {
                if (slot > 5 && slot < 23)
                {
                    // Booking
                    String timeFrame = (slot > 12) ? "PM" : "AM";
                    progressBar.Step = 5;
                   Booking form = new Booking(slot.ToString() + timeFrame, location, facilityName, bookdateTime);
                   DialogResult dialogresult = form.ShowDialog();
                    String status = Booking.transactionStatus;
                    if(status == "SUCCESS")
                    {
                        progressBar.Step = 10;
                        statusLabel.Text = "Successfully booked :"+slot+timeFrame+ " Slot [" + location + " - " + facilityName+"]";
                        SearchFacilityEventHandler(sender, e);
                    }
                }
            }
        }





    }
}
