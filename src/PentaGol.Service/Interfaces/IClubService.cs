using PentaGol.Domain.Confirgurations;
using PentaGol.Domain.Entites;
using PentaGol.Service.DTOs.Club;
using PentaGol.Service.DTOs.League;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Interfaces
{
    public interface IClubService
    {
        ValueTask<ClubResultDto> AddAsync(ClubCreationDto dto);
        ValueTask<ClubResultDto> ModifyAsync(long id, ClubCreationDto dto);
        ValueTask<bool> RemoveAsync(long id);
        ValueTask<ClubResultDto> RetrieveById(long id);
        ValueTask<IEnumerable<ClubResultDto>> RetrieveAll(PaginationParams @params = null);
        ValueTask<Club> RetrieveByIdForMark(long id);
        ValueTask<IEnumerable<ClubResultDto>> GetAllClubsPropertiesByLeaugeId(long id, PaginationParams @params);
    }
}
