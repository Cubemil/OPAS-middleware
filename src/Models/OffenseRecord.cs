using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class OffenseRecord
    {

        [Key]        
        public string Aktenzeichen { get; set; } = string.Empty;
        public string Anrede { get; set; } = string.Empty;
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;
        public DateTime Geburtsdatum { get; set; } = DateTime.MinValue;
        public string Plz { get; set; } = string.Empty;
        public string Wohnort { get; set; } = string.Empty;
        public string Str { get; set; } = string.Empty;
        public string Hausnummer { get; set; } = string.Empty;
        public string Versicherungsnummer { get; set; } = string.Empty;
        public string Krankenversicherungsname { get; set; } = string.Empty;
        public string Vertragsunternehmensnummer { get; set; } = string.Empty;
        public string Beschreibung { get; set; } = string.Empty;
    }
}