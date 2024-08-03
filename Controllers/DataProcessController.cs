using Microsoft.AspNetCore.Mvc;
using TrackWithCustomHeaders.Models;

namespace TrackWithCustomHeaders.Controllers;

public class DataProcessController(ILogger<DataProcessController> logger) : Controller
{
    [HttpGet]
    [Route("simpleDtoExtract")]
    public IActionResult SimpleDtoExtract([FromHeader] ReferenceDto reference)
    {
        logger.LogInformation($"X-Correlation-ID: {reference.CorrelationId}");
        logger.LogInformation($"X-Trace-ID: {reference.TraceId}");

        return Ok(reference.CorrelationId);
    }
}