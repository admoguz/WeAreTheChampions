using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.UI.Models
{
    public class TeamColor
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int? ColorId { get; set; }

        public virtual Color Color { get; set; }  
        public virtual Team Team { get; set; }
    }
}
