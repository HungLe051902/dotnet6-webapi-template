using BookingService.InfrastructureLayer.Common.Configs;
using BookingService.InfrastructureLayer.Data.RequestModels;
using BookingService.PresentationLayer.API.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BookingService.PresentationLayer.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {
        private readonly Jwt _jwtOption;

        public UsersController(IOptions<Jwt> jwtOption)
        {
            _jwtOption = jwtOption.Value;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IResult Authenticate(UserAuthen user)
        {
            if (user.UserName == "joydip" && user.Password == "joydip123")
            {
                return Results.Ok(JwtHelper.GenerateToken(user, _jwtOption));
            }
            return Results.Unauthorized();
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IResult RegisterUser(RegisterModel model)
        {
            return Results.Ok();
        }
    }
}
