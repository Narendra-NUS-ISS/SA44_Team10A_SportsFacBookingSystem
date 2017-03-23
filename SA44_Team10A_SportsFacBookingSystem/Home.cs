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
        FormMmRegisterMembers RegisterForm;
        FormMmUpdateMember UpdateForm;
        FormRegisterNewFacility registerFacilityForm;
        String username;
        FormLogOut formLogout;
        public Home(String userName)
        {
            this.username = userName;
            InitializeComponent();
            lblHomeUserName.Text = username;
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
           // FillUserName();
        }

       
        // Manage members view mode event handler method
        private void ManageMembersEventHandler(object sender, EventArgs e)
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


        private void SearchMembersInfo(object sender, EventArgs e)
        {

        }

        private void btnMmRegisterMember_Click(object sender, EventArgs e)
        {

        }

        //********************************* Member Functions*****************************

        private void fillColumn()
        {
            if (dataGridMmViewMembers.ColumnCount < 3)
            {
                // Datagrid Column of Buttons 
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Width = 40;
                btnColumn.DefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
                btnColumn.Text = "Edit";
                btnColumn.UseColumnTextForButtonValue = true;
                dataGridMmViewMembers.Columns.Add(btnColumn);

                // Insert dummy column
                DataGridViewTextBoxColumn dummy = new DataGridViewTextBoxColumn();
                dummy.Width = 20;
                dataGridMmViewMembers.Columns.Add(dummy);
            }
        }

        // Refresh datadrid view
        public void ViewRefresh()
        {
            this.dataGridMmViewMembers.DataSource = entityContext.Members.Select
                (x => new { x.MemberName, x.PhoneNo }).ToList();

            this.dataGridMmViewMembers.Rows[0].Cells[0].Selected = false; // Removes row highlight upon load
            fillColumn();
        }

        public string GetNameValue()
        {
            return dataGridMmViewMembers.CurrentRow.Cells["MemberName"].Value.ToString();
        }

        public string GetPhoneValue()
        {
            return dataGridMmViewMembers.CurrentRow.Cells["PhoneNo"].Value.ToString();
        }

        private void tabControl_Home_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_Home.SelectedIndex == 0)
            {
                lblHomeUserName.Text = username;
            }
            else if (tabControl_Home.SelectedIndex == 1)
            {
                ViewRefresh();
                this.dataGridMmViewMembers.Size = new System.Drawing.Size(600, 330);
                dataGridMmViewMembers.AutoGenerateColumns = false;
                dataGridMmViewMembers.Columns["MemberName"].Width = 262;
                dataGridMmViewMembers.Columns["PhoneNo"].Width = 260;               
            }
               else if(tabControl_Home.SelectedIndex == 2)
            {
                RefreshFacilityTable();
            }
        }


        public void RefreshFacilityTable()
        {
            dataGridFacility.DataSource = entityContext.Facilities.Select(x => new { x.FacilityName, x.Location }).ToList();
        }

        private void btnMmSearchMembers_Click(object sender, EventArgs e)
        {

            if (txtMmSearchMembers.Text.Trim().Equals(String.Empty))
            {
                ViewRefresh();
                lblSearchError.Text = "";
            }
            else
            {

                int query = entityContext.Members.Where
                    (x => x.MemberName == txtMmSearchMembers.Text.Trim()).Count();

                if (query > 0)
                {
                    dataGridMmViewMembers.DataSource = entityContext.Members.Where
                   (x => x.MemberName == txtMmSearchMembers.Text.Trim()).Select
                   (x => new { x.MemberName, x.PhoneNo }).ToList();
                    lblSearchError.Text = "";
                }
                else
                {
                    dataGridMmViewMembers.DataSource = null;
                    lblSearchError.Text = "No records found";
                }
            }
        }

        private void btnMmRegisterMember_Click_1(object sender, EventArgs e)
        {

            if (RegisterForm == null)
            {
                RegisterForm = new FormMmRegisterMembers(this);
                RegisterForm.Show();
                                
                RegisterForm.FormClosed += RegisterForm_FormClosed; 
            }
            else RegisterForm.Activate();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegisterForm = null;
        }

        private void dataGridMmViewMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateForm = new FormMmUpdateMember(this);
            UpdateForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!txtSearchFacility.Text.Trim().Equals(String.Empty))
            {
                int count = entityContext.Facilities.Where(x => x.FacilityName == txtSearchFacility.Text).Count();
                if (count > 0)
                {
                    dataGridFacility.DataSource = entityContext.Facilities.Where(x => x.FacilityName == txtSearchFacility.Text).Select(x => new { x.FacilityName, x.Location }).ToList();
                    lblSearchError.Text = "";
                }
                else
                {
                    lblSearchError.Text = "No Records Found";
                    dataGridFacility.DataSource = null;
                }
            }
            else
            {
                lblSearchError.Text = "";
                RefreshFacilityTable();
            }
        }

        private void btnRegisterFacility_Click(object sender, EventArgs e)
        {

            if (registerFacilityForm == null)
            {
                registerFacilityForm = new FormRegisterNewFacility(this);
                registerFacilityForm.Show();
                registerFacilityForm.FormClosed += RegisterFacilityForm_FormClosed;
            }
            else
            {
                registerFacilityForm.Activate();
            }
        }

        private void RegisterFacilityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            registerFacilityForm = null;
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            if (formLogout == null)
            {
                formLogout = new FormLogOut();
                formLogout.Show();

                formLogout.FormClosed += FormLogout_FormClosed;
            }
            else
            {
                formLogout.Activate();
            }
        }

        private void FormLogout_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogout = null;
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
                CRBookingCountVsDateReport report = new CRBookingCountVsDateReport();
                report.SetDataSource(ds);
                crystalReportViewer1.ReportSource = report;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentDayBookingReport form = new CurrentDayBookingReport();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LocationCountbyFacilityReport form = new LocationCountbyFacilityReport();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookingCrossTabReport form = new BookingCrossTabReport();
            form.Show();
        }
    }
}
