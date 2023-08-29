using VVPSMS.Api.Models.ModelsDto;

namespace VVPSMS.Service.Repository
{
    public interface IAdmissionService
    {
        Task<CommonResponse> StudentAdmission(AdmissionFormDto admissionFormDto);
    }
}
