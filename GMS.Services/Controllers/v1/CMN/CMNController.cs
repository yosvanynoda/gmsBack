using GMS.Business.CMN;
using GMS.Objects.CMN;
using GMS.Objects.General;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Services.Controllers.V1.CMN
{

    [ApiController]
    [ApiVersion("1.0")]
    public class CMNController(ICMNService service, IConfiguration config) : ControllerBase
    {
        private readonly ICMNService _service = service;

        private readonly IConfiguration _config = config;

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createallergy")]
        public async Task<IActionResult> CreateAllergy(CreateAllergyRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateAllergy(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createcompany")]
        public async Task<IActionResult> CreateCompany(CreateCompanyRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateCompany(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createdisease")]
        public async Task<IActionResult> CreateDisease(CreateDiseaseRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateDisease(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createdoctype")]
        public async Task<IActionResult> CreateDocType(CreateDocTypeRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateDocType(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createethnicity")]
        public async Task<IActionResult> CreateEthnicity(CreateEthnicityRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateEthnicity(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/creategender")]
        public async Task<IActionResult> CreateGender(CreateGenderRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateGender(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createlanguage")]
        public async Task<IActionResult> CreateLanguage(CreateLanguageRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateLanguage(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createmedication")]
        public async Task<IActionResult> CreateMedication(CreateMedicationRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateMedication(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createrace")]
        public async Task<IActionResult> CreateRace(CreateRaceRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateRace(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createrelationtype")]
        public async Task<IActionResult> CreateRelationType(CreateRelationTypeRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateRelationType(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createroletype")]
        public async Task<IActionResult> CreateRoleType(CreateRoleTypeRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateRoleType(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createsite")]
        public async Task<IActionResult> CreateSite(CreateSiteRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateSite(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createsponsortype")]
        public async Task<IActionResult> CreateSponsorType(CreateSponsorTypeRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateSponsorType(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createstaff")]
        public async Task<IActionResult> CreateStaff(CreateStaffRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateStaff(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createtask")]
        public async Task<IActionResult> CreateTask(CreateTaskRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateTask(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

       

       


        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createstaffdocument")]
        public async Task<IActionResult> CreateStaffDocument(CreateStaffDocumentRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateStaffDocument(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createtasktype")]
        public async Task<IActionResult> CreateTaskType(CreateTaskTypeRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateTaskType(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getdiseaselist")]
        public async Task<IActionResult> GetDiseaseList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetDiseaseList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getallergylist")]
        public async Task<IActionResult> GetAllergyList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetAllergyList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getmedicationlist")]
        public async Task<IActionResult> GetMedicationList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetMedicationList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getdoctypelist")]
        public async Task<IActionResult> GetDocType(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetDocTypeList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getrelationtypelist")]
        public async Task<IActionResult> GetRelationType(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetRelationTypeList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getroletypelist")]
        public async Task<IActionResult> GetRoleTypeList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetRoleTypeList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getsitelist")]
        public async Task<IActionResult> GetSiteList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetSiteList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getstaffdocument")]
        public async Task<IActionResult> GetStaffDocument(StaffDocRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetStaffDocumentList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getsponsortypelist")]
        public async Task<IActionResult> GetSponsorTypeList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetSponsorTypeList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getstafflist")]
        public async Task<IActionResult> GetStaffList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetStaffList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getstaffstudio")]
        public async Task<IActionResult> GetStaffStudio([FromBody] dynamic request)
        {
            try
            {
                var cn = _config.GetConnectionString("gmsCS") ?? "";

                int companyId = request.CompanyId;
                int siteId = request.SiteId;
                int? staffId = request.StaffId;
                int? studioId = request.StudioId;

                var result = await _service.GetStaffStudio(cn, companyId, siteId, staffId, studioId);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/gettasklist")]
        public async Task<IActionResult> GetTaskList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetTaskList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/gettasktypelist")]
        public async Task<IActionResult> GetTaskTypeList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetTaskTypeList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getethnicitylist")]
        public async Task<IActionResult> GetEthnicityList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetEthnicityList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getlanguagelist")]
        public async Task<IActionResult> GetLanguageList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetLanguageList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getgenderlist")]
        public async Task<IActionResult> GetGenderList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetGenderList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getracelist")]
        public async Task<IActionResult> GetRaceList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetRaceList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createcro")]
        public async Task<IActionResult> CreateCRO(CreateCRORequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateCRO(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getcrolist")]
        public async Task<IActionResult> GetCROList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetCROList(cn, request);

                if (!result.Success)
                {
                    return BadRequest(result.Message);
                }

                return Ok(result);

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
