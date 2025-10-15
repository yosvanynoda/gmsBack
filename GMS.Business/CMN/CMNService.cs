using Azure.Core;
using GMS.Data.DataHelper;
using GMS.Objects.API;
using GMS.Objects.CMN;
using GMS.Objects.General;
using GMS.Objects.VLT;

namespace GMS.Business.CMN
{
    public class CMNService(IDataHelper dataHelper) : ICMNService
    {

        private readonly IDataHelper _dataHelper = dataHelper;

        public async Task<BaseResponse> CreateCompany(string cn, CreateCompanyRequest company)
        {
            // Simulate company creation logic
            if (company == null || string.IsNullOrWhiteSpace(company.CompanyName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Company name cannot be empty."
                };
            }

            // Here you would typically interact with a database or other service to create the company.
            var result = await _dataHelper.CMN_CreateCompany(cn, company.CompanyId, company.CompanyName, company.Username, company.Action);

            // For this example, we will just return a success response.
            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateDisease(string cn, CreateDiseaseRequest request)
        {

            if (request == null || string.IsNullOrWhiteSpace(request.DiseaseName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Disease name cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateDisease(cn, request.DiseaseId, request.DiseaseName, request.CompanyId, request.Username, request.Action, request.DiseaseCode);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateDocType(string cn, CreateDocTypeRequest request)
        {
            // Simulate document type creation logic
            if (request == null || string.IsNullOrWhiteSpace(request.DocType))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Document type name cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateDocType(cn, request.Id, request.DocType, request.Comment, request.ApplyFor,  request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateRoleType(string cn, CreateRoleTypeRequest request)
        {

            if (request == null || string.IsNullOrWhiteSpace(request.RoleTypeName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Role type name cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateRoleType(cn, request.RoleTypeId, request.RoleTypeName, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateSponsorType(string cn, CreateSponsorTypeRequest request)
        {
            // Simulate sponsor type creation logic
            if (request == null || string.IsNullOrWhiteSpace(request.SponsorType))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Sponsor type name cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateSponsorType(cn, request.Id, request.SponsorType, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateSite(string cn, CreateSiteRequest request)
        {

            if (request == null || string.IsNullOrWhiteSpace(request.SiteName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Site name cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateSite(cn, request.SiteId, request.SiteName, request.SiteAddress, request.SiteContact, request.SitePhone,
                                                          request.SiteEmail, request.SiteCode, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateTaskType(string cn, CreateTaskTypeRequest request)
        {
            // Simulate sponsor type creation logic
            if (request == null || string.IsNullOrWhiteSpace(request.TaskTypeName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Task type name cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateTaskType(cn, request.TaskTypeId, request.TaskTypeName, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateTask(string cn, CreateTaskRequest request)
        {
            // Simulate sponsor type creation logic
            if (request == null || string.IsNullOrWhiteSpace(request.TaskName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Task name cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateTask(cn, request.TaskId, request.TaskName, request.TaskTypeId, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateAllergy(string cn, CreateAllergyRequest request)
        {

            if (request == null || string.IsNullOrWhiteSpace(request.Allergy))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Allergy cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateAllergy(cn, request.Id, request.Allergy, request.Comment, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateLanguage(string cn, CreateLanguageRequest request)
        {

            if (request == null || string.IsNullOrWhiteSpace(request.Language))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Language cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateLanguage(cn, request.Id, request.Language, request.Comment, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateMedication(string cn, CreateMedicationRequest request)
        {

            if (request == null || string.IsNullOrWhiteSpace(request.MedicationName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Medication name cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateMedication(cn, request.MedicationId, request.MedicationName, request.MedicationDose, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateRelationType(string cn, CreateRelationTypeRequest request)
        {

            if (request == null || string.IsNullOrWhiteSpace(request.RelationType))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Relation Type cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateRelationType(cn, request.Id, request.RelationType,  request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateStaff(string cn, CreateStaffRequest request)
        {
            // Simulate sponsor type creation logic
            if (request == null || string.IsNullOrWhiteSpace(request.FirstName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Name cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateStaff(cn, request.StaffId, request.FirstName, request.LastName, request.Phone, request.Email, request.Role,
                                                           request.Department, request.CompanyId, request.Site, request.Status, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateStaffDocument(string cn, CreateStaffDocumentRequest request)
        {
            // Simulate document type creation logic
            if (request == null || request.StaffDocumentData == null || request.StaffDocumentData.Count == 0)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Document name cannot be empty."
                };
            }

            var dt = Helper.HelperUDT.ListToDataTable(request.StaffDocumentData);


            var result = await _dataHelper.CMN_CreateStaffDocument(cn, dt, request.StaffId);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }
        
        public async Task<BaseResponse> GetDiseaseList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetDiseaseList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No disease found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetRelationTypeList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetRelationTypeList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Relation Type found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetDocTypeList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetDocTypeList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No document type found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetRoleTypeList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetRoleTypeList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No role type found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetSiteList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetSiteList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No site found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetSponsorTypeList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetSponsorTypeList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No sponsor found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetStaffList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetStaffList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No staff found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetStaffStudio(string cn, int companyId, int siteId, int? staffId, int? studioId)
        {
            var result = await _dataHelper.CMN_GetStaffStudio(cn, companyId, siteId, staffId, studioId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Error retrieving staff-studio relationships."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetStaffDocumentList(string cn, StaffDocRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetStaffDocumentList(cn, request.CompanyId, request.StaffId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No document found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetTaskTypeList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetTaskTypeList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No task type found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetTaskList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetTaskList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No task found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetRaceList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetRaceList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No race found."
                };
            }

            return new BaseResponse
            {
                Data = result.Data,
                Message = result.ResultMessage,
                Success = result?.Result == 0,
            };
        }

        public async Task<BaseResponse> GetLanguageList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetLanguageList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No language found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetGenderList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetGenderList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No gender found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetEthnicityList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetEthnicityList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Ethnicity found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetAllergyList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetAllergyList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No allergy found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetMedicationList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetMedicationList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No medication found."
                };
            }

            return new BaseResponse
            {
                Data = result.Data,
                Message = result.ResultMessage,
                Success = result?.Result == 0,
            };
        }

        public async Task<BaseResponse> GetCROList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetCROList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No CRO found."
                };
            }

            return new BaseResponse
            {
                Data = result.Data,
                Message = result.ResultMessage,
                Success = result?.Result == 0,
            };
        }

        public async Task<BaseResponse> CreateCRO(string cn, CreateCRORequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.CRO))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "CRO cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateCRO(cn, request.Id, request.CRO, request.Comment, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }


        public async Task<BaseResponse> CreateEthnicity(string cn, CreateEthnicityRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Ethnicity))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Ethnicity cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateEthnicity(cn, request.Id, request.Ethnicity, request.Comment, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateGender(string cn, CreateGenderRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Gender))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Gender cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateGender(cn, request.Id, request.Gender, request.Comment, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateRace(string cn, CreateRaceRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Race))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Race cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateRace(cn, request.Id, request.Race, request.Comment, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetFlagDropList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetFlagDropList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Flag found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateVLTStatus(string cn, CreateVLTStatusRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Name))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "VLT Status cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_CreateVLTStatus(cn, request.Id, request.Name, request.Comment, request.CompanyId, request.Username, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetVLTStatusList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.CMN_GetVLTStatusList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No VLT Status found."
                };
            }

            return new BaseResponse
            {
                Data = result.Data,
                Message = result.ResultMessage,
                Success = result?.Result == 0,
            };
        }

    }
}
