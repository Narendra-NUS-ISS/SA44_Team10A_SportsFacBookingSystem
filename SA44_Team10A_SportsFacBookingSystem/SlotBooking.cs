using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA44_Team10A_SportsFacBookingSystem
{
    class SlotBooking : Ibooking
    {
        BookingSystemEntities entityContext;
        public SlotBooking()
        {
            entityContext = new BookingSystemEntities();
        }

        // Slot booking layout invocation by calling stored procedure
        public List<SlotAvailStructureTemplate_Procedure_Result> GetSlotStructure(DateTime bookingDate, string facilityName)
        {
            List<SlotAvailStructureTemplate_Procedure_Result> transactions = new List<SlotAvailStructureTemplate_Procedure_Result>();
            List<Facility> facilities = entityContext.Facilities.Where(x => x.FacilityName == facilityName).ToList();

            foreach (Facility facility in facilities)
            {
                SlotAvailStructureTemplate_Procedure_Result transaction = null;
                try
                {
                    transaction = entityContext.SlotAvailStructureTemplate_Procedure(bookingDate, facility.FacilityId.ToString()).First();
                    if (null != transaction)
                    {

                        transactions.Add(transaction);
                    }
                }
                catch (Exception exception)
                {
                    // Prepare blank template for display
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

            return transactions;
        }
    }
}
