﻿using AutoMapper;
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

    [HttpGet("{id}", Name = "GetBoard")]
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

    [HttpPost]
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

    [HttpPatch("{id}")]
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

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteBoard(int id)
    {
        await _boardRepo.Delete(id);
        return NoContent();
    }
}
