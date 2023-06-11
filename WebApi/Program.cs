using Infrastructure.DataContext;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<DataContext>();
builder.Services.AddScoped<RegionService>();
builder.Services.AddScoped<CountriesService>();
builder.Services.AddScoped<LocationService>();
builder.Services.AddScoped<DepartmentService>();
builder.Services.AddScoped<JobService>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<JobHistoryService>();
builder.Services.AddScoped<JobGradeServise>();
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(conf => conf.UseNpgsql(connection));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
