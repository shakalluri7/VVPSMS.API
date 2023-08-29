using Microsoft.EntityFrameworkCore;
using VVPSMS.Api.Models.ModelsDto;
using VVPSMS.Domain.Models;
using VVPSMS.Service.Repository;

namespace VVPSMS.Service.DataManagers
{
    public class AdmissionService: IAdmissionService
    {
        readonly VvpsmsdbContext _vvpsmsdbContext;
        public AdmissionService()
        {
            _vvpsmsdbContext = new VvpsmsdbContext();
        }

        public async Task<CommonResponse> StudentAdmission(AdmissionFormDto adFormDto)
        {
            var response = new CommonResponse();
            try
            {
                var admissionForm = new AdmissionForm()
                {
                    AcademicId = adFormDto.AcademicId,

                };

                _vvpsmsdbContext.AdmissionForms.Add(admissionForm);
                _vvpsmsdbContext.SaveChanges();
                // Grade

                //

                response.Id = admissionForm.FormId;
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
