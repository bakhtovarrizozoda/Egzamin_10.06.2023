using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationController
{
    private readonly LocationService _locationService;

    public LocationController(LocationService locationService)
    {
        _locationService = locationService;
    }

    [HttpGet("GetLocation")]
    public async Task<List<Locations>> GetLocation()
    {
        return await _locationService.GetLocation();
    }

    [HttpGet("GetLocationById")]
    public async Task<Locations> GetLocationById(int Id)
    {
        return await _locationService.GetLocationById(Id);
    }

    [HttpPost("AddLocation")]
    public async Task<Locations> AddLocation([FromForm] Locations locations)
    {
        return await _locationService.AddLocation(locations);
    }

    [HttpPut("UpdateLocation")]
    public async Task<Locations> UpdateLocation([FromForm] Locations locations)
    {
        return await _locationService.UpdateLocation(locations);
    }

    [HttpDelete("DeleteLocation")]
    public async Task<bool> DeleteLocation(int Id)
    {
        return await _locationService.DeleteLocation(Id);
    }
}