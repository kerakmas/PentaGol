using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PentaGol.Domain.Confirgurations;
using PentaGol.Service.DTOs.News;
using PentaGol.Service.Interfaces;

namespace PentaGol.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpPost, Authorize(Roles ="Admin, SuperAdmin")]
        public async Task<IActionResult> PostAsync(NewsCreationDto dto)
        {
            return Ok(await this._newsService.AddAsync(dto));
        }
        [HttpDelete("id"), Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return Ok(await this._newsService.RemoveAsync(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAync([FromQuery] PaginationParams @params)
        {
            return Ok(await this._newsService.RetrieveAll(@params));
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(long id)
        {
            return Ok(await this._newsService.RetrieveById(id));
        }
        [HttpPut("id"), Authorize(Roles = "Admin, SuperAdmin")]
        public async Task<IActionResult> UpdateAsync(long id,NewsCreationDto dto)
        {
            return Ok(await this._newsService.ModifyAsync(id, dto));
        }
        

        
    }
}