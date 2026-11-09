using MediBook.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediBook.Controllers;

public class MedecinsController(AppDbContext context) : Controller
{
    public async Task<IActionResult> Index()
    {
        var medecins = await context.Medecins
            .Include(medecin => medecin.Specialite)
            .OrderBy(medecin => medecin.Nom)
            .ThenBy(medecin => medecin.Prenom)
            .ToListAsync();

        return View(medecins);
    }
}
