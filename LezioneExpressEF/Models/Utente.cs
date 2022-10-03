using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LezioneExpressEF.Models;

[Table("Utenti")]
public class Utente
{
    [Key]
    public long Id { get; set; }

    public string? Nome { get; set; }

    public string? Cognome { get; set; }
}
