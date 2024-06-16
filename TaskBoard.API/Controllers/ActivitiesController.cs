using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TaskBoard.API.Models;
using TaskBoard.API.Services;

namespace TaskBoard.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[EnableCors("OpenCORSPolicy")]
public class ActivitiesController : ControllerBase
{
    private readonly IActivityRepository _actRepo;

    public ActivitiesController(IActivityRepository activityRepo)
    {
        _actRepo = activityRepo ?? throw new ArgumentNullException(nameof(activityRepo));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ActivityDto>>> GetAllActivities()
    {
        try
        {
            var act = await _actRepo.GetAllAsync();
            if (!act.Any())
            {
                return NotFound();
            }

            return Ok(act);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet("{boardId}", Name = "GetActivities")]
    public async Task<ActionResult<ActivityDto>> GetByBoardId(int boardId)
    {
        try
        {
            var list = await _actRepo.GeByBoardIdAsync(boardId);
            if (list is null)
            {
                return NotFound();
            }

            return Ok(list);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
