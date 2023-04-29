using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PentaGol.Data.IRepositories;
using PentaGol.Domain.Confirgurations;
using PentaGol.Domain.Entites;
using PentaGol.Service.DTOs.League;
using PentaGol.Service.Exceptions;
using PentaGol.Service.Extensions;
using PentaGol.Service.Interfaces;


namespace PentaGol.Service.Services
{
    public class LeagueService : ILeagueService
    {
        private readonly IRepository<Leaugue> repository;
        private readonly IMapper mapper;

        public LeagueService(IRepository<Leaugue> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async ValueTask<LeagueResultDto> AddAsyn(LeagueCreationDto dto)
        {
           var existLeague = await this.repository.SelectAsync(x => x.Name == dto.Name);
            if (existLeague is not null)
                throw new PentaGolException(409, "League already exists");
            var mapped = this.mapper.Map<Leaugue>(dto);
            mapped.CreatedOn = DateTime.UtcNow;
            await this.repository.InsertAsync(mapped);
            await this.repository.SaveAsync();

            return this.mapper.Map<LeagueResultDto>(dto); 
        }

        public async ValueTask<bool> RemoveAsync(long id)
        {
            var league = await this.repository.SelectAsync(x => x.Id == id);
            if (league is null)
                throw new PentaGolException(404, "Not Found");
            await this.repository.DeleteAsync(league);
            await this.repository.SaveAsync();
            return true;

        }

        public async ValueTask<IEnumerable<LeagueResultDto>> RetrieveAll(PaginationParams @params = null)
        {
            var leauges = await this.repository.SelectAll().ToPagedList(@params).ToListAsync();
            return this.mapper.Map<IEnumerable<LeagueResultDto>>(leauges);
        }

        public async ValueTask<LeagueResultDto> RetrieveById(long id)
        {
            var leaugue = await this.repository.SelectAsync(l => l.Id == id);
            if (leaugue is null)
                throw new PentaGolException(404, "Not Found");
            return this.mapper.Map<LeagueResultDto>(leaugue);
        }

        public async ValueTask<LeagueResultDto> ModifyAsync(long id, LeagueCreationDto dto)
        {
            var leauge = await this.repository.SelectAsync(l => l.Id  == id);
            if (leauge is null)
                throw new PentaGolException(404, "Not Found");
            leauge.UpdatedOn = DateTime.UtcNow;
            await this.repository.UpdateAsync(leauge);
            return this.mapper.Map<LeagueResultDto>(leauge);

        }
    }
}
