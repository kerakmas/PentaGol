using PentaGol.Domain.Confirgurations;
using PentaGol.Service.DTOs.League;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Interfaces
{
    public interface ILeagueService
    {
        ValueTask<LeagueResultDto> AddAsyn(LeagueCreationDto dto);
        ValueTask<LeagueResultDto> ModifyAsync(long id, LeagueCreationDto dto);
        ValueTask<bool> RemoveAsync(long id);
        ValueTask<LeagueResultDto> RetrieveById(long id);
        ValueTask<IEnumerable<LeagueResultDto>> RetrieveAll(PaginationParams @params = null);

    }
}
