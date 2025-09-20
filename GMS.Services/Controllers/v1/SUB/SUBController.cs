using GMS.Business.SUB;
using GMS.Objects.SUB;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Services.Controllers.v1.SUB
{
    //[Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class SUBController(ISUBService service, IConfiguration config) : ControllerBase
    {

        private readonly ISUBService _service = service;

        private readonly IConfiguration _config = config;

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/createcontact")]
        public async Task<IActionResult> CreateContact(CreateContactRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateContact(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/createrandomcode")]
        public async Task<IActionResult> CreateRandomCode(CreateRandomCodeRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateRandomCode(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/createsubjectdata")]
        public async Task<IActionResult> CreateSubjectData(CreateSubjectDataRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateSubjectData(cn, request);

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
        [Route("api/v{version:apiVersion}/[controller]/createsubject")]
        public async Task<IActionResult> CreateSubject(CreateSubjectRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.CreateSubject(cn, request);

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
