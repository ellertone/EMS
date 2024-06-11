using EMS.DTO;

namespace EMS.Services
{
    public interface IAttendeeService
    {
        AttendeeDto GetFirstAttendee();

        List<AttendeeDto> GetAllAttendees();

        List<AttendeeDto> GetByAttendeeId(int attendeeId);

    }
}
