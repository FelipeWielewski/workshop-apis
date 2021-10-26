using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workshop.APIsRestful.Domain.Interfaces;
using Workshop.APIsRestful.Domain.Models;

namespace Workshop.APIsRestful.Business
{
    public class AppointmentService : IAppointmentService
    {

        public AppointmentService()
        {

        }

        public async Task<List<Appointment>> GetAsync()
        {
            return new List<Appointment>();
        }

        public async Task<List<Appointment>> GetAsync(Guid employeeId)
        {
            return new List<Appointment>();
        }

        public async Task<Appointment> Create(Employee model)
        {
            return new Appointment();
        }

        public async Task Delete(Guid id)
        {

        }
    }
}
