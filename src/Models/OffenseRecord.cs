using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace src.Models
{
    public class OffenseRecord
    {
        [Key] // primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // auto-increment
        [JsonPropertyName("recordId")] // Use this name for serialization
        public int RecordId { get; private set; } // Read-only property with public getter
        public string Fallnummer { get; set; } = string.Empty;

        // personal data
        public string Geschlecht { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public DateTime Geburtsdatum { get; set; } = DateTime.MinValue;
        public string Str { get; set; } = string.Empty;
        
        /*received from UI, used for splitting*/
        //[NotMapped] == originally not stored in db, now temporarily for JSON deserialization
        public string Hausnummer { get; set; } = string.Empty;
        [JsonIgnore] public int HausnummerInt { get; set; } = 0;
        [JsonIgnore] public string HausnummerExtra { get; set; } = string.Empty;
        public string Plz { get; set; } = string.Empty;
        public string Wohnort { get; set; } = string.Empty;
        public string Geburtsort { get; set; } = string.Empty;
        public string Ortsteil { get; set; } = string.Empty;

        // insurance data
        public string Versicherungsunternehmensnummer { get; set; } = string.Empty;
        public string Krankenversicherung { get; set; } = string.Empty;
        public string Versicherungsnummer { get; set; } = string.Empty;

        // information about offense
        public DateTime Aufforderungsdatum { get; set; } = DateTime.MinValue; 
        public DateTime Startdatum { get; set; } = DateTime.MinValue; 
        public DateTime VerzugBis { get; set; } = DateTime.MinValue; 
        public DateTime Verzugsende { get; set; } = DateTime.MinValue; 
        public int Beitragsrueckstand { get; set; } = 0;
        public int Gesamtsollbetrag { get; set; } = 0;

        // additional information
        public string Bemerkungen { get; set; } = string.Empty;

        /**************** helper functions ****************/

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
