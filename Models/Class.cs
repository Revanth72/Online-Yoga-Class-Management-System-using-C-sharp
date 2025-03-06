using System;
using System.ComponentModel.DataAnnotations;

namespace YogaClassManagement.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [Required]
        public string ClassName { get; set; }

        public string Instructor { get; set; }

        public DateTime Schedule { get; set; }
    }
}
