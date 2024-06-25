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
public class ListsController : ControllerBase
{
    private readonly IListRepository _repo;
    private readonly IMapper _mapper;

    public ListsController(IListRepository repo, IMapper mapper)
    {
        _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ListDto>>> GetAllLists()
    {
        try
        {
            var lists = await _repo.GetAllWithDetailsAsync();
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

    [HttpGet("{boardId}")]
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

    [HttpPost("{boardId}")]
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

    [HttpPatch("{listId}")]
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

    [HttpDelete("{listId}")]
    public async Task<ActionResult> DeleteList(int listId)
    {
        await _repo.Delete(listId);
        return NoContent();
    }
}