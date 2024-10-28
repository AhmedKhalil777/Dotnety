﻿// <auto-generated />
using Dotnety.App.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dotnety.App.Migrations
{
    [DbContext(typeof(DotnetyDbContext))]
    [Migration("20241028155229_InitialCreate_SQLite")]
    partial class InitialCreate_SQLite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Dotnety.Models.Connection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Analyzer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConnectionName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConnectionString")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ConnectionType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Connections");
                });
#pragma warning restore 612, 618
        }
    }
}