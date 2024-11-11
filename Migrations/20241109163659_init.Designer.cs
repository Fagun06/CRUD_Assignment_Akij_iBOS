﻿// <auto-generated />
using CRUD_Assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD_Assignment.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20241109163659_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUD_Assignment.Models.Drink", b =>
                {
                    b.Property<int>("intColdDrinksld")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("intColdDrinksld"));

                    b.Property<double>("numQuantity")
                        .HasColumnType("float");

                    b.Property<double>("numUnitPrice")
                        .HasColumnType("float");

                    b.Property<string>("strColdDrinksName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("intColdDrinksld");

                    b.ToTable("dbAkijFood");
                });
#pragma warning restore 612, 618
        }
    }
}