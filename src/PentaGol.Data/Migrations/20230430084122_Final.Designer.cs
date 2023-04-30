﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PentaGol.Data.Contexts;

#nullable disable

namespace PentaGol.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230430084122_Final")]
    partial class Final
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PentaGol.Domain.Entites.Admin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<byte>("AdminRole")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("PentaGol.Domain.Entites.Club", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("LeaugueId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalGamesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("TotalScoredGoals")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LeaugueId");

                    b.ToTable("Clubs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1808),
                            ImgPath = "https://example.com/juventus.png",
                            IsDeleted = false,
                            LeaugueId = 1L,
                            Name = "Juventus",
                            TotalGamesPlayed = 0,
                            TotalScoredGoals = 0
                        },
                        new
                        {
                            Id = 2L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1810),
                            ImgPath = "https://example.com/acmilan.png",
                            IsDeleted = false,
                            LeaugueId = 1L,
                            Name = "AC Milan",
                            TotalGamesPlayed = 0,
                            TotalScoredGoals = 0
                        },
                        new
                        {
                            Id = 3L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1812),
                            ImgPath = "https://example.com/realmadrid.png",
                            IsDeleted = false,
                            LeaugueId = 3L,
                            Name = "Real Madrid",
                            TotalGamesPlayed = 0,
                            TotalScoredGoals = 0
                        },
                        new
                        {
                            Id = 4L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1813),
                            ImgPath = "https://example.com/barcelona.png",
                            IsDeleted = false,
                            LeaugueId = 3L,
                            Name = "Barcelona",
                            TotalGamesPlayed = 0,
                            TotalScoredGoals = 0
                        },
                        new
                        {
                            Id = 5L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1815),
                            ImgPath = "https://example.com/bayernmunich.png",
                            IsDeleted = false,
                            LeaugueId = 4L,
                            Name = "Bayern Munich",
                            TotalGamesPlayed = 0,
                            TotalScoredGoals = 0
                        },
                        new
                        {
                            Id = 6L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1816),
                            ImgPath = "https://example.com/psg.png",
                            IsDeleted = false,
                            LeaugueId = 5L,
                            Name = "Paris Saint-Germain",
                            TotalGamesPlayed = 0,
                            TotalScoredGoals = 0
                        });
                });

            modelBuilder.Entity("PentaGol.Domain.Entites.Leaugue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Leaugues");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1619),
                            ImgPath = "https://s.scr365.net/s1/logo/22_221_7/v5wl5i_200_15.png",
                            IsDeleted = false,
                            Name = "Italia.Seria a"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1623),
                            ImgPath = "https://b.fssta.com/uploads/application/soccer/competition-logos/EnglishPremierLeague.png",
                            IsDeleted = false,
                            Name = "Premier Liga"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1624),
                            ImgPath = "https://iscreativestudio.com/wp-content/uploads/2016/08/logotipos4.jpg",
                            IsDeleted = false,
                            Name = "LaLiga"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1625),
                            ImgPath = "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/Bundesliga_logo_%282017%29.svg/1200px-Bundesliga_logo_%282017%29.svg.png",
                            IsDeleted = false,
                            Name = "BundesLiga"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1626),
                            ImgPath = "https://upload.wikimedia.org/wikipedia/commons/4/49/Ligue1_Uber_Eats_logo.png",
                            IsDeleted = false,
                            Name = "Ligue"
                        });
                });

            modelBuilder.Entity("PentaGol.Domain.Entites.Match", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AwayClubId")
                        .HasColumnType("bigint");

                    b.Property<int>("AwayClubScore")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long>("HomeClubId")
                        .HasColumnType("bigint");

                    b.Property<int>("HomeClubScore")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("LeaugueId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AwayClubId");

                    b.HasIndex("HomeClubId");

                    b.HasIndex("LeaugueId");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AwayClubId = 2L,
                            AwayClubScore = 0,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1838),
                            HomeClubId = 1L,
                            HomeClubScore = 0,
                            IsDeleted = false,
                            LeaugueId = 1L,
                            MatchDate = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1835),
                            Status = false
                        },
                        new
                        {
                            Id = 2L,
                            AwayClubId = 4L,
                            AwayClubScore = 0,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1847),
                            HomeClubId = 3L,
                            HomeClubScore = 0,
                            IsDeleted = false,
                            LeaugueId = 3L,
                            MatchDate = new DateTime(2023, 5, 1, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1839),
                            Status = false
                        },
                        new
                        {
                            Id = 3L,
                            AwayClubId = 6L,
                            AwayClubScore = 0,
                            CreatedOn = new DateTime(2023, 4, 30, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1849),
                            HomeClubId = 5L,
                            HomeClubScore = 0,
                            IsDeleted = false,
                            LeaugueId = 4L,
                            MatchDate = new DateTime(2023, 5, 2, 8, 41, 21, 879, DateTimeKind.Utc).AddTicks(1848),
                            Status = false
                        });
                });

            modelBuilder.Entity("PentaGol.Domain.Entites.News", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("PentaGol.Domain.Entites.Club", b =>
                {
                    b.HasOne("PentaGol.Domain.Entites.Leaugue", "Leaugue")
                        .WithMany()
                        .HasForeignKey("LeaugueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Leaugue");
                });

            modelBuilder.Entity("PentaGol.Domain.Entites.Match", b =>
                {
                    b.HasOne("PentaGol.Domain.Entites.Club", "AwayClub")
                        .WithMany()
                        .HasForeignKey("AwayClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PentaGol.Domain.Entites.Club", "HomeClub")
                        .WithMany()
                        .HasForeignKey("HomeClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PentaGol.Domain.Entites.Leaugue", "Leaugue")
                        .WithMany()
                        .HasForeignKey("LeaugueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AwayClub");

                    b.Navigation("HomeClub");

                    b.Navigation("Leaugue");
                });
#pragma warning restore 612, 618
        }
    }
}