using AutoMapper;
using CrownHotelListing.Core.DTOs;
using CrownHotelListing.Core.Interfaces;
using CrownHotelListing.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CrownHotelListing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly IAuthService _authService;

        //private readonly SignInManager<ApiUser> _signInManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;

        public AccountController(UserManager<ApiUser> userManager, IAuthService authService,
            ILogger<AccountController> logger, IMapper mapper)
        {
            _userManager = userManager;
            _authService = authService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register([FromBody] UserRequestDto userRequestDto)
        {
            _logger.LogInformation($"Registration attempt for {userRequestDto.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = _mapper.Map<ApiUser>(userRequestDto);
            user.UserName = userRequestDto.Email;
            var result = await _userManager.CreateAsync(user, userRequestDto.PassWord);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            await _userManager.AddToRolesAsync(user, userRequestDto.Roles);
            return Accepted();
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userLoginDto)
        {
            _logger.LogInformation($"Login attempt for {userLoginDto.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!await _authService.ValidateUser(userLoginDto))
            {
                return Unauthorized(userLoginDto);
            }

            return Accepted(new { Token = await _authService.CreateToken() });
        }
    }
}
