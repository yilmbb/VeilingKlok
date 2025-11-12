using Microsoft.AspNetCore.Identity;

namespace VeilingKlok.Models;

// PK als int; Identity dekt gebruikersnaam/wachtwoord/email
public class Gebruiker : IdentityUser<int>
{
    // Gedeeld door Koper & Verkoper
    public string? Bedrijfsnaam { get; set; }
    public string? KvK { get; set; }
    public string? BtwNummer { get; set; }
    public string? Telefoon { get; set; }
    public string? RekeningNummer { get; set; }

    // Alleen relevant voor Koper
    public string? Leveradres { get; set; }

    // Alleen relevant voor Verkoper
    public decimal? Totaalomzet { get; set; }
}