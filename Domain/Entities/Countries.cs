using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Countries
{
    [Key]
    public int CountryId { get; set; }
    [Required,MaxLength(50)]
    public string CountryName { get; set; }

    public List<Locations> Locations { get; set; }
    public int RegionId { get; set; }
    public Regions Regions { get; set; }
}