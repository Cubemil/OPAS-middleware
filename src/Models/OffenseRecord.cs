using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    public class OffenseRecord
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecordId { get; set; }
        public string Aktenzeichen { get; set; } = string.Empty;
        public string Anrede { get; set; } = string.Empty;
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;
        public DateTime Geburtsdatum { get; set; } = DateTime.MinValue;
        public string Plz { get; set; } = string.Empty;
        public string Wohnort { get; set; } = string.Empty;
        public string Str { get; set; } = string.Empty;
        public string HausnummerInt { get; set; } = string.Empty;
        public string HausnummerExtra { get; set; } = string.Empty;
        public string Versicherungsnummer { get; set; } = string.Empty;
        public string Krankenversicherungsname { get; set; } = string.Empty;
        public string Vertragsunternehmensnummer { get; set; } = string.Empty;
    }
}