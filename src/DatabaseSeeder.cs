using System;
using System.Linq;
using src.Models;

namespace src
{
    public static class DatabaseSeeder
    {
        public static void Seed(OffenseDbContext context)
        {
            context.Database.EnsureDeleted(); // deletes existing database
            context.Database.EnsureCreated(); // recreates database

            var records = new JsonOffenseRecord[]
            {
                new () {
                    Fallnummer = "A123",
                    Geschlecht = "1",
                    Titel = "Dr.",
                    Vorname = "John",
                    Nachname = "Doe",
                    Geburtsname = "Doe",
                    Geburtsdatum = new DateTime(1990, 1, 1),
                    Str = "TestStreet",
                    Hausnummer = "123a",
                    Plz = "12345",
                    Wohnort = "TestCity",
                    Geburtsort = "TestBirthCity",
                    Ortsteil = "TestDistrict",
                    Versicherungsunternehmensnummer = "TU123456",
                    Krankenversicherung = "TestInsurance",
                    Versicherungsnummer = "VN123456",
                    Aufforderungsdatum = new DateTime(2023, 1, 1),
                    BeginnRueckstand = new DateTime(2022, 12, 1),
                    VerzugBis = new DateTime(2023, 3, 1),
                    Verzugsende = new DateTime(2023, 4, 1),
                    Beitragsrueckstand = 500,
                    Sollbeitrag = 1000,
                    Folgemeldung = 1,
                    Bemerkungen = "First offense record."
                },
                new () {
                    Fallnummer = "B456",
                    Geschlecht = "2",
                    Titel = "Prof.",
                    Vorname = "Jane",
                    Nachname = "Doe",
                    Geburtsname = "Doe",
                    Geburtsdatum = new DateTime(1985, 5, 5),
                    Str = "SampleStreet",
                    Hausnummer = "456b",
                    Plz = "67890",
                    Wohnort = "SampleTown",
                    Geburtsort = "SampleBirthCity",
                    Ortsteil = "SampleDistrict",
                    Versicherungsunternehmensnummer = "TU789012",
                    Krankenversicherung = "SampleInsurance",
                    Versicherungsnummer = "VN789012",
                    Aufforderungsdatum = new DateTime(2023, 2, 1),
                    BeginnRueckstand = new DateTime(2023, 1, 1),
                    VerzugBis = new DateTime(2023, 4, 1),
                    Verzugsende = new DateTime(2023, 5, 1),
                    Beitragsrueckstand = 600,
                    Sollbeitrag = 1200,
                    Folgemeldung = 1,
                    Bemerkungen = "Second offense record."
                },
                new ()
                {
                    Fallnummer = "C789",
                    Geschlecht = "1",
                    Titel = "",
                    Vorname = "Mark",
                    Nachname = "Smith",
                    Geburtsname = "Smith",
                    Geburtsdatum = new DateTime(1978, 3, 22),
                    Str = "MainStreet",
                    Hausnummer = "22b(2nd floor)",
                    Plz = "54321",
                    Wohnort = "MainCity",
                    Geburtsort = "MainBirthCity",
                    Ortsteil = "MainDistrict",
                    Versicherungsunternehmensnummer = "TU345678",
                    Krankenversicherung = "MainInsurance",
                    Versicherungsnummer = "VN345678",
                    Aufforderungsdatum = new DateTime(2023, 3, 1),
                    BeginnRueckstand = new DateTime(2023, 2, 1),
                    VerzugBis = new DateTime(2023, 5, 1),
                    Verzugsende = new DateTime(2023, 6, 1),
                    Beitragsrueckstand = 700,
                    Sollbeitrag = 1400,
                    Folgemeldung = 1,
                    Bemerkungen = "Third offense record."
                },
                new ()
                {
                    Fallnummer = "D012",
                    Geschlecht = "2",
                    Titel = "Dr.",
                    Vorname = "Emma",
                    Nachname = "Johnson",
                    Geburtsname = "Johnson",
                    Geburtsdatum = new DateTime(1992, 7, 19),
                    Str = "HighStreet",
                    Hausnummer = "99b",
                    Plz = "98765",
                    Wohnort = "HighTown",
                    Geburtsort = "HighBirthCity",
                    Ortsteil = "HighDistrict",
                    Versicherungsunternehmensnummer = "TU901234",
                    Krankenversicherung = "HighInsurance",
                    Versicherungsnummer = "VN901234",
                    Aufforderungsdatum = new DateTime(2023, 4, 1),
                    BeginnRueckstand = new DateTime(2023, 3, 1),
                    VerzugBis = new DateTime(2023, 6, 1),
                    Verzugsende = new DateTime(2023, 7, 1),
                    Beitragsrueckstand = 800,
                    Sollbeitrag = 1600,
                    Folgemeldung = 1,
                    Bemerkungen = "Fourth offense record."
                },
                new ()
                {
                    Fallnummer = "E345",
                    Geschlecht = "1",
                    Titel = "",
                    Vorname = "Luke",
                    Nachname = "Brown",
                    Geburtsname = "Brown",
                    Geburtsdatum = new DateTime(1980, 12, 2),
                    Str = "LowStreet",
                    Hausnummer = "76",
                    Plz = "65432",
                    Wohnort = "LowCity",
                    Geburtsort = "LowBirthCity",
                    Ortsteil = "LowDistrict",
                    Versicherungsunternehmensnummer = "TU567890",
                    Krankenversicherung = "LowInsurance",
                    Versicherungsnummer = "VN567890",
                    Aufforderungsdatum = new DateTime(2023, 5, 1),
                    BeginnRueckstand = new DateTime(2023, 4, 1),
                    VerzugBis = new DateTime(2023, 7, 1),
                    Verzugsende = new DateTime(2023, 8, 1),
                    Beitragsrueckstand = 900,
                    Sollbeitrag = 1800,
                    Folgemeldung = 1,
                    Bemerkungen = "Fifth offense record."
                },
                new ()
                {
                    Fallnummer = "F678",
                    Geschlecht = "2",
                    Titel = "Prof.",
                    Vorname = "Olivia",
                    Nachname = "Davis",
                    Geburtsname = "Davis",
                    Geburtsdatum = new DateTime(1987, 11, 5),
                    Str = "OakStreet",
                    Hausnummer = "88c",
                    Plz = "11223",
                    Wohnort = "OakTown",
                    Geburtsort = "OakBirthCity",
                    Ortsteil = "OakDistrict",
                    Versicherungsunternehmensnummer = "TU234567",
                    Krankenversicherung = "OakInsurance",
                    Versicherungsnummer = "VN234567",
                    Aufforderungsdatum = new DateTime(2023, 6, 1),
                    BeginnRueckstand = new DateTime(2023, 5, 1),
                    VerzugBis = new DateTime(2023, 8, 1),
                    Verzugsende = new DateTime(2023, 9, 1),
                    Beitragsrueckstand = 1000,
                    Sollbeitrag = 2000,
                    Folgemeldung = 1,
                    Bemerkungen = "Sixth offense record."
                },
                new ()
                {
                    Fallnummer = "G901",
                    Geschlecht = "1",
                    Titel = "",
                    Vorname = "David",
                    Nachname = "Wilson",
                    Geburtsname = "Wilson",
                    Geburtsdatum = new DateTime(1995, 4, 8),
                    Str = "ElmStreet",
                    Hausnummer = "5",
                    Plz = "44556",
                    Wohnort = "ElmCity",
                    Geburtsort = "ElmBirthCity",
                    Ortsteil = "ElmDistrict",
                    Versicherungsunternehmensnummer = "TU678901",
                    Krankenversicherung = "ElmInsurance",
                    Versicherungsnummer = "VN678901",
                    Aufforderungsdatum = new DateTime(2023, 7, 1),
                    BeginnRueckstand = new DateTime(2023, 6, 1),
                    VerzugBis = new DateTime(2023, 9, 1),
                    Verzugsende = new DateTime(2023, 10, 1),
                    Beitragsrueckstand = 1100,
                    Sollbeitrag = 2200,
                    Folgemeldung = 1,
                    Bemerkungen = "Seventh offense record."
                },
                new ()
                {
                    Fallnummer = "H234",
                    Geschlecht = "2",
                    Titel = "Dr.",
                    Vorname = "Sophia",
                    Nachname = "Moore",
                    Geburtsname = "Moore",
                    Geburtsdatum = new DateTime(1983, 9, 30),
                    Str = "PineStreet",
                    Hausnummer = "45d",
                    Plz = "77889",
                    Wohnort = "PineTown",
                    Geburtsort = "PineBirthCity",
                    Ortsteil = "PineDistrict",
                    Versicherungsunternehmensnummer = "TU890123",
                    Krankenversicherung = "PineInsurance",
                    Versicherungsnummer = "VN890123",
                    Aufforderungsdatum = new DateTime(2023, 8, 1),
                    BeginnRueckstand = new DateTime(2023, 7, 1),
                    VerzugBis = new DateTime(2023, 10, 1),
                    Verzugsende = new DateTime(2023, 11, 1),
                    Beitragsrueckstand = 1200,
                    Sollbeitrag = 2400,
                    Folgemeldung = 1,
                    Bemerkungen = "Eighth offense record."
                },
                new ()
                {
                    Fallnummer = "I567",
                    Geschlecht = "1",
                    Titel = "",
                    Vorname = "James",
                    Nachname = "Taylor",
                    Geburtsname = "Taylor",
                    Geburtsdatum = new DateTime(1999, 6, 17),
                    Str = "MapleStreet",
                    Hausnummer = "12a",
                    Plz = "22334",
                    Wohnort = "MapleCity",
                    Geburtsort = "MapleBirthCity",
                    Ortsteil = "MapleDistrict",
                    Versicherungsunternehmensnummer = "TU345678",
                    Krankenversicherung = "MapleInsurance",
                    Versicherungsnummer = "VN345678",
                    Aufforderungsdatum = new DateTime(2023, 9, 1),
                    BeginnRueckstand = new DateTime(2023, 8, 1),
                    VerzugBis = new DateTime(2023, 11, 1),
                    Verzugsende = new DateTime(2023, 12, 1),
                    Beitragsrueckstand = 1300,
                    Sollbeitrag = 2600,
                    Folgemeldung = 1,
                    Bemerkungen = "Ninth offense record."
                },
                new ()
                {
                    Fallnummer = "J890",
                    Geschlecht = "2",
                    Titel = "Prof.",
                    Vorname = "Ava",
                    Nachname = "Anderson",
                    Geburtsname = "Anderson",
                    Geburtsdatum = new DateTime(1991, 2, 14),
                    Str = "CedarStreet",
                    Hausnummer = "77b",
                    Plz = "55667",
                    Wohnort = "CedarTown",
                    Geburtsort = "CedarBirthCity",
                    Ortsteil = "CedarDistrict",
                    Versicherungsunternehmensnummer = "TU678901",
                    Krankenversicherung = "CedarInsurance",
                    Versicherungsnummer = "VN678901",
                    Aufforderungsdatum = new DateTime(2023, 10, 1),
                    BeginnRueckstand = new DateTime(2023, 9, 1),
                    VerzugBis = new DateTime(2023, 12, 1),
                    Verzugsende = new DateTime(2024, 1, 1),
                    Beitragsrueckstand = 1400,
                    Sollbeitrag = 2800,
                    Folgemeldung = 1,
                    Bemerkungen = "Tenth offense record."
                },
                new ()
                {
                    Fallnummer = "K123",
                    Geschlecht = "1",
                    Titel = "",
                    Vorname = "William",
                    Nachname = "Martinez",
                    Geburtsname = "Martinez",
                    Geburtsdatum = new DateTime(1986, 8, 11),
                    Str = "BirchStreet",
                    Hausnummer = "33",
                    Plz = "88900",
                    Wohnort = "BirchCity",
                    Geburtsort = "BirchBirthCity",
                    Ortsteil = "BirchDistrict",
                    Versicherungsunternehmensnummer = "TU012345",
                    Krankenversicherung = "BirchInsurance",
                    Versicherungsnummer = "VN012345",
                    Aufforderungsdatum = new DateTime(2023, 11, 1),
                    BeginnRueckstand = new DateTime(2023, 10, 1),
                    VerzugBis = new DateTime(2024, 1, 1),
                    Verzugsende = new DateTime(2024, 2, 1),
                    Beitragsrueckstand = 1500,
                    Sollbeitrag = 3000,
                    Folgemeldung = 1,
                    Bemerkungen = "Eleventh offense record."
                }
            };

            // split Hausnummer into digits/extra part
            var dtoRecords = records.Select(record =>
            {
                var dto = new DtoOffenseRecord();
                dto.UpdateRecord(record);
                dto.SplitHausnummer();
                return dto;
            }).ToArray();

            // add records to database
            context.OffenseRecords.AddRange(dtoRecords);
            context.SaveChanges();

        }
    }
}
