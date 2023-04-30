using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PentaGol.Data.IRepositories;
using PentaGol.Domain.Confirgurations;
using PentaGol.Domain.Entites;
using PentaGol.Service.DTOs.Club;
using PentaGol.Service.Exceptions;
using PentaGol.Service.Extensions;
using PentaGol.Service.Interfaces;

namespace PentaGol.Service.Services;

public class ClubService : IClubService
{
    private readonly IRepository<Club> repository;
    private readonly IMapper mapper;

    public ClubService(IRepository<Club> repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async ValueTask<ClubResultDto> AddAsync(ClubCreationDto dto)
    {
        var existingClub = await this.repository.SelectAsync(x => x.Name == dto.Name && x.IsDeleted == true);
        if (existingClub is not null)
            throw new PentaGolException(409, "Club already exists");

        var mapped = this.mapper.Map<Club>(dto); 
        mapped.CreatedOn = DateTime.UtcNow;

        await this.repository.InsertAsync(mapped);
        await this.repository.SaveAsync();

        return this.mapper.Map<ClubResultDto>(mapped);
    }

    public async ValueTask<ClubResultDto> ModifyAsync(long id, ClubCreationDto dto)
    {
        var club = await this.repository.SelectAsync(c => c.Id == id && c.IsDeleted == false);
        if (club is null)
            throw new PentaGolException(404, "Not Found");


        var mapped = this.mapper.Map<Club>(dto);
        mapped.Id = id;
        mapped.UpdatedOn = DateTime.UtcNow;

        await this.repository.SaveAsync();

        return this.mapper.Map<ClubResultDto>(mapped);
    }

    public async ValueTask<bool> RemoveAsync(long id)
    {
        var club = await this.repository.SelectAsync(c => c.Id == id && c.IsDeleted == false);
        if (club is null)
            throw new PentaGolException(404, "Not Found");

        await this.repository.DeleteAsync(club);
        await this.repository.SaveAsync();

        return true;
    }

    public async ValueTask<IEnumerable<ClubResultDto>> RetrieveAll(PaginationParams @params = null)
    {
        var clubs = await this.repository.SelectAll(c => c.IsDeleted == false).ToPagedList(@params).ToListAsync();
        return this.mapper.Map<IEnumerable<ClubResultDto>>(clubs);
    }

    public async ValueTask<ClubResultDto> RetrieveById(long id)
    {
        var club = await this.repository.SelectAsync(c => c.Id == id && c.IsDeleted == false);
        if (club is null)
            throw new PentaGolException(404, "Not Found");

        return this.mapper.Map<ClubResultDto>(club);
    }
    public async ValueTask<Club> RetrieveByIdForMark(long id)
    {
        var club = await this.repository.SelectAsync(c => c.Id == id && c.IsDeleted == false);
        if (club is null)
            throw new PentaGolException(404, "Not Found");

        return club;
    }
    public async ValueTask<IEnumerable<ClubResultDto>> GetAllClubsPropertiesByLeaugeId(long id,PaginationParams @params)
    {
        var clubs = await this.repository.SelectAll(c => c.IsDeleted == false && c.LeaugueId == id).ToPagedList(@params)
            .OrderBy(c => c.TotalScoredGoals).ThenBy(c => c.TotalGamesPlayed) .ToListAsync();
        return this.mapper.Map<IEnumerable<ClubResultDto>>(clubs);
    }
}
