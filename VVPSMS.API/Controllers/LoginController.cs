using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VVPSMS.Api.Models.ModelsDto;
using VVPSMS.Service.Repository;

namespace VVPSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IMapper _mapper;
        private readonly ILoginService _dataRepository;
        public LoginController(IMapper mapper, ILoginService dataRepository)
        {
            _dataRepository = dataRepository;
            _mapper = mapper;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequestDto loginRequestDto)
        {
            var response = await _dataRepository.LoginDetails(loginRequestDto);
            if (response == null)
            {
                return BadRequest("User ID or Password is Wrong");
            }
            else
            {
                return Ok(response);
            }
        }
    }
}
