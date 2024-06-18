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
                    Vorname = "John",
                    Nachname = "Doe",
                    Titel = "Dr.",
                    Geburtsdatum = new DateTime(1990, 1, 1),
                    Plz = "12345",
                    Wohnort = "TestCity",
                    Str = "TestStreet",
                    HausnummerInt = "123",
                    HausnummerExtra = "a",
                    Versicherungsnummer = "VN123456",
                    Krankenversicherungsname = "TestInsurance",
                    Vertragsunternehmensnummer = "TU123456",
                },
                new OffenseRecord
                {
                    Aktenzeichen = "B456",
                    Anrede = "Frau",
                    Vorname = "Jane",
                    Nachname = "Doe",
                    Titel = "Prof.",
                    Geburtsdatum = new DateTime(1985, 5, 5),
                    Plz = "67890",
                    Wohnort = "SampleTown",
                    Str = "SampleStreet",
                    HausnummerInt = "456",
                    HausnummerExtra = "b",
                    Versicherungsnummer = "VN789012",
                    Krankenversicherungsname = "SampleInsurance",
                    Vertragsunternehmensnummer = "TU789012",
                }
            };

            context.OffenseRecords.AddRange(records);
            context.SaveChanges();
        }
    }
}
