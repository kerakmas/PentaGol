using PentaGol.Domain.Confirgurations;
using PentaGol.Service.DTOs.Match;
using PentaGol.Service.DTOs.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Interfaces
{
    public interface IMatchService
    {
        ValueTask<MatchResultDto> AddAsync(MatchCreationDto dto);
        ValueTask<MatchResultDto> ModifyAsync(long id, MatchCreationDto dto);
        ValueTask<bool> RemoveAsync(long id);
        ValueTask<MatchResultDto> RetrieveById(long id);
        ValueTask<IEnumerable<MatchResultDto>> RetrieveAll(PaginationParams @params = null);
        ValueTask<MatchResultDto> MarkAsFinishedAsync(long id);
        ValueTask<IEnumerable<MatchResultDto>> RetrieveAllEndedMatchesByLigaId(long id, PaginationParams @params);
        ValueTask<IEnumerable<MatchResultDto>> RetrieveAllNonFinishedMatchesByLigaId(long id, PaginationParams @params);
    }
}
