using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PentaGol.Data.IRepositories;
using PentaGol.Domain.Confirgurations;
using PentaGol.Domain.Entites;
using PentaGol.Service.DTOs.Club;
using PentaGol.Service.DTOs.Match;
using PentaGol.Service.Exceptions;
using PentaGol.Service.Extensions;
using PentaGol.Service.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace PentaGol.Service.Services;

public class MatchService : IMatchService
{
    private readonly IRepository<Match> repository;
    private readonly IMapper mapper;
    private readonly IClubService clubService;

    public MatchService(IRepository<Match> repository, IMapper mapper, IClubService clubService)
    {
        this.repository = repository;
        this.mapper = mapper;
        this.clubService = clubService;
    }

    public async ValueTask<MatchResultDto> AddAsync(MatchCreationDto dto)
    {
        var match = await this.repository.SelectAsync(x => x.HomeClubId == dto.HomeClubId && x.AwayClubId == dto.AwayClubId && x.MatchDate < dto.MatchDate.AddHours(2));
        if (match is not null)
            throw new PentaGolException(409, "Match should be with difference 2 hours if both club IDs are the same.");

        var mapped = this.mapper.Map<Match>(dto);
        mapped.CreatedOn = DateTime.UtcNow;
        await this.repository.InsertAsync(mapped);
        await this.repository.SaveAsync();

        return this.mapper.Map<MatchResultDto>(mapped);
    }

    public async ValueTask<MatchResultDto> MarkAsFinishedAsync(long id)
    {
        var match = await this.repository.SelectAsync(x => x.Id == id && x.IsDeleted == false);
        if(match is null)
        {
            throw new PentaGolException(404, "Not Found");
        }
        if(match.Status == true)
        {
            throw new PentaGolException(409, "This match has already finishied");
        }
        match.Status = true;
        var first_team = await this.clubService.RetrieveByIdForMark(match.HomeClubId);
        var second_team = await this.clubService.RetrieveByIdForMark(match.AwayClubId);
        if(match.HomeClubScore > match.AwayClubScore)
        {
            first_team.TotalScoredGoals += 3;
            first_team.TotalGamesPlayed += 1;
            await this.clubService.ModifyAsync(first_team.Id, this.mapper.Map<ClubCreationDto>(first_team));
            
        }
        else if(match.AwayClubScore > match.HomeClubScore) {
            second_team.TotalScoredGoals += 3;
            second_team.TotalGamesPlayed += 1;

            await this.clubService.ModifyAsync(second_team.Id, this.mapper.Map<ClubCreationDto>(second_team));

        }
        else if(match.AwayClubScore == match.HomeClubScore){
            second_team.TotalScoredGoals += 1;
            first_team.TotalScoredGoals += 1;
            first_team.TotalGamesPlayed += 1;
            second_team.TotalGamesPlayed += 1;

            await this.clubService.ModifyAsync(first_team.Id, this.mapper.Map<ClubCreationDto>(first_team));
            await this.clubService.ModifyAsync(second_team.Id, this.mapper.Map<ClubCreationDto>(second_team));
        }
        await this.repository.SaveAsync();
        return this.mapper.Map<MatchResultDto>(match);
    }

    public async ValueTask<MatchResultDto> ModifyAsync(long id, MatchCreationDto dto)
    {
        var match = await this.repository.SelectAsync(n => n.Id == id && n.MatchDate < dto.MatchDate.AddHours(2));
        if (match is null)
            throw new PentaGolException(404, "Not Found");
        this.mapper.Map(dto, match);
        match.UpdatedOn = DateTime.UtcNow;
        await this.repository.SaveAsync();

        return this.mapper.Map<MatchResultDto>(match);
    }

    public async ValueTask<bool> RemoveAsync(long id)
    {
        var match = await this.repository.SelectAsync(x => x.Id == id);
        if (match is null)
            throw new PentaGolException(404, "Not Found");
        await this.repository.DeleteAsync(match);
        await this.repository.SaveAsync();
        return true;
    }

    public async ValueTask<IEnumerable<MatchResultDto>> RetrieveAll(PaginationParams @params = null)
    {
        var matches = await this.repository.SelectAll(x => x.IsDeleted == false).ToPagedList(@params).ToListAsync();
        return this.mapper.Map<IEnumerable<MatchResultDto>>(matches);
    }

    public async ValueTask<MatchResultDto> RetrieveById(long id)
    {
        var match = await this.repository.SelectAsync(n => n.Id == id && n.IsDeleted == false);
        if (match is null)
            throw new PentaGolException(404, "Not Found");
        return this.mapper.Map<MatchResultDto>(match);
    }
    public async ValueTask<IEnumerable<MatchResultDto>> RetrieveAllEndedMatchesByLigaId(long id, PaginationParams @params)
    {
        var matches = await this.repository.SelectAll(x => x.IsDeleted == false && x.Status == true && x.LeaugueId == id).ToPagedList(@params).ToListAsync();
        return this.mapper.Map<IEnumerable<MatchResultDto>>(matches);
    }
    public async ValueTask<IEnumerable<MatchResultDto>> RetrieveAllNonFinishedMatchesByLigaId(long id, PaginationParams @params)
    {
        var matches = await this.repository.SelectAll(x => x.IsDeleted == false && x.Status == false && x.LeaugueId == id).ToPagedList(@params).ToListAsync();
        return this.mapper.Map<IEnumerable<MatchResultDto>>(matches);
    }

}
