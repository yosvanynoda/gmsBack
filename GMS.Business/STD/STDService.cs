using Azure.Core;
using GMS.Data.DataHelper;
using GMS.Objects.API;
using GMS.Objects.General;
using GMS.Objects.STD;

namespace GMS.Business.STD
{
    public class STDService(IDataHelper dataHelper) : ISTDService
    {
        private readonly IDataHelper _dataHelper = dataHelper;

        public async Task<BaseResponse> CreateMonitor(string cn, CreateMonitorRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.FirstName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Monitor name cannot be empty."
                };
            }

            var result = await _dataHelper.STD_CrudMonitor(cn, request.FirstName, request.LastName, request.Email, request.Phone, request.Role, request.CompanyId, (int)request.SiteId, request.Id, request.Username, request.SponsorId, request.Action);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateProtocol(string cn, CreateProtocolRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Protocol))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Protocol cannot be empty."
                };
            }

            var result = await _dataHelper.STD_CrudProtocol(cn, request.Id,  request.Protocol,  request.DateCreated, request.Version, request.Notes, request.StartDate, request.EndDate,  request.CompanyId, request.Username, request.Action, request.SiteId);


            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateSponsor(string cn, CreateSponsorRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.SponsorName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Sponsor cannot be empty."
                };
            }

                  var result = await _dataHelper.STD_CrudSponsor(cn, request.SponsorName,  request.SponsorType, request.ContactName, request.ContactEmail, request.ContactPhone,
                 request.CompanyId, request.SiteId, request.Id, request.Username, request.Action);


            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateStudioData(string cn, CreateStudioDataRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Studio Data cannot be empty."
                };
            }

            var dtGeneralData = Helper.HelperUDT.ListToDataTable(request.STDGeneralData);

            var dtDocumentation = Helper.HelperUDT.ListToDataTable(request.STDDocumentation);

            var dtMonitor = Helper.HelperUDT.ListToDataTable(request.STDMonitor);

            var dtProtocol = Helper.HelperUDT.ListToDataTable(request.STDProtocol);

            var dtArms = Helper.HelperUDT.ListToDataTable(request.STDArms);

            var dtVisits = Helper.HelperUDT.ListToDataTable(request.STDVisits);

            var result = await _dataHelper.STD_CreateStudioData(cn, dtGeneralData, dtDocumentation, 
                dtMonitor, dtProtocol, dtArms, dtVisits, request.CompanyId, request.SiteId, request.Username);


            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> UpdateStudioData(string cn, CreateStudioDataRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Studio Data cannot be empty."
                };
            }

            var dtGeneralData = Helper.HelperUDT.ListToDataTable(request.STDGeneralData);

            var dtDocumentation = Helper.HelperUDT.ListToDataTable(request.STDDocumentation);

            var dtMonitor = Helper.HelperUDT.ListToDataTable(request.STDMonitor);

            var dtProtocol = Helper.HelperUDT.ListToDataTable(request.STDProtocol);

            var dtArms = Helper.HelperUDT.ListToDataTable(request.STDArms);

            var dtVisits = Helper.HelperUDT.ListToDataTable(request.STDVisits);

            var result = await _dataHelper.STD_UpdateStudioData(cn, dtGeneralData, dtDocumentation,
                dtMonitor, dtProtocol, dtArms, dtVisits, request.CompanyId, request.SiteId, request.Username);


            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateStudioDoc(string cn, CreateStudioDocRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Name))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Studio Doc cannot be empty."
                };
            }

            var result = await _dataHelper.STD_CreateStudioDoc(cn, request.Id, request.StudioId, request.Name, request.TypeId, request.DocDate, request.Version, request.Notes, request.CompanyId, request.UserName, request.Action, request.SiteId);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetMonitorList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetMonitorList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No monitors found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetProtocolList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetProtocolList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Protocol found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetSponsorList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetSponsorList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Sponsor found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetStudioList(string cn, int companyId, int siteId)
        {
            if (companyId == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetStudioList(cn, companyId, siteId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Studio found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetSubjectList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetSubjectList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Subject found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetStudioDocList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetStudioDocList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No docs found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }


        public async Task<BaseResponse> GetSponsorDropList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetSponsorDropList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Protocol found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetDiseaseDropList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetDiseaseDropList(cn, request.CompanyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Disease found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetCroDropList(string cn, GeneralRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetCroDropList(cn, request.CompanyId);

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
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetMonitorDropList(string cn, int companyId, int sponsorId)
        {
            if (sponsorId == null | companyId == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetMonitorDropList(cn, companyId, sponsorId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Protocol found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }


        public async Task<BaseResponse> GetStaffDropList(string cn, int companyId, int siteId)
        {
            if (siteId == null | companyId == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetStaffDropList(cn, companyId, siteId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Staff found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetStudioDropList(string cn, int companyId, int siteId)
        {
            if (siteId == null | companyId == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetStudioDropList(cn, companyId, siteId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Studio found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateStudioStaff(string cn, CreateStudioStaffRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Studio Staff cannot be empty."
                };
            }

            var result = await _dataHelper.STD_CreateStudioStaff(cn, request.StudioId, request.StaffId, request.RoleId, request.StartDate, request.EndDate, request.CompanyId, request.SiteId, request.UserName, request.Action);


            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetProtocolVersionList(string cn, int companyId, int protocolId)
        {
            if (protocolId == null | companyId == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetProtocolVersionList(cn, companyId, protocolId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Protocol found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }
       
        public async Task<BaseResponse> GetStudioData(string cn, int companyId, int siteId, int studyId)
        {
            if (siteId == null | studyId == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.STD_GetStudioData(cn, companyId, siteId, studyId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No Studio found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> PreAssignVolunteersToStudy(string cn, PreAssignVolunteersToStudyRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            if (request.VolunteerIds == null || request.VolunteerIds.Count == 0)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No volunteers selected for pre-assignment."
                };
            }

            // Create DataTable for volunteer IDs to match IntListUDT structure
            var dtVolunteerIds = new System.Data.DataTable();
            dtVolunteerIds.Columns.Add("Value", typeof(int));
            foreach (var volunteerId in request.VolunteerIds)
            {
                dtVolunteerIds.Rows.Add(volunteerId);
            }

            var result = await _dataHelper.VLT_PreAssignVolunteersToStudy(cn, request.CompanyId, request.SiteId,
                request.StudyId, dtVolunteerIds, request.Username);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> RemovePreAssigned(string cn, PreAssignVolunteersRemoveRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            if (request.StudyId == null || request.VolunteerId == 0)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No volunteers selected for remove pre assigned."
                };
            }

            var result = await _dataHelper.VLT_RemovePreAssigned(cn, request.CompanyId, request.SiteId,
                request.StudyId, request.VolunteerId, request.Username);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }
    }
}
