using PentaGol.Domain.Commons;

namespace PentaGol.Domain.Entites
{
    public class Match : Auditable
    {
        public DateTime MatchDate { get; set; }

        public long HomeClubId { get; set; }
        public Club HomeClub { get; set; }

        public long LeaugueId { get; set; }
        public Leaugue Leaugue { get; set; }

        public long AwayClubId { get; set; }
        public Club AwayClub { get; set; }

        public int HomeClubScore { get; set; }
        public int AwayClubScore { get; set; }

        public bool Status { get; set; }
    }
}
