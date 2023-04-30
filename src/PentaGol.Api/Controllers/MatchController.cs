using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PentaGol.Domain.Confirgurations;
using PentaGol.Service.DTOs.Club;
using PentaGol.Service.DTOs.Match;
using PentaGol.Service.Interfaces;

namespace PentaGol.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchController : Controller
    {
        private readonly IMatchService matchService;

        public MatchController(IMatchService matchService)
        {
            this.matchService = matchService;
        }
        [HttpPost, Authorize(Roles ="Admin, SuperAdmin")]
        public async Task<IActionResult> PostAsync(MatchCreationDto dto)
        {
            return Ok(await this.matchService.AddAsync(dto));
        }
        [HttpDelete("id"), Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return Ok(await this.matchService.RemoveAsync(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAync([FromQuery] PaginationParams @params)
        {
            return Ok(await this.matchService.RetrieveAll(@params));
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok(await this.matchService.RetrieveById(id));
        }
        [HttpPut("id"), Authorize(Roles ="Admin, SuperAdmin")]
        public async Task<IActionResult> UpdateAsync(long id, MatchCreationDto dto)
        {
            return Ok(await this.matchService.ModifyAsync(id, dto));
        }
        [HttpPost("markasfinished"),Authorize(Roles ="Admin, SuperAdmin")]
        public async Task<IActionResult> MarkAsFinished(long id)
        {
            return Ok(await this.matchService.MarkAsFinishedAsync(id));
        }
        [HttpGet("finishedmatches")]
        public async Task<IActionResult>  GetALlFinishedMatches(long id, [FromQuery] PaginationParams @params)
        {
            return Ok(await this.matchService.RetrieveAllEndedMatchesByLigaId(id, @params));
        }
        [HttpGet("nonfinishedmatches")]
        public async Task<IActionResult> GetALllNonFinishedMatches(long id, [FromQuery] PaginationParams @params)
        {
            return Ok(await this.matchService.RetrieveAllNonFinishedMatchesByLigaId(id, @params));
        }
    }
}
