using PentaGol.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.DTOs.Club
{
    public class ClubResultDto
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public long LeaugueId { get; set; }
        public string ImgPath { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalScoredGoals { get; set; }
    }
}
