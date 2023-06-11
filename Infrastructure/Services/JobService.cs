using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;
using Infrastructure.DataContext;
public class JobService
{
    private readonly DataContext _context;

    public JobService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Jobs>> GetJobs()
    {
        return await _context.Jobs.ToListAsync();
    }

    public async Task<Jobs> GetJobById(int Id)
    {
        return await _context.Jobs.FindAsync(Id);
    }

    public async Task<Jobs> AddJob(Jobs jobs)
    {
        await _context.Jobs.FindAsync(jobs);
        await _context.SaveChangesAsync();
        return jobs;
    }

    public async Task<Jobs> UpdateJob(Jobs jobs)
    {
        var find = await _context.Jobs.FindAsync(jobs.JobId);
        find.JobTitle = jobs.JobTitle;
        find.MinSalary = jobs.MinSalary;
        find.MaxSalary = jobs.MaxSalary;
        await _context.SaveChangesAsync();
        return jobs;
    }

    public async Task<bool> DeleteJob(int Id)
    {
        var find = await _context.Jobs.FindAsync(Id);
        _context.Jobs.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}