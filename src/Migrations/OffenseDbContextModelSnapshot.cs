﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace src.Migrations
{
    [DbContext(typeof(OffenseDbContext))]
    partial class OffenseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("backend.Models.OffenseRecord", b =>
                {
                    b.Property<string>("Aktenzeichen")
                        .HasColumnType("TEXT");

                    b.Property<string>("Anrede")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beschreibung")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Geburtsdatum")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hausnummer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Krankenversicherungsname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Plz")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Str")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Versicherungsnummer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vertragsunternehmensnummer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Wohnort")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Aktenzeichen");

                    b.ToTable("OffenseRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
