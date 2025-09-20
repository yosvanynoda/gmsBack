using GMS.Objects.API;
using GMS.Objects.CMN;
using GMS.Objects.General;

namespace GMS.Business.CMN
{
    public interface ICMNService
    {
        Task<BaseResponse> CreateCompany(string cn, CreateCompanyRequest request);

        Task<BaseResponse> CreateDocType(string cn, CreateDocTypeRequest request);

        Task<BaseResponse> CreateSponsorType(string cn, CreateSponsorTypeRequest request);

        Task<BaseResponse> CreateDisease(string cn, CreateDiseaseRequest request);

        Task<BaseResponse> CreateRoleType(string cn, CreateRoleTypeRequest request);

        Task<BaseResponse> CreateSite(string cn, CreateSiteRequest request);

        Task<BaseResponse> CreateTaskType(string cn, CreateTaskTypeRequest request);

        Task<BaseResponse> CreateRelationType(string cn, CreateRelationTypeRequest request);

        Task<BaseResponse> CreateTask(string cn, CreateTaskRequest request);

        Task<BaseResponse> CreateAllergy(string cn, CreateAllergyRequest request);

        Task<BaseResponse> CreateMedication(string cn, CreateMedicationRequest request);

        Task<BaseResponse> CreateStaff(string cn, CreateStaffRequest request);

        Task<BaseResponse> CreateStaffDocument(string cn, CreateStaffDocumentRequest request);
        
        Task<BaseResponse> GetDocTypeList(string cn, GeneralRequest request); 

        Task<BaseResponse> GetSponsorTypeList(string cn, GeneralRequest request);
        
        Task<BaseResponse> GetRelationTypeList(string cn, GeneralRequest request);

        Task<BaseResponse> GetDiseaseList(string cn, GeneralRequest request);

        Task<BaseResponse> GetMedicationList(string cn, GeneralRequest request);

        Task<BaseResponse> GetRoleTypeList(string cn, GeneralRequest request);

        Task<BaseResponse> GetSiteList(string cn, GeneralRequest request);

        Task<BaseResponse> GetTaskTypeList(string cn, GeneralRequest request);

        Task<BaseResponse> GetTaskList(string cn, GeneralRequest request);

        Task<BaseResponse> GetStaffList(string cn, GeneralRequest  request);

        Task<BaseResponse> GetStaffDocumentList(string cn, StaffDocRequest request);

        Task<BaseResponse> GetRaceList(string cn, GeneralRequest request);

        Task<BaseResponse> GetLanguageList(string cn, GeneralRequest request);

        Task<BaseResponse> GetGenderList(string cn, GeneralRequest request);

        Task<BaseResponse> GetEthnicityList(string cn, GeneralRequest request);

        Task<BaseResponse> GetAllergyList(string cn, GeneralRequest request);

        Task<BaseResponse> CreateEthnicity(string cn, CreateEthnicityRequest request);

        Task<BaseResponse> CreateGender(string cn, CreateGenderRequest request);

        Task<BaseResponse> CreateRace(string cn, CreateRaceRequest request);

        Task<BaseResponse> CreateLanguage(string cn, CreateLanguageRequest request);
    }
}
