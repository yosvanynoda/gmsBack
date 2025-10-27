
using GMS.Business.GNR;
using GMS.Objects.General;
using GMS.Objects.GNR;
using GMS.Objects.VLT;
using Microsoft.AspNetCore.Mvc;

namespace GMS.Services.Controllers.v1.GNR
{
    //[Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class GNRController(IGNRService service, IConfiguration config) : ControllerBase
    {
        private readonly IGNRService _service = service;

        private readonly IConfiguration _config = config;

       

        [HttpPost]
        [Route("api/v{version:apiVersion}/[controller]/getdashboardstudystats")]
        public async Task<IActionResult> GetDashboardStudyStats(SiteRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request data.");
                }

                var cn = _config.GetConnectionString("gmsCS") ?? "";

                var result = await _service.GetDashboardStudyStats(cn, request);

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
