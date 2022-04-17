using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.UI.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }

        public virtual ICollection<Player> Players { get; set; } = new HashSet<Player>();

        public virtual ICollection<Color> Colors { get; set; } = new HashSet<Color>();

        public virtual ICollection<Match> Matches { get; set; } = new HashSet<Match>();

        public override string ToString()
        {
            return TeamName;
        }
    }
}
