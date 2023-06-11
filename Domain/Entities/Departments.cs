using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Departments
{
    [Key]
    public int DepartmentId { get; set; }
    [Required, MaxLength(50)]
    public string DepartmentName { get; set; }
    public int LocationId { get; set; }
    public Locations Locations { get; set; }
    public List<Employees> Employees { get; set; }
    public List<JobHistory> JobHistory { get; set; }
}