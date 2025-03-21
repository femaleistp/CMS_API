﻿// <auto-generated />
using System;
using CMS_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMS_API.Migrations
{
    [DbContext(typeof(CMS_APIContext))]
    [Migration("20250204055008_FixSeedData")]
    partial class FixSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CMS_API.Models.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlogPost");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This is a sample blog post.",
                            CreatedAt = new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "First Blog Post"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Another post for testing.",
                            CreatedAt = new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Second Blog Post"
                        });
                });

            modelBuilder.Entity("CMS_API.Models.BusinessContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BusinessContact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "john@example.com",
                            Name = "John Doe",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jane@example.com",
                            Name = "Jane Smith",
                            Phone = "987-654-3210"
                        });
                });

            modelBuilder.Entity("CMS_API.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubmittedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Feedback");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alice@example.com",
                            Message = "Great website!",
                            Name = "Alice",
                            SubmittedAt = new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob@example.com",
                            Message = "Needs improvement.",
                            Name = "Bob",
                            SubmittedAt = new DateTime(2024, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CMS_API.Models.StaticPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StaticPage");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Welcome to our site!",
                            CreatedAt = new DateTime(2025, 2, 4, 5, 50, 7, 58, DateTimeKind.Utc).AddTicks(1250),
                            Title = "Home"
                        },
                        new
                        {
                            Id = 2,
                            Content = "About us page content.",
                            CreatedAt = new DateTime(2025, 2, 4, 5, 50, 7, 58, DateTimeKind.Utc).AddTicks(1414),
                            Title = "About"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
