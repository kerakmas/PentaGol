using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PentaGol.Domain.Confirgurations;
using PentaGol.Service.DTOs.Club;
using PentaGol.Service.DTOs.League;
using PentaGol.Service.Interfaces;

namespace PentaGol.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeagueController : Controller
    {
        private readonly ILeagueService leagueService;

        public LeagueController(ILeagueService leagueService)
        {
            this.leagueService = leagueService;
        }

        [HttpPost,  Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<IActionResult> PostAsync(LeagueCreationDto dto)
        {
            return Ok(await this.leagueService.AddAsync(dto));
        }
        [HttpDelete("id"), Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return Ok(await this.leagueService.RemoveAsync(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAync([FromQuery] PaginationParams @params)
        {
            return Ok(await this.leagueService.RetrieveAll(@params));
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok(await this.leagueService.RetrieveById(id));
        }
        [HttpPut("id"), Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<IActionResult> UpdateAsync(long id, LeagueCreationDto dto)
        {
            return Ok(await this.leagueService.ModifyAsync(id, dto));
        }
    }
}
