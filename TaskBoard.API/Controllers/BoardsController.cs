using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using TaskBoard.API.Entities;
using TaskBoard.API.Models;
using TaskBoard.API.Services;

namespace TaskBoard.API.Controllers;

[Route("api/[controller]")]
[ApiController]
[EnableCors("OpenCORSPolicy")]
[Produces("application/json")]
public class BoardsController : ControllerBase
{
    private readonly IBoardRepository _boardRepo;
    private readonly IMapper _mapper;

    public BoardsController(
        IBoardRepository boardRepository,
        IMapper mapper)
    {
        _boardRepo = boardRepository ?? throw new ArgumentNullException(nameof(boardRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    /// <summary>
    /// Get list of all boards
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /Boards
    /// </remarks>
    /// <returns>Returns the list of boards</returns>
    /// <response code="200">Success</response>
    /// <response code="404">NotFound</response>
    /// <response code="500">ServerError</response>
    [HttpGet]
    [ProducesResponseType(typeof(List<BoardDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<BoardDto>>> GetAll()
    {
        try
        {
            var boards = await _boardRepo.GetAllWithoutDetails();

            if (!boards.Any())
            {
                return NotFound();
            }

            return Ok(boards);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    /// <summary>
    /// Get the board by ID
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /Boards/{id}
    /// </remarks>
    /// <param name="id" example="1">Board ID</param>
    /// <returns>Returns the board by ID</returns>
    /// <response code="200">Success</response>
    /// <response code="404">NotFound</response>
    /// <response code="500">ServerError</response>
    [HttpGet("{id}", Name = "GetBoard")]
    [ProducesResponseType(typeof(BoardDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<BoardDto>> GetBoardById(int id)
    {
        try
        {
            var boards = await _boardRepo.GetByIdWithoutDetails(id);
            if (boards is null)
            {
                return NotFound();
            }

            return Ok(boards);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    /// <summary>
    /// Create new board
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /Boards
    ///     {
    ///         "Name": null
    ///     }
    /// </remarks>
    /// <param name="board"></param>
    /// <returns>Returns the created board</returns>
    /// <response code="200">Success</response>
    [HttpPost]
    [ProducesResponseType(typeof(BoardDto), StatusCodes.Status200OK)]
    public async Task<ActionResult<BoardDto>> CreateBoard(BoardForCreationDto board)
    {
        var boardToAdd = new BoardDto()
        {
            Name = board.Name
        };

        var addedBoard = await _boardRepo.AddAsync(_mapper.Map<Board>(boardToAdd));

        return CreatedAtRoute("GetBoard",
            new
            {
                id = addedBoard.Id
            },
            addedBoard);
    }

    /// <summary>
    /// Patch existing board
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     PATCH /Boards/{id}
    ///     [{
    ///         "operationType": 0,
    ///         "path": "Name",
    ///         "op": "replace",
    ///         "value": null
    ///     }]
    /// </remarks>
    /// <param name="id">Board ID</param>
    /// <param name="patchDocument"></param>
    /// <returns>Returns the updated board</returns>
    /// <response code="204">Success</response>
    /// <response code="400">BadRequest</response>
    /// <response code="404">NotFound</response>
    [HttpPatch("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> UpdateBoard(int id,
        JsonPatchDocument<BoardForUpdateDto> patchDocument)
    {
        var board = await _boardRepo.GetByIdWithoutDetails(id);
        if (board is null)
        {
            return NotFound();
        }

        var boardToPatch = _mapper.Map<BoardForUpdateDto>(board);

        patchDocument.ApplyTo(boardToPatch, ModelState);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (!TryValidateModel(boardToPatch))
        {
            return BadRequest(ModelState);
        }

        _mapper.Map(boardToPatch, board);
        await _boardRepo.Update(board);

        return NoContent();
    }

    /// <summary>
    /// Delete existing board
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     DELETE /Boards/{id}
    /// </remarks>
    /// <param name="id">Board id</param>
    /// <returns>Returns 204 (No Content)</returns>
    /// <response code="204">Success</response>
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult> DeleteBoard(int id)
    {
        await _boardRepo.Delete(id);
        return NoContent();
    }
}
