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

    }
}
