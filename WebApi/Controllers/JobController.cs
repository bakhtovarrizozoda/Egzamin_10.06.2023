using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class JobController
{
    private readonly JobService _jobService;

    public JobController(JobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet("GetJobs")]
    public async Task<List<Jobs>> GetJobs()
    {
        return await _jobService.GetJobs();
    }

    [HttpGet("GetJobById")]
    public async Task<Jobs> GetJobById(int Id)
    {
        return await _jobService.GetJobById(Id);
    }

    [HttpPost("AddJob")]
    public async Task<Jobs> AddJob([FromForm] Jobs jobs)
    {
        return await _jobService.AddJob(jobs);
    }

    [HttpPut("UpdateJob")]
    public async Task<Jobs> UpdateJob([FromForm] Jobs jobs)
    {
        return await _jobService.UpdateJob(jobs);
    }

    [HttpDelete("DeleteJob")]
    public async Task<bool> DeleteJob(int Id)
    {
        return await _jobService.DeleteJob(Id);
    }
}