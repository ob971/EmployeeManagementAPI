﻿using EmployeeManagementAPI.Models;
using System.Collections.Generic;

namespace EmployeeManagementAPI.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();

        Employee? GetEmployeeById(int id);

        void AddEmployee(Employee employee);

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int id);
    }
}
