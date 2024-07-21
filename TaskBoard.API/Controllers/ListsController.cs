using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using TaskBoard.API.Models;
using TaskBoard.API.Services;

namespace TaskBoard.API.Controllers;


[Route("api/[controller]")]
[ApiController]
[EnableCors("OpenCORSPolicy")]
[Produces("application/json")]
public class ListsController : ControllerBase
{
    private readonly IListRepository _repo;
    private readonly IMapper _mapper;

    public ListsController(IListRepository repo, IMapper mapper)
    {
        _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    /// <summary>
    /// Get all lists
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /Lists
    /// </remarks>
    /// <returns>Returns all the lists</returns>
    /// <response code="200">Success</response>
    /// <response code="404">NotFound</response>
    /// <response code="500">ServerError</response>
    [HttpGet]
    [ProducesResponseType(typeof(List<ListDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<ListDto>>> GetAllLists()
    {
        try
        {
            var lists = await _repo.GetAllWithoutDetailsAsync();
            if (!lists.Any())
            {
                return NotFound();
            }

            return Ok(lists);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    /// <summary>
    /// Get the board lists by board ID
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /Lists/{id}
    /// </remarks>
    /// <param name="boardId" example="1">Board ID</param>
    /// <returns>Returns the board lists by board ID</returns>
    /// <response code="200">Success</response>
    /// <response code="404">NotFound</response>
    /// <response code="500">ServerError</response>
    [HttpGet("{boardId}")]
    [ProducesResponseType(typeof(ListDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ListDto>> GetListsByBoardId(int boardId)
    {
        try
        {
            var list = await _repo.GetAllByBoardId(boardId);
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

    /// <summary>
    /// Create new list
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /Lists
    ///     {
    ///         "Name": null,
    ///     }
    /// </remarks>
    /// <param name="boardId"></param>
    /// <param name="list"></param>
    /// <returns>Returns the created list</returns>
    /// <response code="200">Success</response>
    /// <response code="500">ServerError</response>
    [HttpPost("{boardId}")]
    [ProducesResponseType(typeof(ListDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ListDto>> CreateList(int boardId, ListForCreationDto list)
    {
        try
        {
            var listToAdd = new ListDto()
            {
                Name = list.Name,
                BoardId = boardId
            };

            var addedList = await _repo.AddAsync(_mapper.Map<Entities.List>(listToAdd));

            var result = await _repo.GetByIdWithoutDetails(addedList.Id);
            return Ok(result);
        }
        catch (Exception ex)
        {

            return StatusCode(500, ex.Message);
        }
    }

    /// <summary>
    /// Patch existing list
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     PATCH /Lists/{id}
    ///     [{
    ///         "operationType": 0,
    ///         "path": "Name",
    ///         "op": "replace",
    ///         "value": null
    ///     }]
    /// </remarks>
    /// <param name="listId">List ID</param>
    /// <param name="patchDocument"></param>
    /// <returns>Returns the updated list</returns>
    /// <response code="204">Success</response>
    /// <response code="400">BadRequest</response>
    /// <response code="404">NotFound</response>
    [HttpPatch("{listId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> PartiallyUpadteList(
        int listId,
        JsonPatchDocument<ListForUpdateDto> patchDocument)
    {
        var list = await _repo.GetByIdWithoutDetails(listId);
        if (list is null)
        {
            return NotFound();
        }

        var listToPatch = _mapper.Map<ListForUpdateDto>(list);

        patchDocument.ApplyTo(listToPatch, ModelState);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (!TryValidateModel(listToPatch))
        {
            return BadRequest(ModelState);
        }

        _mapper.Map(listToPatch, list);
        await _repo.Update(list);

        return NoContent();
    }

    /// <summary>
    /// Delete existing list
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     DELETE /Lists/{id}
    /// </remarks>
    /// <param name="listId">List id</param>
    /// <returns>Returns 204 (No Content)</returns>
    /// <response code="204">Success</response>
    [HttpDelete("{listId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult> DeleteList(int listId)
    {
        await _repo.Delete(listId);
        return NoContent();
    }
}