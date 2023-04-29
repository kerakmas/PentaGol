using PentaGol.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.DTOs.Match
{
    public class MatchResultDto
    {
        public long Id { get; set; }
        public DateTime MatchDate { get; set; }

        public long HomeClubId { get; set; }

        public long AwayClubId { get; set; }

        public int HomeClubScore { get; set; }
        public int AwayClubScore { get; set; }

        public MatchProcess Status { get; set; }
    }
}
