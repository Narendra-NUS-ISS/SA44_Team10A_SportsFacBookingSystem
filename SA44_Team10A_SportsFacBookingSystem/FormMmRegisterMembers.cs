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
    public partial class FormMmRegisterMembers : Form
    {
        BookingSystemEntities context = new BookingSystemEntities();
        bool isValidMemberName = false;
        bool isValidPhoneNumber = false;
        Home MainForm;
        public FormMmRegisterMembers()
        {
            InitializeComponent();
        }
        public FormMmRegisterMembers(Home MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
        }
        private void FormMmRegisterMembers_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Location = new System.Drawing.Point(430, 180);

            //Groupbox properties
            this.grpBoxMmRegisterMemeber.Location = new System.Drawing.Point(60, 37);
            this.grpBoxMmRegisterMemeber.Size = new System.Drawing.Size(280, 120);

            //Registration label properties
            this.lblMmRegMemberName.Size = new System.Drawing.Size(40, 20);
            this.lblMmRegPhone.Size = new System.Drawing.Size(40, 20);

            //Registration textbox properties
            this.txtMmRegMemberName.Size = new System.Drawing.Size(144, 20);
            this.txtMmRegPhone.Size = new System.Drawing.Size(144, 20);

            //Register button properties
            this.btnMmReg.Location = new System.Drawing.Point(60, 170);
            this.btnMmReg.Size = new System.Drawing.Size(280, 30);

            //Close button properties
            this.btnMmRegClose.Location = new System.Drawing.Point(60, 206);
            this.btnMmRegClose.Size = new System.Drawing.Size(280, 30);

            //Message label properties
            this.lblRegMessage.Location = new System.Drawing.Point(60, 240);
            this.lblRegMessage.Size = new System.Drawing.Size(280, 30);

            // disable register button on start
            btnMmReg.Enabled = false;
            btnMmReg.BackColor = Color.LightGray;
        }

        private void btnMmRegClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Register new member based on inputs
        private void btnMmReg_Click(object sender, EventArgs e)
        {

            Member member = new Member();
            member.MemberName = txtMmRegMemberName.Text;
            member.PhoneNo = txtMmRegPhone.Text;

            context.Members.Add(member);
            context.SaveChanges();
            lblRegMessage.Text =Constants.MEMBER_REGISTERED;
            MainForm.ViewRefresh();
            CleanTextBoxes();
        }

        // Restart form
        private void CleanTextBoxes()
        {
            txtMmRegMemberName.Text = "";
            txtMmRegPhone.Text = "";
            lblMmRegInvalidName.Text = "";
            lblMmRegInvalidPhone.Text = "";
        }

        // Change register button status according to inputs
        private void RegButtonStatus()
        {
            if (isValidMemberName && isValidPhoneNumber && ((!txtMmRegMemberName.Text.Trim().Equals(string.Empty)) && (!txtMmRegPhone.Text.Trim().Equals(string.Empty))))
            {
                btnMmReg.Enabled = true;
                btnMmReg.BackColor = Color.SteelBlue;
            }
            else
            {
                btnMmReg.Enabled = false;
                btnMmReg.BackColor = Color.LightGray;
            }
        }

        // Validate member name input 
        
        private void txtMmRegMemberName_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex("^[A-Za-z0-9]{1,20}$");
            if (!pattern.IsMatch(txtMmRegMemberName.Text))
            {
                lblMmRegInvalidName.Text = Constants.INVALID_MEM_NAME;
                isValidMemberName = false;
            }
            else
            {
                lblMmRegInvalidName.Text = "";
                isValidMemberName = true;
            }
            RegButtonStatus();
        }

        private void txtMmRegPhone_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"^\d[0-9]{7}$");
            if (!pattern.IsMatch(txtMmRegPhone.Text))
            {
                lblMmRegInvalidPhone.Text =Constants.INVALID_MEM_PHNO;
                isValidPhoneNumber = false;
            }
            else
            {
                List<String> phoneList = new List<String>(context.Members.Select(x => x.PhoneNo).ToList());
                if (phoneList.Contains(txtMmRegPhone.Text))
                {
                    lblMmRegInvalidPhone.Text =Constants.PHNO_EXISTS;
                    isValidPhoneNumber = false;
                }
                else
                {
                    lblMmRegInvalidPhone.Text = "";
                    isValidPhoneNumber = true;
                }
            }
            RegButtonStatus();
        }

        // Validate phone number input

    }
}
