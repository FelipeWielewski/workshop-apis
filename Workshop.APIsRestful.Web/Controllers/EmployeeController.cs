using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Workshop.APIsRestful.Business;
using Workshop.APIsRestful.Domain.Models;

namespace Workshop.APIsRestful.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmplyoeeController : ControllerBase
    {
        EmployeeService _service;

        public EmplyoeeController(EmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            throw new NotImplementedException();
        }
    }
}
