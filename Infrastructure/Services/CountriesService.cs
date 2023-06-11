using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;
using Infrastructure.DataContext;
public class CountriesService
{
    private readonly DataContext _context;

    public CountriesService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Countries>> GetCountries()
    {
        return await _context.Countries.ToListAsync();
    }

    public async Task<Countries> GetCountriesById(int Id)
    {
        return await _context.Countries.FindAsync(Id);
    }

    public async Task<Countries> AddCountries(Countries countries)
    {
        await _context.Countries.AddAsync(countries);
        await _context.SaveChangesAsync();
        return countries;
    }

    public async Task<Countries> UpdateCountries(Countries countries)
    {
        var find = await _context.Countries.FindAsync(countries.CountryId);
        find.CountryName = countries.CountryName;
        find.RegionId = countries.RegionId;
        await _context.SaveChangesAsync();
        return countries;
    }

    public async Task<bool> DeleteCountries(int Id)
    {
        var find = await _context.Countries.FindAsync(Id);
        _context.Countries.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}