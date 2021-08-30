using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Dtos.StudentDtos
{
    public class StudentCreateDto
    {
        public string Name { set; get; }
        public string Address { set; get; }
        public decimal Mark { set; get; }
        public DateTime Birthday { set; get; }
    }
}
