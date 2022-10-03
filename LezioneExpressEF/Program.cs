using LezioneExpressEF;
using LezioneExpressEF.Models;
using Microsoft.EntityFrameworkCore;

DbContextOptions<UtentiDbContext> options = new DbContextOptionsBuilder<UtentiDbContext>()
    .UseSqlServer("Server=localhost,2433;Database=LEZIONE_EF;User Id=sa;Password=p4ssw0rD")
    .Options;

UtentiDbContext context = new UtentiDbContext(options);

//Utente utente = new Utente
//{
//    Nome = "Mario",
//    Cognome = "Rossi",
//};
//
//context.Utenti.Add(utente);
//
//context.SaveChanges();

List<Utente> utenti = context.Utenti.Where(u => u.Nome == "Mario").ToList();

foreach (Utente u in utenti)
{
    Console.WriteLine($"{u.Id}: {u.Nome} {u.Cognome}");
}
