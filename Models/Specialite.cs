using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class Specialite
{
    public int Id { get; set; }

    [Required]
    public string Libelle { get; set; } = string.Empty;

    public List<Medecin> Medecins { get; set; } = new();
}
