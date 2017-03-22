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
        private DataGridView bookingLayoutdatagridView;
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

        public DataGridView BookingLayoutdatagridView
        {
            get
            {
                return bookingLayoutdatagridView;
            }

            set
            {
                bookingLayoutdatagridView = value;
            }
        }

        public Booking()
        {
            InitializeComponent();
        }

        public Booking(String slot, String location, String facilityName, DateTime bookingDate, DataGridView dataGridView)
        {
            InitializeComponent();
            this.slot = slot;
            this.location = location;
            this.facilityName = facilityName;
            this.bookingDate = bookingDate;
            this.bookingLayoutdatagridView = dataGridView;

            txtFacility.Text = facilityName;
            txtLocation.Text = location;
            txtSlot.Text = slot;
            entityContext = new BookingSystemEntities();
            btnBook.Enabled = false;
        }

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
                //RefreshDataGrid();
                transactionStatus = "SUCCESS";
                // Booking.ActiveForm.Close();
                CloseEventHandler(sender, e);
            } catch(Exception exception)
            {
                transactionStatus = "Failed";
                lblErrorLabel.Text = exception.Message.ToString();
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

            }
            return facility;
        }

        public void RefreshDataGrid()
        {
            
            BookingLayoutdatagridView.Refresh();
            //Access each & every cell & Add colour to cells
            for (int rowPosition = 0; rowPosition < Home.transactionsCount; rowPosition++)
            {
                foreach (DataGridViewCell cell in BookingLayoutdatagridView.Rows[rowPosition].Cells)
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
                    }
                    catch (Exception exception)
                    {

                    }
                }
            }


        }
    }
}
