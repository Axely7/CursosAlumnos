using APIAlumnos.Datos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APIAlumnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public LoginController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Login usuarioLogin)
        {
            var infoUsuario = await AutenticarUsuarioAsync(usuarioLogin.Usuario, usuarioLogin.Password);
            if (infoUsuario != null)
            {
                return Ok(new { token = GenerarTokenJWT(infoUsuario) });
            }
            else
            {
                return Unauthorized();
            }
        }


        private async Task<Usuario> AutenticarUsuarioAsync(string usuario, string password)
        {
            //Validamos que el usuario exista en nuestro fichero de configuración.
            // Podriamos validarlo contra la BBDD
            if (configuration["UsuarioAPI"] == usuario && configuration["UsuarioAPI"] == password)
            {
                return new Usuario()
                {
                    Nombre = configuration["NombreUsuario"],
                    Apellidos = configuration["ApellidosUsuario"],
                    Email = configuration["EmmailUsuario"],
                };
            }

            return null;
        }

        // Generamos Token
        private string GenerarTokenJWT(Usuario usuarioInfo)
        {
            // Cabecera
            var _symmetricSecurityKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["JWT:ClaveSecreta"])
                );
            var _signingCredentials = new SigningCredentials(
                    _symmetricSecurityKey, SecurityAlgorithms.HmacSha256
                );
            var _Header = new JwtHeader(_signingCredentials);

            // Claims
            var _Claims = new[] {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("nombre", usuarioInfo.Nombre),
                new Claim("apellidos", usuarioInfo.Apellidos),
                new Claim(JwtRegisteredClaimNames.Email, usuarioInfo.Email),
            };

            //Payload
            var _Payload = new JwtPayload(
                    issuer: configuration["JWT:Issuer"],
                    audience: configuration["JWT:Audience"],
                    claims: _Claims,
                    notBefore: DateTime.UtcNow,
                     expires: DateTime.UtcNow.AddHours(24)
                );

            // Token
            var _Token = new JwtSecurityToken(
                    _Header,
                    _Payload
                );

            return new JwtSecurityTokenHandler().WriteToken(_Token);
        }
    }
}
