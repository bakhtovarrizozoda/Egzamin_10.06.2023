using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;
using Infrastructure.DataContext;
public class JobHistoryService
{
    private readonly DataContext _context;

    public JobHistoryService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<JobHistory>> GetJobHistory()
    {
        return await _context.JobHistories.ToListAsync();
    }

    public async Task<JobHistory> GetJobHistoryById(int Id)
    {
        return await _context.JobHistories.FindAsync(Id);
    }

    public async Task<JobHistory> AddJobHistory(JobHistory jobHistory)
    {
        await _context.JobHistories.FindAsync(jobHistory);
        await _context.SaveChangesAsync();
        return jobHistory;
    }

    public async Task<JobHistory> UpdateJobistory(JobHistory jobHistory)
    {
        var find = await _context.JobHistories.FindAsync(jobHistory.EmployeeId);
        find.StartDate = jobHistory.StartDate;
        find.EndDate = jobHistory.EndDate;
        await _context.SaveChangesAsync();
        return jobHistory;
    }

    public async Task<bool> DeleteJobHistory(int Id)
    {
        var find = await _context.JobHistories.FindAsync(Id);
        _context.JobHistories.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}