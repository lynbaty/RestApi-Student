using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Dtos.StudentDtos
{
    public class StudentUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        [Required]
        public string Address { set; get; }
        [Required]
        public decimal Mark { set; get; }
        [Required]
        public DateTime Birthday { set; get; }
    }
}
