using GMS.Objects.API;
using GMS.Objects.General;
using GMS.Objects.STD;

namespace GMS.Business.STD
{
    public interface ISTDService
    {
        Task<BaseResponse> CreateMonitor(string cn, CreateMonitorRequest request);

        Task<BaseResponse> CreateProtocol(string cn, CreateProtocolRequest request);

        Task<BaseResponse> CreateSponsor(string cn, CreateSponsorRequest request);

        Task<BaseResponse> CreateStudioData(string cn, CreateStudioDataRequest request);

        Task<BaseResponse> UpdateStudioData(string cn, CreateStudioDataRequest request);

        Task<BaseResponse> CreateStudioDoc(string cn, CreateStudioDocRequest request);

        Task<BaseResponse> GetMonitorList(string cn, GeneralRequest request);

        Task<BaseResponse> GetProtocolList(string cn, GeneralRequest request);

        Task<BaseResponse> GetSponsorList(string cn, GeneralRequest request);

        Task<BaseResponse> GetStudioList(string cn, int companyId, int siteId);

        Task<BaseResponse> GetSubjectList(string cn, GeneralRequest request);

        Task<BaseResponse> GetStudioDocList(string cn, GeneralRequest request);

        Task<BaseResponse> GetSponsorDropList(string cn, GeneralRequest request);

        Task<BaseResponse> GetMonitorDropList(string cn, int companyId, int sponsorId);

        Task<BaseResponse> GetStaffDropList(string cn, int companyId, int siteId);

        Task<BaseResponse> GetStudioDropList(string cn, int companyId, int sponsorId);

        Task<BaseResponse> CreateStudioStaff(string cn, CreateStudioStaffRequest request);

        Task<BaseResponse> GetProtocolVersionList(string cn, int companyId, int protocolId);

        Task<BaseResponse> GetStudioData(string cn, int companyId, int siteId, int studyId);
    }
}
