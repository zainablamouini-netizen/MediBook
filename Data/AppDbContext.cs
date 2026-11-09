using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace MediBook.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Specialite> Specialites => Set<Specialite>();

    public DbSet<Medecin> Medecins => Set<Medecin>();

    public DbSet<RendezVous> RendezVous => Set<RendezVous>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<RendezVous>()
            .HasIndex(rendezVous => new { rendezVous.MedecinId, rendezVous.DateHeure })
            .IsUnique();

        modelBuilder.Entity<RendezVous>()
            .Property(rendezVous => rendezVous.Statut)
            .HasConversion<string>();
    }
}
