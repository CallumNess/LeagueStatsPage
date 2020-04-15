﻿// <auto-generated />
using System;
using LeagueStatsPage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueStatsPage.Migrations
{
    [DbContext(typeof(LeagueStatsPageContext))]
    [Migration("20200414215251_NationalityAdded")]
    partial class NationalityAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeagueStatsPage.Models.PlayerDetails", b =>
                {
                    b.Property<int>("PlayerDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<DateTime>("DOB");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Nationality");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("TeamsId");

                    b.HasKey("PlayerDetailsID");

                    b.HasIndex("TeamsId");

                    b.ToTable("PlayerDetails");
                });

            modelBuilder.Entity("LeagueStatsPage.Models.Teams", b =>
                {
                    b.Property<int>("TeamsID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamName");

                    b.HasKey("TeamsID");

                    b.ToTable("Teams");

                    b.HasData(
                        new { TeamsID = 1, TeamName = "G2 Esports" },
                        new { TeamsID = 2, TeamName = "Excel Esports" },
                        new { TeamsID = 3, TeamName = "FC Schalke 04 Esports" },
                        new { TeamsID = 4, TeamName = "Fnatic" },
                        new { TeamsID = 5, TeamName = "MAD Lions" },
                        new { TeamsID = 6, TeamName = "Misfits Gaming" },
                        new { TeamsID = 7, TeamName = "Origen" },
                        new { TeamsID = 8, TeamName = "Rogue" },
                        new { TeamsID = 9, TeamName = "SK Gaming" },
                        new { TeamsID = 10, TeamName = "Team Vitality" }
                    );
                });

            modelBuilder.Entity("LeagueStatsPage.Models.Tournament", b =>
                {
                    b.Property<int>("TournamentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TournamentName");

                    b.HasKey("TournamentID");

                    b.ToTable("Tournaments");

                    b.HasData(
                        new { TournamentID = 1, TournamentName = "LEC" },
                        new { TournamentID = 2, TournamentName = "LCS" },
                        new { TournamentID = 5, TournamentName = "LCK" },
                        new { TournamentID = 6, TournamentName = "LPL" },
                        new { TournamentID = 4, TournamentName = "MSI" },
                        new { TournamentID = 3, TournamentName = "Worlds" }
                    );
                });

            modelBuilder.Entity("LeagueStatsPage.Models.TournamentTeam", b =>
                {
                    b.Property<int>("TournamentID");

                    b.Property<int>("TeamsID");

                    b.HasKey("TournamentID", "TeamsID");

                    b.HasIndex("TeamsID");

                    b.ToTable("TournamentTeams");
                });

            modelBuilder.Entity("LeagueStatsPage.Models.PlayerDetails", b =>
                {
                    b.HasOne("LeagueStatsPage.Models.Teams", "Team")
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LeagueStatsPage.Models.TournamentTeam", b =>
                {
                    b.HasOne("LeagueStatsPage.Models.Teams", "Teams")
                        .WithMany("TournamentTeams")
                        .HasForeignKey("TeamsID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LeagueStatsPage.Models.Tournament", "Tournament")
                        .WithMany("TournamentTeams")
                        .HasForeignKey("TournamentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
