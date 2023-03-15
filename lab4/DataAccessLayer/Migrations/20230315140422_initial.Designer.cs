﻿// <auto-generated />
using System;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(myContext))]
    [Migration("20230315140422_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLayer.DomainModels.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Severity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tickets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("564de363-45aa-45c9-b5fb-03812e68537a"),
                            Description = "ticket number one",
                            Severity = 2,
                            Title = "first"
                        },
                        new
                        {
                            Id = new Guid("fce84308-3586-40e4-becb-d7a56fca84f8"),
                            Description = "ticket number two",
                            Severity = 1,
                            Title = "second"
                        },
                        new
                        {
                            Id = new Guid("17156556-18ee-4625-812a-98f627ab9ed8"),
                            Description = "ticket number three",
                            Severity = 0,
                            Title = "third"
                        },
                        new
                        {
                            Id = new Guid("655c2c6c-0d9c-4155-808d-3fac47b8b1a2"),
                            Description = "ticket number four",
                            Severity = 2,
                            Title = "fourth"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
