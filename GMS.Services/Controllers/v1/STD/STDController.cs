using GMS.Business.STD;
using GMS.Objects.General;
using GMS.Objects.STD;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Services.Controllers.v1.STD
{
    //[Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class STDController(ISTDService service, IConfiguration config) : ControllerBase
    {
        private readonly ISTDService _service = service;

        private readonly IConfiguration _config = config;

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createmonitor")]
        public async Task<IActionResult> CreateMonitor(CreateMonitorRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateMonitor(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/createprotocol")]
        public async Task<IActionResult> CreateProtocol(CreateProtocolRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateProtocol(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/createsponsor")]
        public async Task<IActionResult> CreateSponsor(CreateSponsorRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateSponsor(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/createstudiodata")]
        public async Task<IActionResult> CreateStudioData(CreateStudioDataRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateStudioData(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/updatestudiodata")]
        public async Task<IActionResult> UpdateStudioData(CreateStudioDataRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.UpdateStudioData(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/createstudiodoc")]
        public async Task<IActionResult> CreateStudioDoc(CreateStudioDocRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateStudioDoc(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getmonitorlist")]
        public async Task<IActionResult> GetMonitorList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetMonitorList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getprotocollist")]
        public async Task<IActionResult> GetProtocolList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetProtocolList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getsponsorlist")]
        public async Task<IActionResult> GetSponsorList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetSponsorList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getstudiolist")]
        public async Task<IActionResult> GetStudioList(StudioRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetStudioList(cn, request.CompanyId, request.SiteId);

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
        [Route("api/v{version:apiVersion}/[controller]/getsubjectlist")]
        public async Task<IActionResult> GetSubjectList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetSubjectList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getstudiodoclist")]
        public async Task<IActionResult> GetStudioDocList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetStudioDocList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getsponsordroplist")]
        public async Task<IActionResult> GetSponsorDropList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetSponsorDropList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getdiseasedroplist")]
        public async Task<IActionResult> GetDiseaseDropList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetDiseaseDropList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getcrodroplist")]
        public async Task<IActionResult> GetCroDropList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetCroDropList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getmonitordroplist")]
        public async Task<IActionResult> GetMonitorDropList(int? companyId, int? sponsorId)
        {
            try
            {
                if (companyId == null || sponsorId == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetMonitorDropList(cn, (int)companyId, (int)sponsorId);

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
        [Route("api/v{version:apiVersion}/[controller]/getstaffdroplist")]
        public async Task<IActionResult> GetStaffDropList(int companyId, int siteId)
        {
            try
            {
                if (companyId == null | siteId == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetStaffDropList(cn, companyId, siteId);

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
        [Route("api/v{version:apiVersion}/[controller]/getstudiodroplist")]
        public async Task<IActionResult> GetStudioDropList(int companyId, int siteId)
        {
            try
            {
                if (companyId == null | siteId == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetStudioDropList(cn, companyId, siteId);

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
        [Route("api/v{version:apiVersion}/[controller]/createstudiostaff")]
        public async Task<IActionResult> CreateStudioStaff(CreateStudioStaffRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateStudioStaff(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getprotocolversionlist")]
        public async Task<IActionResult> GetProtocolVersionList(ProtocolVersionRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetProtocolVersionList(cn, request.CompanyId, request.ProtocolId);

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
        [Route("api/v{version:apiVersion}/[controller]/getstudiodata")]
        public async Task<IActionResult> GetStudioData(StudioDataRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetStudioData(cn, request.CompanyId, request.SiteId, request.StudyId);

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
