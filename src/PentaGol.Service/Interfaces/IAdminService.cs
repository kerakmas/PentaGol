using PentaGol.Domain.Confirgurations;
using PentaGol.Domain.Entites;
using PentaGol.Service.DTOs.Admin;
using PentaGol.Service.DTOs.Club;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Interfaces
{
    public interface IAdminService
    {
        ValueTask<AdminResultDto> AddAsync(AdminCreationDto dto);
        ValueTask<AdminResultDto> ModifyAsync(long id, AdminCreationDto dto);
        ValueTask<bool> RemoveAsync(long id);
        ValueTask<AdminResultDto> RetrieveById(long id);
        ValueTask<IEnumerable<AdminResultDto>> RetrieveAll(PaginationParams @params = null);
        ValueTask<Admin> RetrieveByUsername(string username);
    }
}
