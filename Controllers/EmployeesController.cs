using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repositories;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // GET: api/employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            var employees = _employeeRepository.GetEmployees();
            return Ok(employees);
        }

        // GET: api/employees/{id}
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        // POST: api/employees
        [HttpPost]
        public ActionResult<Employee> PostEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
        }

        // PUT: api/employees/{id}
        [HttpPut("{id}")]
        public IActionResult PutEmployee(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }

            _employeeRepository.UpdateEmployee(employee);
            return NoContent();
        }

        // DELETE: api/employees/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return NoContent();
        }
    }
}
