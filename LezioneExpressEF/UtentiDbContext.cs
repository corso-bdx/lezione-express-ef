using LezioneExpressEF.Models;
using Microsoft.EntityFrameworkCore;

namespace LezioneExpressEF;

public class UtentiDbContext : DbContext
{
    public UtentiDbContext(DbContextOptions<UtentiDbContext> options)
        : base(options) { }

    public DbSet<Utente> Utenti { get; set; } = null!;
}
