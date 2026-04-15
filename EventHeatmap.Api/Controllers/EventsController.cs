using EventHeatmap.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace EventHeatmap.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    private readonly AppDbContext _context;

    public EventsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("heatmap")]
    public async Task<IActionResult> GetHeatmapData()
    {
        // For the prototype, we return all events. 
        // In the future, we can add time-range filtering (e.g., "this weekend").
        var events = await _context.Events
            .Select(e => new
            {
                e.Title,
                e.Latitude,
                e.Longitude,
                e.EstimatedAttendance,
                e.Category,
                e.StartTime
            })
            .ToListAsync();

        return Ok(events);
    }
}
