using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CountriesController
{
    private readonly CountriesService _countriesService;

    public CountriesController(CountriesService countriesService)
    {
        _countriesService = countriesService;
    }

    [HttpGet("GetCountries")]
    public async Task<List<Countries>> GetCountries()
    {
        return await _countriesService.GetCountries();
    }

    [HttpGet("GetCountriesById")]
    public async Task<Countries> GetCountriesById(int Id)
    {
        return await _countriesService.GetCountriesById(Id);
    }

    [HttpPost("AddCountries")]
    public async Task<Countries> AddCountries([FromForm] Countries countries)
    {
        return await _countriesService.AddCountries(countries);
    }

    [HttpPut("UpdateCountries")]
    public async Task<Countries> UpdateCountries([FromForm] Countries countries)
    {
        return await _countriesService.UpdateCountries(countries);
    }

    [HttpDelete("DeleteCountries")]
    public async Task<bool> DeleteCountries(int Id)
    {
        return await _countriesService.DeleteCountries(Id);
    }
    
}