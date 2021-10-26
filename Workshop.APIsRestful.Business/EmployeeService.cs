using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Workshop.APIsRestful.Domain.Interfaces;
using Workshop.APIsRestful.Domain.Models;
using Workshop.APIsRestful.Domain.Repositories;

namespace Workshop.APIsRestful.Business
{
    public class EmployeeService : IEmployeeService
    {
        DatabaseRepository<Employee> _repository;

        public EmployeeService(DatabaseRepository<Employee> repository)
        {
            _repository = repository;
        }


        public async Task<List<Employee>> GetAsync()
        {
            return await _repository.GetAsync();
        }

        public async Task<Employee> GetAsync(Guid id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<Employee> Insert(Employee model)
        {
            return await _repository.Create(model);
        }

        public async Task Update(Guid id, Employee model)
        {
            model.Id = id;

            await _repository.Update(model);
        }

        public async Task Delete(Guid id)
        {
            await _repository.Delete(id);
        }
    }
}
