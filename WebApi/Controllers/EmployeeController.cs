using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController
{
    private readonly EmployeeService _employeeService;

    public EmployeeController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet("GetEmployees")]
    public async Task<List<Employees>> GetEmployees()
    {
        return await _employeeService.GetEmployees();
    }

    [HttpGet("GetEmployeeById")]
    public async Task<Employees> GetEmployeeById(int Id)
    {
        return await _employeeService.GetEmployeeById(Id);
    }

    [HttpPost("AddEmployee")]
    public async Task<Employees> AddEmployee([FromForm] Employees employees)
    {
        return await _employeeService.AddEmployee(employees);
    }

    [HttpPut("UpdateEmployee")]
    public async Task<Employees> UpdateEmployee([FromForm] Employees employees)
    {
        return await _employeeService.UpdateEmployee(employees);
    }

    [HttpDelete("DeleteEmployee")]
    public async Task<bool> DeleteEmployee(int Id)
    {
        return await _employeeService.DeleteEmployee(Id);
    }
}