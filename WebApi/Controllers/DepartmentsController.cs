using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class DepartmentsController
{
    private readonly DepartmentService _departmentService;

    public DepartmentsController(DepartmentService departmentService)
    {
        _departmentService = departmentService;
    }

    [HttpGet("GetDepartments")]
    public async Task<List<Departments>> GetDepartments()
    {
        return await _departmentService.GetDepartments();
    }

    [HttpGet("GetDepartmantById")]
    public async Task<Departments> GetDepartmantById(int Id)
    {
        return await _departmentService.GetDepartmantById(Id);
    }

    [HttpPost("AddDepartmaent")]
    public async Task<Departments> AddDepartmaent([FromForm] Departments departments)
    {
        return await _departmentService.AddDepartmaent(departments);
    }

    [HttpPut("UpdateDepartment")]
    public async Task<Departments> UpdateDepartment([FromForm] Departments departments)
    {
        return await _departmentService.UpdateDepartment(departments);
    }

    [HttpDelete("DeleteDepartment")]
    public async Task<bool> DeleteDepartment(int Id)
    {
        return await _departmentService.DeleteDepartment(Id);
    }
}