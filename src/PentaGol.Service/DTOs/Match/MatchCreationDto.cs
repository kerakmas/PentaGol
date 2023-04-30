namespace PentaGol.Service.DTOs.Match
{
    public class MatchCreationDto
    {
        public DateTime MatchDate { get; set; }

        public long HomeClubId { get; set; }

        public long AwayClubId { get; set; }
        public long LeaugueId { get; set; }
        public int HomeClubScore { get; set; }
        public int AwayClubScore { get; set; }

        public bool Status { get; set; }
    }
}
