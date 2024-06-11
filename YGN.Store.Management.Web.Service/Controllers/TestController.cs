using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using YGN.Store.Management.Web.Service.JwtHelper;

namespace YGN.Store.Management.Web.Service.Controllers
{
    public class TestController : ApiController
    {
        private const string SecretKey = "Qk1XYmV0dGVyYWxsb2Z0aGVt";
        private const string Issuer = "https://192.168.43.16";
        private const string Audience = "https://192.168.43.16";


        [HttpPost]
        [Route("api/authenticate")]
        public IHttpActionResult Authenticate(LoginModel login)
        {
            if (login == null || string.IsNullOrEmpty(login.Username) || string.IsNullOrEmpty(login.Password))
            {
                return BadRequest("Invalid credentials");
            }

            if (login.Username == "test" && login.Password == "password")
            {
                var token = GenerateJwtToken(login.Username);
                return Ok(new { Token = token });
            }
            else
            {
                // return Unauthorized();
                return Content(HttpStatusCode.Unauthorized, "Unauthorized");
            }
        }

        private string GenerateJwtToken(string username)
        {
            var secretKey = Encoding.UTF8.GetBytes(SecretKey);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = Issuer,
                Audience = Audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        public class LoginModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        [Authorize]
        [HttpGet]
        [Route("api/protectedresource")]
        public IHttpActionResult GetProtectedResource()
        {
            //var token = JwtHelperTest.GenerateJwtToken("Bu korumalı bir kaynaktır");

            return Ok("Merhabalar");
        }
    }
}
