using GMS.Business.VLT;
using GMS.Objects.General;
using GMS.Objects.VLT;
using Microsoft.AspNetCore.Mvc;


    namespace GMS.Services.Controllers.V1.VLT
{
    //[Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class VLTController(IVLTService service, IConfiguration config) : ControllerBase
    {
        private readonly IVLTService _service = service;

        private readonly IConfiguration _config = config;

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createvolunteer")]
        public async Task<IActionResult> CreateVolunteer(CreateVolunteerDataRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateVolunteerData(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/updatevolunteer")]
        public async Task<IActionResult> UpdateVolunteer(CreateVolunteerDataRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.UpdateVolunteerData(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getvolunteerlist")]
        public async Task<IActionResult> GetVolunteerList(SiteRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetVolunteerList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getvolunteerdata")]
        public async Task<IActionResult> GetVolunteerData(VolunteerRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetVolunteerData(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/getvltstatusdroplist")]
        public async Task<IActionResult> GetVLTStatusDropList(GeneralRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetVLTStatusDropList(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/searchvolunteersforstudy")]
        public async Task<IActionResult> SearchVolunteersForStudy(VolunteerSearchRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.SearchVolunteersForStudy(cn, request);

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
