﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace src.Migrations
{
    [DbContext(typeof(OffenseDbContext))]
    [Migration("20240716151120_fixingRowVersion06")]
    partial class fixingRowVersion06
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("src.Models.JSONOffenseRecord", b =>
                {
                    b.Property<int>("RecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasAnnotation("Relational:JsonPropertyName", "recordId");

                    b.Property<DateTime>("Aufforderungsdatum")
                        .HasColumnType("TEXT");

                    b.Property<int>("Beitragsrueckstand")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bemerkungen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Fallnummer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Geburtsdatum")
                        .HasColumnType("TEXT");

                    b.Property<string>("Geburtsort")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gesamtsollbetrag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Geschlecht")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Hausnummer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HausnummerExtra")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HausnummerInt")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Krankenversicherung")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ortsteil")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Plz")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB")
                        .HasDefaultValueSql("randomblob(8)")
                        .HasAnnotation("Relational:JsonPropertyName", "rowVersion");

                    b.Property<DateTime>("Startdatum")
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

                    b.Property<string>("Versicherungsunternehmensnummer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("VerzugBis")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Verzugsende")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Wohnort")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RecordId");

                    b.ToTable("OffenseRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
