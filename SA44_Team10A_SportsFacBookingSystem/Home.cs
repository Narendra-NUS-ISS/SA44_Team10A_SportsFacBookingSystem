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
        public Home()
        {
            InitializeComponent();
            entityContext = new BookingSystemEntities();
        }


        //Initial form load event handler
        private void Home_Load(object sender, EventArgs e)
        {
            statusLabel.Text = Constants.READY;
            progressBar.PerformStep();
            progressBar.PerformStep();
            progressBar.PerformStep();
            progressBar.PerformStep();
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
            var query = entityContext.Facilities.Select(x => x.FacilityName).Distinct();
            combo_FacilityName.Items.AddRange(query.ToArray());

            // Date picker customization to facilitate only Future dates selection
            dateTimePicker_Facility.MinDate = DateTime.Today.AddDays(1);
            dateTimePicker_Facility.MaxDate = DateTime.Today.AddDays(10);


            
        }

        // Search button event handler to fetch & display the avalable slots in Grid
        private void SearchFacilityEventHandler(object sender, EventArgs e)
        {

            DateTime dateTime = new DateTime(2017, 03, 23);
            Object transaction1 =  entityContext.SlotAvailability_Procedure(dateTime,"6").First();
            Object transactions2 = entityContext.SlotAvailability_Procedure(dateTime, "7").First();
            //transactions.ToList().AddRange(transactions1.ToList());
            IList<Object> transactions = new List<Object>();
            transactions.Add(transaction1);
            transactions.Add(transactions2);
            dataGridView_Facilities.DataSource = transactions;
            dataGridView_Facilities.Rows[0].Cells[5].Style.BackColor = Color.Red;
            MessageBox.Show(dataGridView_Facilities[5, 0].Value.ToString());
        }
    }
}
