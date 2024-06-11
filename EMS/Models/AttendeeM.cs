using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Models
{
    public class Attendee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendeeId { get; set; }

        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MaxLength(15)]
        public string? Phone { get; set; }

        public DateTime RegistrationDate { get; set; }

        [Required]
        public int EventId { get; set; }
    }
}