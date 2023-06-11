using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Jobs
{
    [Key]
    public int JobId { get; set; }
    [Required, MaxLength(50)] 
    public string JobTitle { get; set; }
    [Required] 
    public decimal MinSalary { get; set; }
    [Required]
    public decimal MaxSalary { get; set; }

    public List<JobHistory> JobHistory { get; set; }
    public List<Employees> Employees { get; set; }
}