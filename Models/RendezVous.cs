using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class RendezVous
{
    public int Id { get; set; }

    [Required]
    public string PatientId { get; set; } = string.Empty;

    public ApplicationUser Patient { get; set; } = null!;

    public int MedecinId { get; set; }

    public Medecin Medecin { get; set; } = null!;

    public DateTime DateHeure { get; set; }

    public string? Motif { get; set; }

    public StatutRendezVous Statut { get; set; } = StatutRendezVous.Planifie;
}
