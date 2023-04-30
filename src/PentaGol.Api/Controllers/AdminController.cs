using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PentaGol.Domain.Confirgurations;
using PentaGol.Service.DTOs.Admin;
using PentaGol.Service.DTOs.News;
using PentaGol.Service.Interfaces;

namespace PentaGol.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }
        [HttpPost, Authorize(Roles ="SuperAdmin")]
        public async Task<IActionResult> PostAsync(AdminCreationDto dto)
        {
            return Ok(await this.adminService.AddAsync(dto));
        }
        [HttpDelete("id"),Authorize(Roles ="SuperAdmin")]
        public async Task<IActionResult> DeleteAsync(long id)
        {
            return Ok(await this.adminService.RemoveAsync(id));
        }
        [HttpGet, Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> GetAllAync([FromQuery] PaginationParams @params)
        {
            return Ok(await this.adminService.RetrieveAll(@params));
        }
        [HttpGet("id"), Authorize(Roles = "SuperAdmin")]  
        public async Task<IActionResult> GetById(long id)
        {
            return Ok(await this.adminService.RetrieveById(id));
        }
        [HttpPut("id"), Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> UpdateAsync(long id, AdminCreationDto dto)
        {
            return Ok(await this.adminService.ModifyAsync(id, dto));
        }

    }
}
