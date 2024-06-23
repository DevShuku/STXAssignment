using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using STXAssignment.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace STXAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if (login.Username == "shruthimayya" && login.Password == "password")
            {
                var token = GenerateJwtToken(login.Username);
                return Ok(new { token });
            }

            return Unauthorized();
        }

        private string GenerateJwtToken(string username)
        {
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJTaHJ1dGhpTWF5eWEiLCJpYXQiOjE3MTkxNjI3OTIsImV4cCI6MTc1MDY5ODc5MiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NzA1My9zd2FnZ2VyL2luZGV4Lmh0bWwiLCJzdWIiOiJzaHJ1dGhpbWF5eWFAZ21haWwuY29tIiwiTmFtZSI6InNocnV0aGltYXl5YSJ9.n5wJdXSXb_eAeEf_7y06Hfo0KPJBghszaOUZkp8fK34"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "ShruthiMayya",
                audience: "https://localhost:7053/swagger/index.html",
                claims: new[]
                {
                    new Claim(ClaimTypes.Name, username)
                },
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}