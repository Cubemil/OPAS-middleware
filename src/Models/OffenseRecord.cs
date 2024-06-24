using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace src.Models
{
    public class OffenseRecord
    {
        [Key] // == primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // == auto-increment
        [JsonIgnore] // == not serialized to JSON
        public int RecordId { get; set; }
        public string Aktenzeichen { get; set; } = string.Empty;
        public string Anrede { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public DateTime Geburtsdatum { get; set; } = DateTime.MinValue;
        public string Str { get; set; } = string.Empty;

        /*received from UI, used for splitting*/
        [NotMapped] // == not stored in database ("transient property")
        public string Hausnummer { get; set; } = string.Empty;

        [JsonIgnore]
        public int HausnummerInt { get; set; } = 0;
        [JsonIgnore]
        public string HausnummerExtra { get; set; } = string.Empty;

        public string Plz { get; set; } = string.Empty;
        public string Wohnort { get; set; } = string.Empty;
        public string Krankenversicherungsname { get; set; } = string.Empty;
        public string Versicherungsnummer { get; set; } = string.Empty;
        public string Vertragsunternehmensnummer { get; set; } = string.Empty;

        // split Hausnummer => extracted as a method to be called in Controller AND seeder
        public void SplitHausnummer()
        {
            if (!string.IsNullOrEmpty(Hausnummer))
            {
                // splits Hausnummer into digits/extra part
                var hausnummerIntPart = new string(Hausnummer.TakeWhile(char.IsDigit).ToArray());
                var hausnummerExtraPart = new string(Hausnummer.SkipWhile(char.IsDigit).ToArray());

                // assign split values
                if (int.TryParse(hausnummerIntPart, out int hausnummerInt))
                {
                    HausnummerInt = hausnummerInt;
                }
                HausnummerExtra = hausnummerExtraPart;
            }
        }
    }
}