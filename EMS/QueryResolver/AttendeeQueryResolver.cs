using EMS.DTO;
using EMS.Services;
using HotChocolate.Types;


namespace EMS.QueryResolver
{
    [ExtendObjectType("Query")]
    public class AttendeeQueryResolver
    {
        public AttendeeDto GetFirstPerson([Service] IAttendeeService attendeeService)
        {
            return attendeeService.GetFirstAttendee();
        }

        public List<AttendeeDto> GetAllAttendees([Service] IAttendeeService attendeeService)
        {
            return attendeeService.GetAllAttendees();
        }

        public List<AttendeeDto> GetByAttendeeID([Service] IAttendeeService attendeeService, int attendeeId)
        {
            return attendeeService.GetByAttendeeId(attendeeId);
        }

       
    }
}
