using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;
using Infrastructure.DataContext;
public class EmployeeService
{
    private readonly DataContext _context;

    public EmployeeService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Employees>> GetEmployees()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<Employees> GetEmployeeById(int Id)
    {
        return await _context.Employees.FindAsync(Id);
    }

    public async Task<Employees> AddEmployee(Employees employees)
    {
        await _context.Employees.AddAsync(employees);
        await _context.SaveChangesAsync();
        return employees;
    }

    public async Task<Employees> UpdateEmployee(Employees employees)
    {
        var find = await _context.Employees.FindAsync(employees.EmployeeId);
        find.FirstName = employees.FirstName;
        find.LastName = employees.LastName;
        find.Email = employees.Email;
        find.PhoneNamber = employees.PhoneNamber;
        find.HireDate = employees.HireDate;
        find.JobId = employees.JobId;
        find.Salary = employees.Salary;
        find.Commission = employees.Commission;
        find.DepartmentId = employees.DepartmentId;
        await _context.SaveChangesAsync();
        return employees;
    }

    public async Task<bool> DeleteEmployee(int Id)
    {
        var find = await _context.Employees.FindAsync(Id);
        _context.Employees.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}