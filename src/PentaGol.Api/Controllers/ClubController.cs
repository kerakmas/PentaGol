using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PentaGol.Domain.Confirgurations;
using PentaGol.Service.DTOs.Admin;
using PentaGol.Service.DTOs.Club;
using PentaGol.Service.Interfaces;

namespace PentaGol.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClubController : Controller
    {
        private readonly IClubService clubService;

        public ClubController(IClubService clubService)
        {
            this.clubService = clubService;
        }
        [HttpPost,Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<IActionResult> PostAsync(ClubCreationDto dto)
        {
            return Ok(await this.clubService.AddAsync(dto));
        }
        [HttpDelete("id"), Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return Ok(await this.clubService.RemoveAsync(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAync([FromQuery] PaginationParams @params)
        {
            return Ok(await this.clubService.RetrieveAll(@params));
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok(await this.clubService.RetrieveById(id));
        }
        [HttpPut("id"), Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<IActionResult> UpdateAsync(long id, ClubCreationDto dto)
        {
            return Ok(await this.clubService.ModifyAsync(id, dto));
        }
        [HttpGet("clubpropertiesbyleague/id")]
        public async Task<IActionResult> GetAllClubsbyLeagueId (long id, [FromQuery] PaginationParams @params)
        {
            return Ok(await this.clubService.GetAllClubsPropertiesByLeaugeId(id, @params));
        }
    }
}
