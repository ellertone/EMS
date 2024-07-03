using Dapper;
using EMS.DTO;
using Microsoft.AspNetCore.Identity;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace EMS.Services
{
    public class AttendeeService : IAttendeeService
    {
        private readonly IConfiguration _configuration;

        public AttendeeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private IDbConnection Connection
        {
            get
            {
                var connectionString = _configuration.GetConnectionString("DCBA");
                return new SqlConnection(connectionString);
            }
        }

        public AttendeeDto GetFirstAttendee()
        {
            using (var conn = Connection)
            {
                var query = "Select top 1 * from Attendees";
                var result = conn.Query<AttendeeDto>(query).FirstOrDefault();
                return result;
            }
        }

        public List<AttendeeDto> GetAllAttendees()
        {
            using (var conn = Connection)
            {
                var query = "Select * from Attendees";
                var result = conn.Query<AttendeeDto>(query).ToList();
                return result;
            }
        }

        public List<AttendeeDto> GetByAttendeeId(int attendeeId)
        {
            using (var conn = Connection)
            {
                var query = "Select * from Attendees where AttendeeId = @AttendeeId";
                var result = conn.Query<AttendeeDto>(query, new { AttendeeId = attendeeId }).ToList();
                return result;
            }
        }

        public int SaveAttendee(AttendeeDto attendee)
        {
            using (var conn = Connection)
            {
                var query = "INSERT INTO Attendees (AttendeeId, Name, Email, Phone, EventId) VALUES (@AttendeeId, @Name, @Email, @Phone, @EventId)";
                var result = conn.Execute(query, new { AttendeeId = attendee.AttendeeId, Name = attendee.Name, Email = attendee.Email, Phone = attendee.Phone, EventId = attendee.EventId });
                return result;
            }
        }

        public int UpdateAttendee(AttendeeDto attendee)
        {
            using (var conn = Connection)
            {
                var query = "UPDATE Attendees SET Name = @Name, Email = @Email, Phone = @Phone, EventId = @EventId WHERE AttendeeId = @AttendeeId";
                var result = conn.Execute(query, new { AttendeeId = attendee.AttendeeId, Name = attendee.Name, Email = attendee.Email, Phone = attendee.Phone, EventId = attendee.EventId });
                return result;
            }
        }

        public int DeleteAttendee(int attendeeId)
        {
            using (var conn = Connection)
            {
                var query = "DELETE FROM Attendees WHERE AttendeeId = @AttendeeId";
                var result = conn.Execute(query, new { AttendeeId = attendeeId });
                return result;
            }
        }





    }
}
