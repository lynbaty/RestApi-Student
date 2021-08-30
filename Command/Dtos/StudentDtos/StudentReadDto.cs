using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Dtos.StudentDtos
{
    public class StudentReadDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Mark { set; get; }
        public DateTime Birthday { set; get; }
    }
}
