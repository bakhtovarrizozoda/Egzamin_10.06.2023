using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Regions
{
    [Key]
    public int RegionId { get; set; }
    [Required, MaxLength(50)]
    public string RegionName { get; set; }
    public List<Countries> Countries { get; set; }
}