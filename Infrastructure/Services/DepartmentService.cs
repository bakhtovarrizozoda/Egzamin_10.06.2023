using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;
using Infrastructure.DataContext;
public class DepartmentService
{
    private readonly DataContext _context;

    public DepartmentService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Departments>> GetDepartments()
    {
        return await _context.Departments.ToListAsync();
    }

    public async Task<Departments> GetDepartmantById(int Id)
    {
        return await _context.Departments.FindAsync(Id);
    }

    public async Task<Departments> AddDepartmaent(Departments departments)
    {
        await _context.Departments.AddAsync(departments);
        await _context.SaveChangesAsync();
        return departments;
    }

    public async Task<Departments> UpdateDepartment(Departments departments)
    {
        var find = await _context.Departments.FindAsync(departments.DepartmentId);
        find.DepartmentName = departments.DepartmentName;
        find.LocationId = departments.LocationId;
        await _context.SaveChangesAsync();
        return departments;
    }

    public async Task<bool> DeleteDepartment(int Id)
    {
        var find = await _context.Departments.FindAsync(Id);
        _context.Departments.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}