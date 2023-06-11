using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Locations
{
    [Key]
    public int LocationId { get; set; }
    [Required, MaxLength(50)]
    public string StreetAddress { get; set; }
    [Required, MaxLength(20)]
    public string PostalCode { get; set; }
    [Required,MaxLength(50)]
    public string City { get; set; }
    [Required, MaxLength(50)]
    public string StateProvince { get; set; }
    public int CountryId { get; set; }
    public Countries Countries { get; set; }
    public List<Departments> Departments { get; set; }    
}