using System.Text.Json.Serialization;

namespace src.Models
{
    public class JsonOffenseRecord : OffenseRecord
    {
        [JsonRequired]
        [JsonPropertyName("rowVersion")]
        public new int RowVersion { get; set; }

        [JsonRequired]
        [JsonPropertyName("fallnummer")]
        public new string Fallnummer { get; set; } = string.Empty;

        // personal data
        [JsonRequired]
        [JsonPropertyName("geschlecht")]
        public new string Geschlecht { get; set; } = string.Empty;

        [JsonPropertyName("titel")]
        public new string Titel { get; set; } = string.Empty;

        [JsonRequired]
        [JsonPropertyName("vorname")]
        public new string Vorname { get; set; } = string.Empty;

        [JsonRequired]
        [JsonPropertyName("nachname")]
        public new string Nachname { get; set; } = string.Empty;

        [JsonRequired]
        [JsonPropertyName("geburtsdatum")]
        public new DateTime Geburtsdatum { get; set; }

        [JsonRequired]
        [JsonPropertyName("str")]
        public new string Str { get; set; } = string.Empty;

        [JsonRequired]
        [JsonPropertyName("hausnummer")]
        public new string Hausnummer { get; set; } = string.Empty;

        [JsonRequired]
        [JsonPropertyName("plz")]
        public new string Plz { get; set; } = string.Empty;

        [JsonRequired]
        [JsonPropertyName("wohnort")]
        public new string Wohnort { get; set; } = string.Empty;

        [JsonPropertyName("geburtsort")]
        public new string Geburtsort { get; set; } = string.Empty;
        
        [JsonPropertyName("ortsteil")]
        public new string Ortsteil { get; set; } = string.Empty;

        // insurance data
        [JsonRequired]
        [JsonPropertyName("versicherungsunternehmensnummer")]
        public new string Versicherungsunternehmensnummer { get; set; } = string.Empty;

        [JsonRequired]
        [JsonPropertyName("krankenversicherung")]
        public new string Krankenversicherung { get; set; } = string.Empty;

        [JsonRequired]
        [JsonPropertyName("versicherungsnummer")]
        public new string Versicherungsnummer { get; set; } = string.Empty;

        // information about offense
        [JsonRequired]
        [JsonPropertyName("aufforderungsdatum")]
        public new DateTime Aufforderungsdatum { get; set; }

        [JsonRequired]
        [JsonPropertyName("beginnRueckstand")]
        public new DateTime BeginnRueckstand { get; set; }

        [JsonRequired]
        [JsonPropertyName("verzugBis")]
        public new DateTime VerzugBis { get; set; }

        [JsonRequired]
        [JsonPropertyName("verzugsende")]
        public new DateTime Verzugsende { get; set; }

        [JsonRequired]
        [JsonPropertyName("beitragsrueckstand")]
        public new int Beitragsrueckstand { get; set; }

        [JsonRequired]
        [JsonPropertyName("gesamtsollbetrag")]
        public new int Gesamtsollbetrag { get; set; }

        // additional information
        [JsonPropertyName("bemerkungen")]
        public new string Bemerkungen { get; set; } = string.Empty; 

        /**************** helper functions ****************/

        /// <summary>
        /// Validates a JsonOffenseRecord object and returns a list of validation errors.
        /// </summary>
        /// <param name="record">The JsonOffenseRecord object to validate.</param>
        /// <returns>A list of validation errors. An empty list indicates that the record is valid.</returns>
        internal static List<string> ValidateRecord(JsonOffenseRecord record)
        {
            var errors = new List<string>();

            if (string.IsNullOrEmpty(record.Fallnummer))                        
                errors.Add("Fallnummer is required.");
            if (string.IsNullOrEmpty(record.Geschlecht))                        
                errors.Add("Geschlecht is required.");
            if (string.IsNullOrEmpty(record.Vorname))                           
                errors.Add("Vorname is required.");
            if (string.IsNullOrEmpty(record.Nachname))                          
                errors.Add("Nachname is required.");
            if (record.Geburtsdatum == DateTime.MinValue)                       
                errors.Add("Geburtsdatum is required.");
            if (string.IsNullOrEmpty(record.Str))                               
                errors.Add("Str is required.");
            if (string.IsNullOrEmpty(record.Hausnummer))                        
                errors.Add("Hausnummer is required.");
            if (string.IsNullOrEmpty(record.Plz))                               
                errors.Add("Plz is required.");
            if (string.IsNullOrEmpty(record.Wohnort))                           
                errors.Add("Wohnort is required.");
            if (string.IsNullOrEmpty(record.Geburtsort))                        
                errors.Add("Geburtsort is required.");
            if (string.IsNullOrEmpty(record.Versicherungsunternehmensnummer))   
                errors.Add("Versicherungsunternehmensnummer is required.");
            if (string.IsNullOrEmpty(record.Krankenversicherung))               
                errors.Add("Krankenversicherung is required.");
            if (string.IsNullOrEmpty(record.Versicherungsnummer))               
                errors.Add("Versicherungsnummer is required.");
            if (record.Aufforderungsdatum == DateTime.MinValue)                 
                errors.Add("Aufforderungsdatum is required.");
            if (record.BeginnRueckstand == DateTime.MinValue)                         
                errors.Add("Beginn Rückstand is required.");
            if (record.Verzugsende == DateTime.MinValue)                        
                errors.Add("Verzugsende is required.");
            if (record.Beitragsrueckstand < 0)                                  
                errors.Add("Beitragsrueckstand must be a non-negative integer.");
            if (record.Gesamtsollbetrag < 0)                                    
                errors.Add("Gesamtsollbetrag must be a non-negative integer.");

            return errors;
        }
    }
}
