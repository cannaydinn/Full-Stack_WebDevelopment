using JWTProject.Context;
using JWTProject.Dtos;
using JWTProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserLoginDto userLogin)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == userLogin.Email && x.Password == userLogin.Password);

            if (user is null)
                return BadRequest("Kullanıcı adı veya şifre hatalı");

            var token = GenerateToken(user);
            return Ok();
        }
        public static string GenerateToken(UserEntity user) 
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("BQ7YzYz3w7ocVkP0Y+p6OOSlise7pKgij2QqVi+fYFMiRplx5+q/NAyVVM9BqOwT"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email)
        };

            var token = new JwtSecurityToken(
                issuer: "JWTPractice",
                audience: "https://localhost:5657",
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
