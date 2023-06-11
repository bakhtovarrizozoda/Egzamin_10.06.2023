using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataContext;

using static DbLoggerCategory.Infrastructure;

public class JobGradeServise
{
    private readonly DataContext _context;

    public JobGradeServise(DataContext context)
    {
        _context = context;
    }

    public async Task<List<JobGrade>> GetJobGrade()
    {
        return await _context.JobGrade.ToListAsync();
    }

    public async Task<JobGrade> GetJobGradeById(string grade)
    {
        return await _context.JobGrade.FindAsync(grade);
    }

    public async Task<JobGrade> AddJobGrade(JobGrade jobGrade)
    {
        await _context.JobGrade.FindAsync(jobGrade);
        await _context.SaveChangesAsync();
        return jobGrade;
    }

    public async Task<JobGrade> UpdateJobGrede(JobGrade jobGrade)
    {
        var find = await _context.JobGrade.FindAsync(jobGrade.GradeLevel);
        find.LowestSal = jobGrade.LowestSal;
        find.HighestSal = jobGrade.HighestSal;
        await _context.SaveChangesAsync();
        return jobGrade;
    }
    public async Task<bool> DeleteJobGrade(string grade)
    {
        var find = await _context.JobGrade.FindAsync(grade);
        _context.JobGrade.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}