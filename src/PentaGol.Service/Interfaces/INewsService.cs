using Microsoft.AspNetCore.Http;
using PentaGol.Domain.Confirgurations;
using PentaGol.Service.DTOs.League;
using PentaGol.Service.DTOs.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Interfaces
{
    public interface INewsService
    {
        ValueTask<NewsResultDto> AddAsync(NewsCreationDto dto);
        ValueTask<NewsResultDto> ModifyAsync(long id, NewsCreationDto dto);
        ValueTask<bool> RemoveAsync(long id);
        ValueTask<NewsResultDto> RetrieveById(long id);
        ValueTask<IEnumerable<NewsResultDto>> RetrieveAll(PaginationParams @params = null);
    }
}
