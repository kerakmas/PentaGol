using PentaGol.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Domain.Entites
{
    public class Club : Auditable
    {
        public string Name { get; set; }
        public long LeaugeId { get; set; }
        public Leaugue Leaugue { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalScoredGoals { get; set; }
    }
}
