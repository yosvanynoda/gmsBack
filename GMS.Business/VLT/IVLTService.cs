using GMS.Objects.API;
using GMS.Objects.VLT;
using GMS.Objects.General;
using GMS.Objects.STD;


namespace GMS.Business.VLT
{
    public interface IVLTService
    {
        Task<BaseResponse> CreateVolunteerData(string cn, CreateVolunteerDataRequest request);

        Task<BaseResponse> UpdateVolunteerData(string cn, CreateVolunteerDataRequest request);

        Task<BaseResponse> GetVolunteerList(string cn, SiteRequest request);

        Task<BaseResponse> GetVolunteerData(string cn, VolunteerRequest request);

        Task<BaseResponse> GetVLTStatusDropList(string cn, GeneralRequest request);

        Task<BaseResponse> SearchVolunteersForStudy(string cn, VolunteerSearchRequest request);

        Task<BaseResponse> GetVolunteerHistory(string cn, VolunteerRequest request);

        Task<BaseResponse> GetVolunteerPreSelectedList(string cn, StudioDataRequest request);
    }
}
