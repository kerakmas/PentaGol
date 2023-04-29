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
    }
}
