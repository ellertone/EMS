using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.DTO
{
public class AttendeeDto
	{
	        public int AttendeeId { get; set; }
	        public string? Name { get; set; }
	        public string? Email { get; set; }
	        public string? Phone { get; set; }
	        public int? EventId { get; set; }	
	}
}