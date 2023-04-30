using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PentaGol.Data.IRepositories;
using PentaGol.Domain.Confirgurations;
using PentaGol.Domain.Entites;
using PentaGol.Service.DTOs.News;
using PentaGol.Service.Exceptions;
using PentaGol.Service.Extensions;
using PentaGol.Service.Interfaces;

namespace PentaGol.Service.Services;

public class NewsService : INewsService
{
    private readonly IRepository<News> repository;
    private readonly IMapper mapper;


    public NewsService(IRepository<News> repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async ValueTask<NewsResultDto> AddAsync(NewsCreationDto dto)
    {
        var existingNews = await this.repository.SelectAsync(x => x.Title == dto.Title && x.IsDeleted == false);
        if (existingNews is not null)
        {
            throw new PentaGolException(409, "News with the same title already exists.");
        }

        var mapped = this.mapper.Map<News>(dto);
        mapped.CreatedOn = DateTime.UtcNow;
        await this.repository.InsertAsync(mapped);
        await this.repository.SaveAsync();

        return this.mapper.Map<NewsResultDto>(mapped);
    }

    public async ValueTask<bool> RemoveAsync(long id)
    {
        var news = await this.repository.SelectAsync(x => x.Id == id && x.IsDeleted == false);
        if (news is null)
            throw new PentaGolException(404, "Not Found");
        await this.repository.DeleteAsync(news);
        await this.repository.SaveAsync();
        return true;
    }

    public async ValueTask<IEnumerable<NewsResultDto>> RetrieveAll(PaginationParams @params = null)
    {
        var news = await this.repository.SelectAll(x => x.IsDeleted == false).ToPagedList(@params).ToListAsync();
        return this.mapper.Map<IEnumerable<NewsResultDto>>(news);
    }

    public async ValueTask<NewsResultDto> RetrieveById(long id)
    {
        var news = await this.repository.SelectAsync(n => n.Id == id && n.IsDeleted == false );
        if (news is null)
            throw new PentaGolException(404, "Not Found");
        return this.mapper.Map<NewsResultDto>(news);
    }

    public async ValueTask<NewsResultDto> ModifyAsync(long id, NewsCreationDto dto)
    {
        var news = await this.repository.SelectAsync(n => n.Id == id && n.IsDeleted == false );
        if (news is null)
            throw new PentaGolException(404, "Not Found");
        this.mapper.Map(dto, news);
        news.UpdatedOn = DateTime.UtcNow;
        await this.repository.SaveAsync();

        return this.mapper.Map<NewsResultDto>(news);
    }
}
