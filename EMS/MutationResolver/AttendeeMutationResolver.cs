using EMS.DTO;
using EMS.Services;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.MutationResolver
{
    [ExtendObjectType("Mutation")]
    public class AttendeeMutationResolver
    {
        public int SaveAttendee([Service] IAttendeeService attendeeService, AttendeeDto attendee)
        {
            return attendeeService.SaveAttendee(attendee);
        }
        
        public int UpdateAttendee([Service] IAttendeeService attendeeService, AttendeeDto attendee)
        {
            return attendeeService.UpdateAttendee(attendee);
        }

        public int DeleteAttendee([Service] IAttendeeService attendeeService, int attendeeId)
        {
            return attendeeService.DeleteAttendee(attendeeId);
        }


    }
}
