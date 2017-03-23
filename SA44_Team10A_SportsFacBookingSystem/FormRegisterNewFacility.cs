using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA44_Team10A_SportsFacBookingSystem
{
    public partial class FormRegisterNewFacility : Form
    {
        BookingSystemEntities context;
        bool isValidFacilityName = false;
        bool isValidLocationName = false;
        private Home homeForm;

        public FormRegisterNewFacility()
        {
        }

        public FormRegisterNewFacility(Home HomeForm)
        {
            InitializeComponent();
            context = new BookingSystemEntities();
            btnRegister.Enabled = false;
            this.homeForm = HomeForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpBoxNewFacility_Enter(object sender, EventArgs e)
        {

        }

        //when the register button is clicked
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!txtFacilityName.Text.Equals(String.Empty)&& !txtLocation.Text.Equals(String.Empty))
            {
                Facility facility = new Facility();
                facility.FacilityName = txtFacilityName.Text.Trim();
                facility.Location = txtLocation.Text.Trim();
                context.Facilities.Add(facility);
                context.SaveChanges();            
                lblRegisterFacilityStatus.Text =Constants.FACILITY_ADD_SUCCESS;
                lblRegisterFacilityStatus.ForeColor = Color.ForestGreen;
                setDefaultValuesToTextBoxes();
                homeForm.RefreshFacilityTable();
            }
                      
        }

        //To reset the values to empty once a new facility is registered.
        private void setDefaultValuesToTextBoxes()
        {
            txtFacilityName.Text = "";
            txtLocation.Text = "";
        }

        //when the facility textbox is changed
        private void txtFacilityName_TextChanged(object sender, EventArgs e)
        {
            if (!txtFacilityName.Text.Equals(String.Empty))
            {
                Regex pattern = new Regex("^[a-zA-Z0-9 ]{1,30}$");
                if (!pattern.IsMatch(txtFacilityName.Text))
                {
                    lblFacilityError.Text = Constants.FACILITY_NAME_ALERT;
                    lblFacilityError.ForeColor = Color.Red;
                    isValidFacilityName = false;
                }
                else
                {
                    lblFacilityError.Text = "";
                    isValidFacilityName = true;
                }
            }
            enableDisableRegisterButton();
        }

        //when location text is changed
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (!txtLocation.Text.Equals(String.Empty)){
                Regex pattern = new Regex("^[a-zA-Z0-9 ]{1,30}$");
                if (!pattern.IsMatch(txtLocation.Text))
                {
                    lblLocationError.Text = Constants.LOCATION_ALERT;
                    lblLocationError.ForeColor = Color.Red;
                    isValidLocationName = false;
                }
                else
                {
                    lblLocationError.Text = "";
                    isValidLocationName = true;
                }
            }
            enableDisableRegisterButton();
        }

        //To enanble and disable register button
        private void enableDisableRegisterButton()
        {
            if (isValidFacilityName && isValidLocationName && !txtFacilityName.Text.Trim().Equals(String.Empty) && !txtLocation.Text.Trim().Equals(String.Empty))
            {
                btnRegister.Enabled = true;
                btnRegister.BackColor = Color.SteelBlue;
                btnRegister.ForeColor = Color.White;
            }
            else
            {
                btnRegister.Enabled = false;
                btnRegister.BackColor = Color.Gray;
                btnRegister.ForeColor = Color.DimGray;
            }
        }
    }
}
