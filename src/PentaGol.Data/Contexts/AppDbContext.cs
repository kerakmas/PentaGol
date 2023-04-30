using Microsoft.EntityFrameworkCore;
using PentaGol.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Leaugue> Leaugues { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Admin> Admins { get; set; }

        #region SeedData
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Leaugue>().HasData(
                new Leaugue() { Id = 1, Name = "Italia.Seria a", ImgPath = "https://s.scr365.net/s1/logo/22_221_7/v5wl5i_200_15.png", CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null },
                new Leaugue() { Id = 2, Name = "Premier Liga", ImgPath = "https://b.fssta.com/uploads/application/soccer/competition-logos/EnglishPremierLeague.png", CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null },
                new Leaugue() { Id = 3, Name = "LaLiga", ImgPath = "https://iscreativestudio.com/wp-content/uploads/2016/08/logotipos4.jpg", CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null },
                new Leaugue() { Id = 4, Name = "BundesLiga", ImgPath = "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/Bundesliga_logo_%282017%29.svg/1200px-Bundesliga_logo_%282017%29.svg.png", CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null },
                new Leaugue() { Id = 5, Name = "Ligue", ImgPath = "https://upload.wikimedia.org/wikipedia/commons/4/49/Ligue1_Uber_Eats_logo.png", CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null }


            );
            modelBuilder.Entity<Club>().HasData(
                new Club() { Id = 1, Name = "Juventus", LeaugueId = 1, TotalGamesPlayed = 0, TotalScoredGoals = 0, CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null, ImgPath = "https://example.com/juventus.png" },
                new Club() { Id = 2, Name = "AC Milan", LeaugueId = 1, TotalGamesPlayed = 0, TotalScoredGoals = 0, CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null, ImgPath = "https://example.com/acmilan.png" },
                new Club() { Id = 3, Name = "Real Madrid", LeaugueId = 3, TotalGamesPlayed = 0, TotalScoredGoals = 0, CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null, ImgPath = "https://example.com/realmadrid.png" },
                new Club() { Id = 4, Name = "Barcelona", LeaugueId = 3, TotalGamesPlayed = 0, TotalScoredGoals = 0, CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null, ImgPath = "https://example.com/barcelona.png" },
                new Club() { Id = 5, Name = "Bayern Munich", LeaugueId = 4, TotalGamesPlayed = 0, TotalScoredGoals = 0, CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null, ImgPath = "https://example.com/bayernmunich.png" },
                new Club() { Id = 6, Name = "Paris Saint-Germain", LeaugueId = 5, TotalGamesPlayed = 0, TotalScoredGoals = 0, CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null, ImgPath = "https://example.com/psg.png" }
            );
            modelBuilder.Entity<Match>().HasData(
                new Match() { Id = 1, MatchDate = DateTime.UtcNow, HomeClubId = 1, LeaugueId = 1, AwayClubId = 2, HomeClubScore = 0, AwayClubScore = 0, Status = false, CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null },
        new Match() { Id = 2, MatchDate = DateTime.UtcNow.AddDays(1), HomeClubId = 3, LeaugueId = 3, AwayClubId = 4, HomeClubScore = 0, AwayClubScore = 0, Status = false, CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null },
        new Match() { Id = 3, MatchDate = DateTime.UtcNow.AddDays(2), HomeClubId = 5, LeaugueId = 4, AwayClubId = 6, HomeClubScore = 0, AwayClubScore = 0, Status = false, CreatedOn = DateTime.UtcNow, IsDeleted = false, UpdatedOn = null }
             );
        }
        #endregion
    }
}