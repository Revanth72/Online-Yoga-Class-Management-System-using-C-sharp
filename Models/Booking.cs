using System;
using System.ComponentModel.DataAnnotations;

namespace YogaClassManagement.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        public int UserId { get; set; }
        public int ClassId { get; set; }

        public DateTime BookingDate { get; set; }
    }
}
