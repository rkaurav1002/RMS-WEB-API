using System.IdentityModel.Tokens.Jwt;
using AdminAPI.Dtos;

namespace AdminAPI.Services;

public interface IAuthenticationService
{
    Task<string> Register(RegisterRequest request);
    Task<string> Login(LoginRequest request);
}

