using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataContext;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Regions> Regions { get; set; }
    public DbSet<Countries> Countries { get; set; }
    public DbSet<Locations> Locations { get; set; }
    public DbSet<Departments> Departments { get; set; }
    public DbSet<Jobs> Jobs { get; set; }
    public DbSet<Employees> Employees { get; set; }
    public DbSet<JobHistory> JobHistories { get; set; }
    public DbSet<JobGrade> JobGrade { get; set; }
}