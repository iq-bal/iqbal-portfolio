﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using portfolio.Data;

#nullable disable

namespace portfolio.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240226225918_skillsAdded")]
    partial class skillsAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("portfolio.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("About");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            details = "I'm a CS undergrad who finds joy in coding. I like keeping things simple, turning complex problems into clean lines of logic. In the world of bits and bytes, I'm on a mission to make technology elegant and efficient.\r\n\r\nWhen I'm not immersed in code, I'm immersed in books. I love the simplicity of a well-crafted sentence as much as I love a clean piece of code. In a nutshell, a minimalist navigating the worlds of logic and language.",
                            email = "moon2007093@stud.kuet.ac.bd",
                            title = "CS Undergrad, Minimalist, Love to read"
                        });
                });

            modelBuilder.Entity("portfolio.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProficiencyLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C#",
                            ProficiencyLevel = 4
                        },
                        new
                        {
                            Id = 2,
                            Name = "JavaScript",
                            ProficiencyLevel = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
