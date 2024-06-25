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
    public async Task<ActionResult<IEnumerable<ActivityDto>>> GetActivities(int? boardId, int? cardId)
    {
        try
        {
            if (boardId is not null)
            {
                var list = await _actRepo.GeByBoardIdAsync(boardId!.Value);
                if (list is null)
                {
                    return NotFound();
                }

                return Ok(list);
            }
            if (cardId is not null)
            {
                var list = await _actRepo.GeByCardIdAsync(cardId!.Value);
                if (list is null)
                {
                    return NotFound();
                }

                return Ok(list);
            }

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
}
