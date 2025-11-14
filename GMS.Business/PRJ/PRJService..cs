using GMS.Data.DataHelper;
using GMS.Objects.API;
using GMS.Objects.PRJ;

namespace GMS.Business.PRJ
{
    public class PRJService(IDataHelper dataHelper) : IPRJService
    {

        private readonly IDataHelper _dataHelper = dataHelper;

        public async Task<BaseResponse> CreateStudioSubject(string cn, CreateStudioSubjectRequest request)
        {

            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Studio Subject cannot be empty."
                };
            }

            var result = await _dataHelper.PRJ_CreateStudioSubject(cn, request.SubjectId, request.StudioId, request.StartDate, request.EndDate, request.CompanyId);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateVisit(string cn, CreateVisitRequest request)
        {

            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Visit data cannot be empty."
                };
            }

            var result = await _dataHelper.PRJ_CreateVisit(cn, request.VisitId, request.SubjectId, request.StudioId, request.Staffid,  request.VisitDate, request.Notes);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CancelVisit(string cn, CancelVisitRequest request)
        {

            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Visit data cannot be empty."
                };
            }

            var result = await _dataHelper.PRJ_CancelVisit(cn, request.VisitId, request.SubjectId, request.StudioId, request.Notes);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }
    }
}
