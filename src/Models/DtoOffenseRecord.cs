using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace src.Models
{
    public class DtoOffenseRecord : OffenseRecord
    {
        // identification properties
        [Key] // primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // auto increment
        public new int RecordId { get; set; }

        // additonal properties
        [JsonIgnore]
        public int HausnummerInt { get; set; } = 0;
        
        [JsonIgnore]
        public string HausnummerExtra { get; set; } = string.Empty;
        
        /******************************** helper functions ******************************/

        /// <summary>
        /// Splits the Hausnummer into its integer part and extra part.
        /// </summary>
        public void SplitHausnummer()
        {
            if (!string.IsNullOrEmpty(Hausnummer))
            {
                // splits Hausnummer into digits/extra part
                var hausnummerIntPart = new string(Hausnummer.TakeWhile(char.IsDigit).ToArray());
                var hausnummerExtraPart = new string(Hausnummer.SkipWhile(char.IsDigit).ToArray());

                // assign split values
                if (int.TryParse(hausnummerIntPart, out int hausnummerInt)) 
                    HausnummerInt = hausnummerInt;
                    
                HausnummerExtra = hausnummerExtraPart;
            }
        }
        
        /// <summary>
        /// Updates the offense record with the values from the provided <see cref="JsonOffenseRecord"/>.
        /// </summary>
        /// <param name="newRecord">The new offense record containing the updated values.</param>
        public void UpdateRecord(JsonOffenseRecord newRecord)
        {
            Fallnummer = newRecord.Fallnummer;
            Meldedatum = newRecord.Meldedatum;
            Versicherungsunternehmensnummer = newRecord.Versicherungsunternehmensnummer;
            Krankenversicherung = newRecord.Krankenversicherung;
            Versicherungsnummer = newRecord.Versicherungsnummer;
            BeginnVersicherung = newRecord.BeginnVersicherung;
            Geschlecht = newRecord.Geschlecht;
            Titel = newRecord.Titel;
            Geburtsdatum = newRecord.Geburtsdatum;
            Vorname = newRecord.Vorname;
            Nachname = newRecord.Nachname;
            Geburtsname = newRecord.Geburtsname;
            Str = newRecord.Str;
            Hausnummer = newRecord.Hausnummer;
            SplitHausnummer();
            Plz = newRecord.Plz;
            Wohnort = newRecord.Wohnort;
            Ortsteil = newRecord.Ortsteil;
            Geburtsort = newRecord.Geburtsort;
            Aufforderungsdatum = newRecord.Aufforderungsdatum;
            BeginnRueckstand = newRecord.BeginnRueckstand;
            VerzugBis = newRecord.VerzugBis;
            Verzugsende = newRecord.Verzugsende;
            Beitragsrueckstand = newRecord.Beitragsrueckstand;
            Sollbeitrag = newRecord.Sollbeitrag;
            Folgemeldung = newRecord.Folgemeldung;
            Bemerkungen = newRecord.Bemerkungen;
            Anhoerungsdatum = newRecord.Anhoerungsdatum;

            // increment RowVersion
            RowVersion++;
        }

    }
}
