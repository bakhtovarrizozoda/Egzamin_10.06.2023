using Domain.Entities;
using Infrastructure.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class JobGradeController
{
    private readonly JobGradeServise _jobGradeServise;

    public JobGradeController(JobGradeServise jobGradeServise)
    {
        _jobGradeServise = jobGradeServise;
    }

    [HttpGet("GetJobGrade")]
    public async Task<List<JobGrade>> GetJobGrade()
    {
        return await _jobGradeServise.GetJobGrade();
    }

    [HttpGet("GetJobGradeById")]
    public async Task<JobGrade> GetJobGradeById(string grade)
    {
        return await _jobGradeServise.GetJobGradeById(grade);
    }

    [HttpPost("AddJobGrade")]
    public async Task<JobGrade> AddJobGrade([FromForm] JobGrade jobGrade)
    {
        return await _jobGradeServise.AddJobGrade(jobGrade);
    }

    [HttpPut("UpdateJobGrede")]
    public async Task<JobGrade> UpdateJobGrede([FromForm] JobGrade jobGrade)
    {
        return await _jobGradeServise.UpdateJobGrede(jobGrade);
    }
    
    [HttpDelete("DeleteJobGrade")]
    public async Task<bool> DeleteJobGrade(string grade)
    {
        return await _jobGradeServise.DeleteJobGrade(grade);
    }
    
}