namespace src.Models
{
    public class OffenseRecord
    {
        // identification properties
        public int RecordId { get; set; }
        public int RowVersion { get; set; }
        public string Fallnummer { get; set; } = string.Empty;
        public DateTime Meldedatum { get; set; } = DateTime.MinValue;

        // insurance data
        public string Versicherungsunternehmensnummer { get; set; } = string.Empty;
        public string Krankenversicherung { get; set; } = string.Empty;
        public string Versicherungsnummer { get; set; } = string.Empty;
        public DateTime BeginnVersicherung { get; set; } = DateTime.MinValue;

        // personal data
        public string Geschlecht { get; set; } = string.Empty;
        public string Titel { get; set; } = string.Empty;
        public DateTime Geburtsdatum { get; set; } = DateTime.MinValue;
        public string Vorname { get; set; } = string.Empty;
        public string Nachname { get; set; } = string.Empty;
        public string Geburtsname { get; set; } = string.Empty;
        public string Str { get; set; } = string.Empty;
        public string Hausnummer { get; set; } = string.Empty;
        public string Plz { get; set; } = string.Empty;
        public string Wohnort { get; set; } = string.Empty;
        public string Ortsteil { get; set; } = string.Empty;
        public string Geburtsort { get; set; } = string.Empty;

        // information about offense
        public DateTime Aufforderungsdatum { get; set; } = DateTime.MinValue;
        public DateTime BeginnRueckstand { get; set; } = DateTime.MinValue;
        public DateTime VerzugBis { get; set; } = DateTime.MinValue;
        public DateTime Verzugsende { get; set; } = DateTime.MinValue;
        public int Beitragsrueckstand { get; set; } = 0;
        public int Sollbeitrag { get; set; } = 0;
        public int Folgemeldung { get; set; } = 0;
        
        // additional information
        public string Bemerkungen { get; set; } = string.Empty;

        // documents
        public DateTime Anhoerungsdatum { get; set; } = DateTime.MinValue;
    }
}