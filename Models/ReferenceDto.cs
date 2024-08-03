using Microsoft.AspNetCore.Mvc;

namespace TrackWithCustomHeaders.Models;

public class ReferenceDto
{
    [FromHeader(Name = "X-Correlation-ID")]
    public string? CorrelationId { get; set; }

    [FromHeader(Name = "X-Trace-ID")] 
    public string? TraceId { get; set; }
}