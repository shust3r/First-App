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

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BoardDto>>> GetAll()
    {
        try
        {
            var boards = await _boardRepo.GetAllAsync();
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

    [HttpGet("{id}", Name = "GetBoard")]
    public async Task<ActionResult<BoardDto>> GetBoardById(int id)
    {
        try
        {
            var boards = await _boardRepo.GetByIdAsync(id);
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

    [HttpPatch("{boardId}")]
    public async Task<ActionResult> UpdateBoard(int boardId,
        JsonPatchDocument<BoardForUpdateDto> patchDocument)
    {
        var board = await _boardRepo.GetByIdAsync(boardId);
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

    [HttpPost]
    public async Task<ActionResult<BoardDto>> CreateBoard(BoardForCreationDto board)
    {
        var boardToAdd = new BoardDto()
        {
            Name = board.Name
        };

        var addedBoard = await _boardRepo.AddAsync(_mapper.Map<Board>(boardToAdd));

        return CreatedAtRoute("GetList",
            new
            {
                id = addedBoard.Id
            },
            addedBoard);
    }

    [HttpDelete("{boardId}")]
    public async Task<ActionResult> DeleteBoard(int boardId)
    {
        await _boardRepo.Delete(boardId);
        return NoContent();
    }
}
