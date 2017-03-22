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
        IList<SlotAvailStructureTemplate_Procedure_Result> transactions = null;
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
            progressBar.PerformStep();
            progressBar.PerformStep();
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
            String facilityName = combo_FacilityName.Text.Trim();
            DateTime bookingDate = dateTimePicker_Facility.Value;
            DateTime dateTime = new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day);

            // Retrive the booking transactions
             transactions = new List<SlotAvailStructureTemplate_Procedure_Result>();

            List<Facility> facilities = entityContext.Facilities.Where(x => x.FacilityName == facilityName).ToList();
            
            foreach (Facility facility in facilities)
            {
                SlotAvailStructureTemplate_Procedure_Result transaction = null;
                try
                {
                    transaction =  entityContext.SlotAvailStructureTemplate_Procedure(dateTime, facility.FacilityId.ToString()).First();
                    if (null != transaction)
                    {

                        transactions.Add(transaction);
                    }
                }
                catch(Exception exception)
                {
                    SlotAvailStructureTemplate_Procedure_Result blankTransaction = new SlotAvailStructureTemplate_Procedure_Result();
                    blankTransaction.Location = facility.Location;
                    blankTransaction.Slot_10AM = "0";
                    blankTransaction.Slot_11AM = "0";
                    blankTransaction.Slot_12AM = "0";
                    blankTransaction.Slot_13PM = "0";
                    blankTransaction.Slot_14PM = "0";
                    blankTransaction.Slot_15PM = "0";
                    blankTransaction.Slot_16PM = "0";
                    blankTransaction.Slot_17PM = "0";
                    blankTransaction.Slot_18PM = "0";
                    blankTransaction.Slot_19PM = "0";
                    blankTransaction.Slot_20PM = "0";
                    blankTransaction.Slot_21PM = "0";
                    blankTransaction.Slot_21PM = "0";
                    blankTransaction.Slot_22PM = "0";
                    blankTransaction.Slot_6AM = "0";
                    blankTransaction.Slot_7AM = "0";
                    blankTransaction.Slot_8AM = "0";
                    blankTransaction.Slot_9AM = "0";
                    blankTransaction.FacilityName = facility.FacilityName;

                    transactions.Add(blankTransaction);
                   
                }
                
            }
            transactionsCount = transactions.Count;
            dataGridView_Facilities.DataSource = transactions;
            dataGridView_Facilities.ReadOnly = true;

            //Access each & every cell & Add colour to cells
            for (int rowPosition = 0; rowPosition < transactions.Count; rowPosition++)
            {
                foreach (DataGridViewCell cell in dataGridView_Facilities.Rows[rowPosition].Cells)
                {
                    try
                    {
                        //String cellcontent = cell.Value.ToString().Trim();

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
                        //  MessageBox.Show(c.Value.ToString());
                    } catch(Exception exception)
                    {

                    }
                }
            }



        }

        private void GetSlotDetailsEventHandler(object sender, DataGridViewCellEventArgs e)
        {
            progressBar.Step = 2;
            SlotAvailStructureTemplate_Procedure_Result result;
            //MessageBox.Show("Column :"+e.ColumnIndex+"   Row :"+e.RowIndex);
            if (e.RowIndex >= 0)
            {
                 result = transactions[e.RowIndex];
            } else
            {
                return;
            }
            int slot = e.ColumnIndex + 5;
            String facilityName = result.FacilityName;
            String location = result.Location;
            DateTime bookingDate = dateTimePicker_Facility.Value;
            DateTime bookdateTime = new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day, slot,bookingDate.Minute,bookingDate.Second);

           // MessageBox.Show("Facility :"+ result.FacilityName +" \n Location :"+result.Location+"\n  Slot :"+slot +"\n Date  :"+ bookdateTime);

            Facility facility = entityContext.Facilities.Where(x => x.FacilityName == facilityName && x.Location == location).First();
            BookingTransaction booking = null;
            try
            {
                 booking = entityContext.BookingTransactions.Where(x => x.FacilityId == facility.FacilityId && x.SlotTime == bookdateTime && x.Status == "Booked").First();
                
            }
            catch (Exception exception)
            {
               // exception.Message;
            }
            if( booking != null && slot == booking.SlotTime.Hour && booking.Status == "Booked")
            {
                Cancellation cancelform = new Cancellation(facility.FacilityId, bookdateTime, facility.FacilityName,facility.Location);
                cancelform.ShowDialog();
                SearchFacilityEventHandler(sender, e);
            } else
            {
                //  MessageBox.Show("Proceed to book");
                if (slot > 5 && slot < 23)
                {
                    String timeFrame = (slot > 12) ? "PM" : "AM";
                    progressBar.Step = 5;
                    Booking form = new Booking(slot.ToString() + timeFrame, location, facilityName, bookdateTime, dataGridView_Facilities);
                   DialogResult dialogresult = form.ShowDialog();
                    String status = Booking.transactionStatus;
                    if(status == "SUCCESS")
                    {
                        progressBar.Step = 10;
                        statusLabel.Text = "Successfully booked :"+slot+timeFrame+ " Slot [" + location + " - " + facilityName+"]";

                        //dataGridView_Facilities.Refresh();
                        SearchFacilityEventHandler(sender, e);
                    }
                }
                //dataGridView_Facilities.Refresh();
            }

            //String result = prompt.DialogResult.ToString() == "OK" ? textBox.Text : "";
            
           // dataGridView_Facilities.Refresh();
        }
    }
}
