using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class JobHistory
{
    [Key]
    public int EmployeeId { get; set; }
    public Employees Employees { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }

    public int JobId { get; set; }
    public Jobs Jobs { get; set; }
    public int DepartmentId { get; set; }
    public Departments Departments { get; set; }    
}