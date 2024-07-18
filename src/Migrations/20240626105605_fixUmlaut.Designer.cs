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
    [Migration("20240626105605_fixUmlaut")]
    partial class fixUmlaut
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
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aktenzeichen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Anrede")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Aufforderungsdatum")
                        .HasColumnType("TEXT");

                    b.Property<int>("Beitragsrueckstand")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Geburtsdatum")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gesamtsollbetrag")
                        .HasColumnType("INTEGER");

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

                    b.Property<string>("Plz")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Startdatum")
                        .HasColumnType("TEXT");

                    b.Property<string>("Str")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Verjaehrungsfrist")
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
