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
    public partial class Booking : Form
    {
        private String slot;
        private String location;
        private String facilityName;
        private  DateTime bookingDate;
        BookingSystemEntities entityContext;
        public static String transactionStatus="";
        public string Slot
        {
            get
            {
                return slot;
            }

            set
            {
                slot = value;
            }
        }

        public string Location1
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public string FacilityName
        {
            get
            {
                return facilityName;
            }

            set
            {
                facilityName = value;
            }
        }


        public Booking()
        {
            InitializeComponent();
        }

        public Booking(String slot, String location, String facilityName, DateTime bookingDate)
        {
            InitializeComponent();
            this.slot = slot;
            this.location = location;
            this.facilityName = facilityName;
            this.bookingDate = bookingDate;

            txtFacility.Text = facilityName;
            txtLocation.Text = location;
            txtSlot.Text = slot;
            entityContext = new BookingSystemEntities();
            btnBook.Enabled = false;
        }

        //Handle member search during booking
        private void SearchMemberEventHandler(object sender, EventArgs e)
        {
            String phoneNumber = txtMemPhoneNumber.Text;
            lblErrorLabel.Text = "";
            try
            {
                Member member = entityContext.Members.Where(x => x.PhoneNo == phoneNumber).First();
                if (null != member)
                {
                    txtMemberName.Text = member.MemberName;
                    btnBook.Enabled = true;
                } else
                {
                    lblErrorLabel.Text = "Invalid phone number";
                }
            } catch(Exception exception)
            {
                lblErrorLabel.Text = "Invalid phone number";
            }
        }


        private void CloseEventHandler(object sender, EventArgs e)
        {
            Booking.ActiveForm.Close();
        }

        private void BookSlotEventHandler(object sender, EventArgs e)
        {
            try
            {
                BookingTransaction bookingTransaction = new BookingTransaction();
                Facility facility = FindFacilityByName(txtFacility.Text.Trim(), txtLocation.Text.Trim());
                Member member = FindMemberByName(txtMemberName.Text.Trim());
                bookingTransaction.MemberId = member.MemberId;
                bookingTransaction.FacilityId = facility.FacilityId;
                bookingTransaction.SlotTime = bookingDate;
                bookingTransaction.Status = "Booked";
                bookingTransaction.TransactionDate = System.DateTime.Now;
                entityContext.BookingTransactions.Add(bookingTransaction);
                entityContext.SaveChanges();
                transactionStatus = "SUCCESS";
                CloseEventHandler(sender, e);
            } catch(Exception exception)
            {
                transactionStatus = "Failed";
                lblErrorLabel.Text = "Operation failed due to : "+exception.Message.ToString();
            }
        }

        public Member FindMemberByName(String name)
        {
            Member member = null;
            try
            {
                 member = entityContext.Members.Where(x => x.MemberName == name).First();
            } catch(Exception exception)
            {
                lblErrorLabel.Text = "Operation failed due to : " + exception.Message.ToString();
            }
            return member;
        }

        public Facility FindFacilityByName(String name, String locatoin)
        {
            Facility facility = null;
            try
            {
                facility = entityContext.Facilities.Where(x => x.FacilityName == name && x.Location == location).First();
            }
            catch (Exception exception)
            {
                lblErrorLabel.Text = "Operation failed due to : " + exception.Message.ToString();
            }
            return facility;
        }

       
    }
}
