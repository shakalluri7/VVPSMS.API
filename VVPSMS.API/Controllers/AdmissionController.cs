using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VVPSMS.Api.Models.ModelsDto;
using VVPSMS.Service.Repository;

namespace VVPSMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmissionController : ControllerBase
    {
        private IMapper _mapper;
        private readonly IAdmissionService _dataRepository;
        private readonly IConfiguration _configuration;
        private readonly IStorageService  _storageService;
        public AdmissionController(IMapper mapper, IAdmissionService dataRepository, IConfiguration configuration,IStorageService storageService)
        {
            _dataRepository = dataRepository;
            _mapper = mapper;
            _configuration = configuration;
            _storageService = storageService;
        }

        [HttpPost("Admission")]
        public async Task<IActionResult> Admission(AdmissionFormDto admissionForm)
        {
            var response = await _dataRepository.StudentAdmission(admissionForm);
            if (response.Status)
            {
                // blob to store here
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
            
        }
    }
}
