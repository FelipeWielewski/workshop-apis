using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.APIsRestful.Domain.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
