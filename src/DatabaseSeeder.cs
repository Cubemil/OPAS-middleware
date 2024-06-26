using System;
using src.Models;
using Microsoft.EntityFrameworkCore;

namespace src
{
    public static class DatabaseSeeder
    {
        public static void Seed(OffenseDbContext context)
        {
            context.Database.EnsureDeleted(); // Deletes the existing database
            context.Database.EnsureCreated(); // Recreates the database

            var records = new OffenseRecord[]
            {
                new OffenseRecord
                {
                    Aktenzeichen = "A123",
                    Anrede = "Herr",
                    Titel = "Dr.",
                    Vorname = "John",
                    Nachname = "Doe",
                    Geburtsdatum = new DateTime(1990, 1, 1),
                    Str = "TestStreet",
                    Hausnummer = "123a",
                    Plz = "12345",
                    Wohnort = "TestCity",
                    Versicherungsunternehmensnummer = "TU123456",
                    Krankenversicherung = "TestInsurance",
                    Versicherungsnummer = "VN123456",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "B456",
                    Anrede = "Frau",
                    Titel = "Prof.",
                    Vorname = "Jane",
                    Nachname = "Doe",
                    Geburtsdatum = new DateTime(1985, 5, 5),
                    Str = "SampleStreet",
                    Hausnummer = "456b",
                    Plz = "67890",
                    Wohnort = "SampleTown",
                    Versicherungsunternehmensnummer = "TU789012",
                    Krankenversicherung = "SampleInsurance",
                    Versicherungsnummer = "VN789012",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "C789",
                    Anrede = "Herr",
                    Titel = "",
                    Vorname = "Mark",
                    Nachname = "Smith",
                    Geburtsdatum = new DateTime(1978, 3, 22),
                    Str = "MainStreet",
                    Hausnummer = "22b(2nd floor)",
                    Plz = "54321",
                    Wohnort = "MainCity",
                    Versicherungsunternehmensnummer = "TU345678",
                    Krankenversicherung = "MainInsurance",
                    Versicherungsnummer = "VN345678",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "D012",
                    Anrede = "Frau",
                    Titel = "Dr.",
                    Vorname = "Emma",
                    Nachname = "Johnson",
                    Geburtsdatum = new DateTime(1992, 7, 19),
                    Str = "HighStreet",
                    Hausnummer = "99b",
                    Plz = "98765",
                    Wohnort = "HighTown",
                    Versicherungsunternehmensnummer = "TU901234",
                    Krankenversicherung = "HighInsurance",
                    Versicherungsnummer = "VN901234",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "E345",
                    Anrede = "Herr",
                    Titel = "",
                    Vorname = "Luke",
                    Nachname = "Brown",
                    Geburtsdatum = new DateTime(1980, 12, 2),
                    Str = "LowStreet",
                    Hausnummer = "76",
                    Plz = "65432",
                    Wohnort = "LowCity",
                    Versicherungsunternehmensnummer = "TU567890",
                    Krankenversicherung = "LowInsurance",
                    Versicherungsnummer = "VN567890",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "F678",
                    Anrede = "Frau",
                    Titel = "Prof.",
                    Vorname = "Olivia",
                    Nachname = "Davis",
                    Geburtsdatum = new DateTime(1987, 11, 5),
                    Str = "OakStreet",
                    Hausnummer = "88c",
                    Plz = "11223",
                    Wohnort = "OakTown",
                    Versicherungsunternehmensnummer = "TU234567",
                    Krankenversicherung = "OakInsurance",
                    Versicherungsnummer = "VN234567",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "G901",
                    Anrede = "Herr",
                    Titel = "",
                    Vorname = "David",
                    Nachname = "Wilson",
                    Geburtsdatum = new DateTime(1995, 4, 8),
                    Str = "ElmStreet",
                    Hausnummer = "5",
                    Plz = "44556",
                    Wohnort = "ElmCity",
                    Versicherungsunternehmensnummer = "TU678901",
                    Krankenversicherung = "ElmInsurance",
                    Versicherungsnummer = "VN678901",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "H234",
                    Anrede = "Frau",
                    Titel = "Dr.",
                    Vorname = "Sophia",
                    Nachname = "Moore",
                    Geburtsdatum = new DateTime(1983, 9, 30),
                    Str = "PineStreet",
                    Hausnummer = "45d",
                    Plz = "77889",
                    Wohnort = "PineTown",
                    Versicherungsunternehmensnummer = "TU890123",
                    Krankenversicherung = "PineInsurance",
                    Versicherungsnummer = "VN890123",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "I567",
                    Anrede = "Herr",
                    Titel = "",
                    Vorname = "James",
                    Nachname = "Taylor",
                    Geburtsdatum = new DateTime(1999, 6, 17),
                    Str = "MapleStreet",
                    Hausnummer = "12a",
                    Plz = "22334",
                    Wohnort = "MapleCity",
                    Versicherungsunternehmensnummer = "TU345678",
                    Krankenversicherung = "MapleInsurance",
                    Versicherungsnummer = "VN345678",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "J890",
                    Anrede = "Frau",
                    Titel = "Prof.",
                    Vorname = "Ava",
                    Nachname = "Anderson",
                    Geburtsdatum = new DateTime(1991, 2, 14),
                    Str = "CedarStreet",
                    Hausnummer = "77b",
                    Plz = "55667",
                    Wohnort = "CedarTown",
                    Versicherungsunternehmensnummer = "TU678901",
                    Krankenversicherung = "CedarInsurance",
                    Versicherungsnummer = "VN678901",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "K123",
                    Anrede = "Herr",
                    Titel = "",
                    Vorname = "William",
                    Nachname = "Martinez",
                    Geburtsdatum = new DateTime(1986, 8, 11),
                    Str = "BirchStreet",
                    Hausnummer = "33",
                    Plz = "88900",
                    Wohnort = "BirchCity",
                    Versicherungsunternehmensnummer = "TU012345",
                    Krankenversicherung = "BirchInsurance",
                    Versicherungsnummer = "VN012345",
                }
            };

            // split Hausnummer into digits/extra part
            foreach (var record in records)
            {
                record.SplitHausnummer();
            }

            context.OffenseRecords.AddRange(records);
            context.SaveChanges();
        }
    }
}
