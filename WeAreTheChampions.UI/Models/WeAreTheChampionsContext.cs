using System.Data.Entity;

namespace WeAreTheChampions.UI.Models
{
    public class WeAreTheChampionsContext : DbContext
    {
        public WeAreTheChampionsContext() : base("name=WeAreTheChampionsContext")
        {

        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamColor> TeamColors { get; set; }
    }
}
