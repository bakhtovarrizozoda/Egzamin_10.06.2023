using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;
using Infrastructure.DataContext;
public class LocationService
{
    private readonly DataContext _context;

    public LocationService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Locations>> GetLocation()
    {
        return await _context.Locations.ToListAsync();
    }

    public async Task<Locations> GetLocationById(int Id)
    {
        return await _context.Locations.FindAsync(Id);
    }

    public async Task<Locations> AddLocation(Locations locations)
    {
        await _context.Locations.AddAsync(locations);
        await _context.SaveChangesAsync();
        return locations;
    }

    public async Task<Locations> UpdateLocation(Locations locations)
    {
        var find = await _context.Locations.FindAsync(locations.LocationId);
        find.StreetAddress = locations.StreetAddress;
        find.PostalCode = locations.PostalCode;
        find.City = locations.City;
        find.StateProvince = locations.StateProvince;
        find.CountryId = locations.CountryId;
        await _context.SaveChangesAsync();
        return locations;
    }

    public async Task<bool> DeleteLocation(int Id)
    {
        var find = await _context.Locations.FindAsync(Id);
        _context.Locations.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}