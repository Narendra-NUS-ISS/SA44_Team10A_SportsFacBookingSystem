using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA44_Team10A_SportsFacBookingSystem
{
    interface Ibooking
    {
        List<SlotAvailStructureTemplate_Procedure_Result> GetSlotStructure(DateTime bookingDate, String facilityName);
    }
}
