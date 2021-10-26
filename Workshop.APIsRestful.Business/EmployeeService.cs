using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workshop.APIsRestful.Domain.Interfaces;
using Workshop.APIsRestful.Domain.Models;

namespace Workshop.APIsRestful.Business
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService()
        {

        }


        public async Task<List<Employee>> GetAsync()
        {
            return new List<Employee>();
        }

        public async Task<Employee> GetAsync(Guid id)
        {
            return new Employee();
        }

        public async Task<Employee> Insert(Employee model)
        {
            return new Employee();
        }

        public async Task Update(Guid id, Employee model)
        {

        }

        public async Task Delete(Guid id)
        {
            
        }
    }
}
