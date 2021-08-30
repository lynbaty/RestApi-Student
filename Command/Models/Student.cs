using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Models
{
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public decimal Mark { set; get; }
        public DateTime Birthday { set; get; }
    }
}
