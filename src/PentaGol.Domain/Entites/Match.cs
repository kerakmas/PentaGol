using PentaGol.Domain.Commons;
using PentaGol.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Domain.Entites
{
    public class Match : Auditable
    {
        public DateTime MatchDate { get; set; }

        public long HomeClubId { get; set; }
        public Club HomeClub { get; set; }

        public long LeaugeId { get; set; }
        public Leaugue Leaugue { get; set; }
       
       public long AwayClubId { get; set; }
       public Club AwayClub { get; set; }

       public int HomeClubScore { get; set; }
       public int AwayClubScore { get; set; }

       public bool Status { get; set; }
    }
}
