using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PentaGol.Domain.Entites;
using PentaGol.Service.DTOs.Login;
using PentaGol.Service.Exceptions;
using PentaGol.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PentaGol.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAdminService adminService;
        private readonly IConfiguration configuration;

        public AuthService(IAdminService adminService, IConfiguration configuration)
        {
            this.adminService = adminService;
            this.configuration = configuration;
        }

        public async Task<LoginResultDto> AuthenticateAsync(string username, string password)
        {
            var admin = await this.adminService.RetrieveByUsername(username);
            if (admin.UserName != username && admin.Password != password)
                throw new PentaGolException(400, "Email or password is incorrect");

            return new LoginResultDto
            {
                Token = GenerateToken(admin)
            };
        }

        private string GenerateToken(Admin admin)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                 new Claim("Id", admin.Id.ToString()),
                 new Claim(ClaimTypes.Role, admin.AdminRole.ToString()),
                }),
                Audience = configuration["JWT:Audience"],
                Issuer = configuration["JWT:Issuer"],
                IssuedAt = DateTime.UtcNow,
                Expires = DateTime.UtcNow.AddMinutes(double.Parse(configuration["JWT:Expire"])),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
