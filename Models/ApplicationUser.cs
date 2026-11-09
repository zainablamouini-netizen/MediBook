using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models;

public class ApplicationUser : IdentityUser
{
    public string Nom { get; set; } = string.Empty;

    public string Prenom { get; set; } = string.Empty;

    public string? Telephone { get; set; }

    public DateTime? DateNaissance { get; set; }

    public List<RendezVous> RendezVous { get; set; } = new();
}
