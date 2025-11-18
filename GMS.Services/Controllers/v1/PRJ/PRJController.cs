using GMS.Business.PRJ;
using GMS.Objects.PRJ;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Services.Controllers.v1.PRJ
{

    [ApiController]
    [ApiVersion("1.0")]
    public class PRJController(IPRJService service, IConfiguration config) : ControllerBase
    {

        private readonly IPRJService _service = service;

        private readonly IConfiguration _config = config;

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createstudiosubject")]
        public async Task<IActionResult> CreateStudioSubject(CreateStudioSubjectRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateStudioSubject(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/createvisit")]
        public async Task<IActionResult> CreateVisit(CreateVisitRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateVisit(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/cancelvisit")]
        public async Task<IActionResult> CancelVisit(CancelVisitRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CancelVisit(cn, request);

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
