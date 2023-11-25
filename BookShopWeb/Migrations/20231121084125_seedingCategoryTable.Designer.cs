﻿// <auto-generated />
using BookShopWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookShopWeb.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231121084125_seedingCategoryTable")]
    partial class seedingCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookShopWeb.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A lot of roman stories",
                            DisplayOrder = 2,
                            Name = "Roman"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Show you how is an action",
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 3,
                            Description = "So scary",
                            DisplayOrder = 3,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            Description = "For anyone who loves science",
                            DisplayOrder = 4,
                            Name = "Science"
                        },
                        new
                        {
                            Id = 5,
                            Description = "You can know alot about the world",
                            DisplayOrder = 5,
                            Name = "History"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
