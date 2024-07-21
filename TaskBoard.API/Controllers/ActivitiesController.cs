using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TaskBoard.API.Models;
using TaskBoard.API.Services;

namespace TaskBoard.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[EnableCors("OpenCORSPolicy")]
[Produces("application/json")]
public class ActivitiesController : ControllerBase
{
    private readonly IActivityRepository _actRepo;

    public ActivitiesController(IActivityRepository activityRepo)
    {
        _actRepo = activityRepo ?? throw new ArgumentNullException(nameof(activityRepo));
    }

    /// <summary>
    /// Get the list of activities
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /Activities?boardId=1&amp;cardId=1
    /// </remarks>
    /// <param name="boardId" example="1">Board ID</param>
    /// <param name="cardId" example="1">Card ID</param>
    /// <returns>Returns the list of activities</returns>
    /// <response code="200">Success</response>
    /// <response code="404">NotFound</response>
    /// <response code="500">ServerError</response>
    [HttpGet]
    [ProducesResponseType(typeof(List<ActivityDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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
