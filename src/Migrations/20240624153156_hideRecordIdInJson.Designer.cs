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
    [Migration("20240624153156_hideRecordIdInJson")]
    partial class hideRecordIdInJson
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

                    b.Property<DateTime>("Geburtsdatum")
                        .HasColumnType("TEXT");

                    b.Property<string>("HausnummerExtra")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HausnummerInt")
                        .HasColumnType("INTEGER");

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

                    b.HasKey("RecordId");

                    b.ToTable("OffenseRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
