using GMS.Objects.API;
using GMS.Objects.VLT;
using GMS.Objects.General;


namespace GMS.Business.VLT
{
    public interface IVLTService
    {
        Task<BaseResponse> CreateVolunteerData(string cn, CreateVolunteerDataRequest request);

        Task<BaseResponse> UpdateVolunteerData(string cn, CreateVolunteerDataRequest request);

        Task<BaseResponse> GetVolunteerList(string cn, SiteRequest request);

        Task<BaseResponse> GetVolunteerData(string cn, VolunteerRequest request);
    }
}
