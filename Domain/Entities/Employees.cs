using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Employees
{
    [Key]
    public int EmployeeId { get; set; }
    [Required, MaxLength(50)] 
    public string FirstName { get; set; }
    [Required, MaxLength(50)]
    public string LastName { get; set; }
    [Required, MaxLength(50)]
    public string Email { get; set; }
    [Required, MaxLength(50)]
    public string PhoneNamber { get; set; }
    [Required]
    public DateTime HireDate { get; set; }

    public int JobId { get; set; }
    public Jobs Jobs { get; set; }
    [Required]
    public decimal Salary { get; set; }
    [Required]
    public int Commission { get; set; }

    public int DepartmentId { get; set; }
    public Departments Departments { get; set; }
    public List<JobHistory> JobHistory { get; set; }
}