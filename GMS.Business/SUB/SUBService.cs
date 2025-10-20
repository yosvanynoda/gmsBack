using GMS.Data.DataHelper;
using GMS.DBModels.VLT;
using GMS.Objects.API;
using GMS.Objects.General;
using GMS.Objects.SUB;
using GMS.Objects.VLT;


namespace GMS.Business.SUB
{
    public class SUBService(IDataHelper dataHelper) : ISUBService
    {
        private readonly IDataHelper _dataHelper = dataHelper;

        public async Task<BaseResponse> CreateContact(string cn, CreateContactRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Name))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Create Contact cannot be empty."
                };
            }

            var result = await _dataHelper.SUB_CreateContact(cn, request.SubjectId, request.Name, request.Phone, request.Relation, request.CompanyId);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateRandomCode(string cn, CreateRandomCodeRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Code))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Random Code cannot be empty."
                };
            }


            var result = await _dataHelper.SUB_CreateRandomCode(cn, request.SubjectId, request.StudioId, request.Code, request.CompanyId);


            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }
        public async Task<BaseResponse> GetSubjectList(string cn, SiteRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.SUB_GetSubjectList(cn, request.CompanyId, request.SiteId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No subjects found."
                };
            }

            return new BaseResponse
            {
                Data = result?.Data,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateSubject(string cn, CreateSubjectRequest request, string subjectCode)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Subject cannot be empty."
                };
            }

            var dtSubject = Helper.HelperUDT.ListToDataTable(request.SubjectData);

            var result = await _dataHelper.SUB_CreateSubject(cn, dtSubject, subjectCode);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> GetSubjectData(string cn, SubjectRequest request)
        {
            if (request == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Request cannot be empty."
                };
            }

            var result = await _dataHelper.SUB_GetSubjectData(cn, request.CompanyId, request.SiteId, request.SubjectId);

            if (result == null)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "No subject found."
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
