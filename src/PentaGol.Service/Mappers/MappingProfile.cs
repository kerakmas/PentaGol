using AutoMapper;
using PentaGol.Domain.Entites;
using PentaGol.Service.DTOs.Admin;
using PentaGol.Service.DTOs.Club;
using PentaGol.Service.DTOs.League;
using PentaGol.Service.DTOs.Match;
using PentaGol.Service.DTOs.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<Club,ClubCreationDto>().ReverseMap();
            CreateMap<Club, ClubResultDto>().ReverseMap();

            CreateMap<Leaugue, LeagueCreationDto>().ReverseMap();
            CreateMap<Leaugue, LeagueResultDto>().ReverseMap();


            CreateMap<Match, MatchCreationDto>().ReverseMap();
            CreateMap<Match, MatchResultDto>().ReverseMap();

            CreateMap<News, NewsCreationDto>().ReverseMap();
            CreateMap<News, NewsResultDto>().ReverseMap();

            CreateMap<Admin, AdminCreationDto>().ReverseMap();
            CreateMap<Admin, AdminResultDto>().ReverseMap();


        }
    }
}
