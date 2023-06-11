using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RegionController
{
    private readonly RegionService _regionService;

    public RegionController(RegionService regionService)
    {
        _regionService = regionService;
    }

    [HttpGet("GetRegion")]
    public async Task<List<Regions>> GetRegions()
    {
        return await _regionService.GetRegions();
    }

    [HttpGet("GetById")]
    public async Task<Regions> GetRegionById(int Id)
    {
        return await _regionService.GetRegionById(Id);
    }

    [HttpPost("AddRegion")]
    public async Task<Regions> AddRegion([FromForm] Regions regions)
    {
        return await _regionService.AddRegion(regions);
    }

    [HttpPut("UpdateRegion")]
    public async Task<Regions> UpdateRegion([FromForm] Regions regions)
    {
        return await _regionService.UpdateRegion(regions);
    }

    [HttpDelete("DeleteRegion")]
    public async Task<bool> DeleteRegion(int Id)
    {
        return await _regionService.DeleteRegion(Id);
    }
}