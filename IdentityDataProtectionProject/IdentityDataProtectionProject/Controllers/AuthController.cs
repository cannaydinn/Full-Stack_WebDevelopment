using IdentityDataProtectionProject.Dtos;
using IdentityDataProtectionProject.Models;
using IdentityDataProtectionProject.Services;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDataProtectionProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;

        public AuthController(IUserService userService, IDataProtectionProvider dataProtectionProvider) 
        {
            _dataProtector = dataProtectionProvider.CreateProtector("security");
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRequest request)
        {
            string protectedPassword = _dataProtector.Protect(request.Password);
            var addUserDto = new AddUserDto
            {
                Email = request.Email,
                Password = protectedPassword,
            };

            var result = await _userService.AddUser(addUserDto);

            if (result.IsSucceed)
                return Ok(result.Message);
            else
                return BadRequest(result.Message);

        }
    }
}
