using System.ComponentModel.DataAnnotations;

namespace newApp.Models;

public class Game
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty; //or set to required
    [Required]
    [StringLength(20)]
    public required string Genre { get; set; }
    [Required]
    [Range(1,100)]
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
}