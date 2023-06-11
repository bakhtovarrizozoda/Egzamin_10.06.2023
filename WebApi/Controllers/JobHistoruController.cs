using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class JobHistoruController
{
    private readonly JobHistoryService _jobHistoryService;

    public JobHistoruController(JobHistoryService jobHistoryService)
    {
        _jobHistoryService = jobHistoryService;
    }

    [HttpGet("GetJobHistory")]
    public async Task<List<JobHistory>> GetJobHistory()
    {
        return await _jobHistoryService.GetJobHistory();
    }

    [HttpGet("GetJobHistoryById")]
    public async Task<JobHistory> GetJobHistoryById(int Id)
    {
        return await _jobHistoryService.GetJobHistoryById(Id);
    }

    [HttpPost("AddJobHistory")]
    public async Task<JobHistory> AddJobHistory([FromForm] JobHistory jobHistory)
    {
        return await _jobHistoryService.AddJobHistory(jobHistory);
    }

    [HttpPut("UpdateJobistory")]
    public async Task<JobHistory> UpdateJobistory([FromForm] JobHistory jobHistory)
    {
        return await _jobHistoryService.UpdateJobistory(jobHistory);
    }

    [HttpDelete("DeleteJobHistory")]
    public async Task<bool> DeleteJobHistory(int Id)
    {
        return await _jobHistoryService.DeleteJobHistory(Id);
    }

}