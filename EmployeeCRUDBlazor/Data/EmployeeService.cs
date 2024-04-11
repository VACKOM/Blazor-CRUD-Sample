﻿using EmployeeCRUDBlazor.Context;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUDBlazor.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmployeeService(ApplicationDbContext applicationDbContext) {

            _applicationDbContext = applicationDbContext;        
        }

        //Get All Employees List
        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _applicationDbContext.Employees.ToListAsync();
        }


        // Add new Employee record
        public async Task<bool> AddNewEmployee(Employee employee)
        {
            await _applicationDbContext.Employees.AddAsync(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        // Get Employee record by ID
        public async Task<Employee> GetEmployeeById(int id)
        {
            Employee employee = await _applicationDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
          
            return employee;
        }

        // Update Employee record by ID
        public async Task<bool> UpdateEmployeeDetails(Employee employee)
        {
           _applicationDbContext.Employees.Update(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;  
        }

        // Delete Employee record by ID
        public async Task<bool> DeleteEmployee(Employee employee)
        {
            _applicationDbContext.Employees.Remove(employee);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
