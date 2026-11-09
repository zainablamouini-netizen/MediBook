using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class Medecin
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nom { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Prenom { get; set; } = string.Empty;

    public string? Telephone { get; set; }

    public string? Cabinet { get; set; }

    public int SpecialiteId { get; set; }

    public Specialite Specialite { get; set; } = null!;

    public List<RendezVous> RendezVous { get; set; } = new();
}
