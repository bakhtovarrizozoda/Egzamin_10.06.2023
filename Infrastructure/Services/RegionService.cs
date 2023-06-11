using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;
using Infrastructure.DataContext;
public class RegionService
{
    private readonly DataContext _context;

    public RegionService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Regions>> GetRegions()
    {
        return await _context.Regions.ToListAsync();
    }

    public async Task<Regions> GetRegionById(int Id)
    {
        return await _context.Regions.FindAsync(Id);
    }

    public async Task<Regions> AddRegion(Regions regions)
    {
        await _context.Regions.AddAsync(regions);
        await _context.SaveChangesAsync();
        return regions;
    }

    public async Task<Regions> UpdateRegion(Regions regions)
    {
        var find = await _context.Regions.FindAsync(regions.RegionId);
        find.RegionName = regions.RegionName;
        await _context.SaveChangesAsync();
        return regions;
    }

    public async Task<bool> DeleteRegion(int Id)
    {
        var find = await _context.Regions.FindAsync(Id);
        _context.Regions.Remove(find);
        await _context.SaveChangesAsync();
        return true;
    }
}