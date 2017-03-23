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
    public partial class FormMmUpdateMember : Form
    {
        BookingSystemEntities context = new BookingSystemEntities();
        bool isValidMemberName = false;
        bool isValidPhoneNumber = false;
        Home MainForm;
        String MemName;
        String PhoneNum;

        public FormMmUpdateMember()
        {
            InitializeComponent();
        }

        public FormMmUpdateMember(Home MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
        }

        private void FormMmUpdateMember_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Location = new System.Drawing.Point(430, 180);

            //Groupbox properties
            this.grpBoxMmUpdateMemeber.Location = new System.Drawing.Point(60, 37);
            this.grpBoxMmUpdateMemeber.Size = new System.Drawing.Size(280, 120);

            //Update label properties
            this.lblMmUpdateName.Size = new System.Drawing.Size(40, 20);
            this.lblMmUpdatePhone.Size = new System.Drawing.Size(40, 20);

            //Update textbox properties
            this.txtMmUpdateName.Size = new System.Drawing.Size(144, 20);
            this.txtMmUpdatePhone.Size = new System.Drawing.Size(144, 20);

            //Update button properties
            this.btnMmUpdate.Location = new System.Drawing.Point(60, 170);
            this.btnMmUpdate.Size = new System.Drawing.Size(280, 30);

            //Close button properties
            this.btnMmUpdateClose.Location = new System.Drawing.Point(60, 206);
            this.btnMmUpdateClose.Size = new System.Drawing.Size(280, 30);

            //Message label properties
            this.lblUpdateMessage.Location = new System.Drawing.Point(60, 240);
            this.lblUpdateMessage.Size = new System.Drawing.Size(280, 30);

            fillRowDetails();
        }

        // Fill textboxes with selected row values
        private void fillRowDetails()
        {
            MemName = MainForm.GetNameValue();
            txtMmUpdateName.Text = MemName;
            PhoneNum = MainForm.GetPhoneValue();
            txtMmUpdatePhone.Text = PhoneNum;
        }

        //Update member details based on inputs
        private void btnMmReg_Click(object sender, EventArgs e)
        {
            List<String> phoneList = context.Members.Select(x => x.PhoneNo).ToList();
            if (phoneList.Contains(txtMmUpdatePhone.Text))
            {
                lblMmRegInvalidPhone.Text = Constants.PHNO_EXISTS;
            }
            else
            {
                Member member = context.Members.Where(x => x.PhoneNo == PhoneNum).First();
                member.MemberName = txtMmUpdateName.Text;
                member.PhoneNo = txtMmUpdatePhone.Text;
                context.SaveChanges();

                lblUpdateMessage.Text =Constants.MEMBER_ADDED_SUCCESS;


                MainForm.ViewRefresh();
                btnMmUpdate.Enabled = false;
                btnMmUpdate.BackColor = Color.LightGray;
            }
        }

        private void btnMmRegClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Change submit button status according to inputs
        private void ButtonStatus()
        {
            if (isValidMemberName && isValidPhoneNumber && ((!txtMmUpdateName.Text.Trim().Equals(string.Empty)) && (!txtMmUpdatePhone.Text.Trim().Equals(string.Empty))))
            {
                btnMmUpdate.Enabled = true;
                btnMmUpdate.BackColor = Color.SteelBlue;
            }
            else
            {
                btnMmUpdate.Enabled = false;
                btnMmUpdate.BackColor = Color.LightGray;
            }
        }

        // Validate member name input 
        private void txtMmRegMemberName_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex("^[A-Za-z0-9]{1,20}$");
            if (!pattern.IsMatch(txtMmUpdateName.Text))
            {
                lblMmRegInvalidName.Text = Constants.INVALID_MEM_NAME;
                isValidMemberName = false;
            }
            else
            {
                lblMmRegInvalidName.Text = "";
                isValidMemberName = true;
            }
            ButtonStatus();
        }

        // Validate phone number input
        private void txtMmRegPhone_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^\d[0-9]{7}$");
            if (!pattern.IsMatch(txtMmUpdatePhone.Text))
            {
                lblMmRegInvalidPhone.Text =Constants.INVALID_MEM_PHNO;
                isValidPhoneNumber = false;
            }
            else
            {
                lblMmRegInvalidPhone.Text = "";
                isValidPhoneNumber = true;
            }
            ButtonStatus();
        }
    }
}
