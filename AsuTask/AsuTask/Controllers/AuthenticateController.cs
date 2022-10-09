using AsuTask.Application.Services;
using AsuTask.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AsuTask.Controllers
{
    [AllowAnonymous]
    [Route("[controller]")]
    public class AuthenticateController : Controller
    {
        private readonly IUserService _userService;

        public AuthenticateController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] AuthenticateRequestModel authenticateRequestModel)
        {
            var token = await _userService.Authenticate(authenticateRequestModel);

            if (token == null)
            {
                return Unauthorized(new { message = "Username or password is incorrect" });
            }
                
            return Ok(token);
        }
    }
}
