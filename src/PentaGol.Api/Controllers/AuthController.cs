using Microsoft.AspNetCore.Mvc;
using PentaGol.Service.DTOs.Login;
using PentaGol.Service.Interfaces;

namespace PentaGol.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }
        [HttpPost]
        public async Task<IActionResult> AuthenticateAsync(LoginDto dto)
        {
            return Ok(await this.authService.AuthenticateAsync(dto.Username, dto.Password));
        }
    }
}
