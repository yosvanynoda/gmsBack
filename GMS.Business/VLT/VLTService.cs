using GMS.Data.DataHelper;
using GMS.Objects.API;
using GMS.Objects.VLT;

namespace GMS.Business.VLT
{
    public class VLTService(IDataHelper dataHelper) : IVLTService
    {
        private readonly IDataHelper _dataHelper = dataHelper;


        public async Task<BaseResponse> CreateVolunteerData(string cn, CreateVolunteerDataRequest request)
        {
            if (request == null || request.VolunteerGeneralData == null )
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Volunteer Data cannot be empty."
                };
            }



            var dtGD = Helper.HelperUDT.ListToDataTable(request.VolunteerGeneralData);

            var dtAllergy = Helper.HelperUDT.ListToDataTable(request.VolunteerAllergyData);

            var dtDisease = Helper.HelperUDT.ListToDataTable(request.VolunteerDiseaseData);

            var dtDoc = Helper.HelperUDT.ListToDataTable(request.VolunteerDocumentationData);

            var dtEmergc = Helper.HelperUDT.ListToDataTable(request.VolunteerEmergencyContactData);

            var dtMed = Helper.HelperUDT.ListToDataTable(request.VolunteerMedicationData);

            var result = await _dataHelper.VLT_CreateVolunteerData(cn, dtGD, dtAllergy, dtDisease,
                dtDoc, dtEmergc, dtMed);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> UpdateVolunteerData(string cn, CreateVolunteerDataRequest request)
        {
            if (request == null || request.VolunteerGeneralData == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Volunteer Data cannot be empty."
                };
            }



            var dtGD = Helper.HelperUDT.ListToDataTable(request.VolunteerGeneralData);

            var dtAllergy = Helper.HelperUDT.ListToDataTable(request.VolunteerAllergyData);

            var dtDisease = Helper.HelperUDT.ListToDataTable(request.VolunteerDiseaseData);

            var dtDoc = Helper.HelperUDT.ListToDataTable(request.VolunteerDocumentationData);

            var dtEmergc = Helper.HelperUDT.ListToDataTable(request.VolunteerEmergencyContactData);

            var dtMed = Helper.HelperUDT.ListToDataTable(request.VolunteerMedicationData);

            // Get CompanyId, SiteId, and Username from the first general data record
            int companyId = 1;
            int siteId =  1;
            int username = 1;

            var result = await _dataHelper.VLT_UpdateVolunteerData(cn, dtGD, dtAllergy, dtDisease,
                dtDoc, dtEmergc, dtMed, companyId, siteId, username);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetVolunteerList(string cn, SiteRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.VLT_GetVolunteerList(cn, request.CompanyId, request.SiteId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No volunteer found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetVolunteerData(string cn, VolunteerRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.VLT_GetVolunteerData(cn, request.CompanyId, request.SiteId, request.VolunteerId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No volunteer found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }
    }
}
