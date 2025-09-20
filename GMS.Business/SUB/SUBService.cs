using GMS.Data.DataHelper;
using GMS.Objects.API;
using GMS.Objects.SUB;

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

        public async Task<BaseResponse> CreateSubjectData(string cn, CreateSubjectDataRequest request)
        {
            if (request == null || request.SubjectData == null || request.SubjectData.Count == 0)
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Subject Data cannot be empty."
                };
            }

            var dt = Helper.HelperUDT.ListToDataTable(request.SubjectData);

            var result = await _dataHelper.SUB_CreateSubjectData(cn, dt);

            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }

        public async Task<BaseResponse> CreateSubject(string cn, CreateSubjectRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.FirstName))
            {
                return new BaseResponse
                {
                    Success = false,
                    Message = "Subject cannot be empty."
                };
            }


            var result = await _dataHelper.SUB_CreateSubject(cn, request.FirstName, request.LastName, request.DateOfBirth, request.SocialSecurityNumber,
                request.Email, request.Phone, request.AddressId, request.Id, request.CompanyId);


            return new BaseResponse
            {
                Data = null,
                Message = result.ResultMessage,
                Success = result.Result >= 0,
            };
        }
    }
}
