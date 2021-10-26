using System;

namespace Workshop.APIsRestful.Domain.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
