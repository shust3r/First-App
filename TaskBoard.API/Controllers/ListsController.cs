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

    public ListsController(IListRepository repo,
        IMapper mapper)
    {
        _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ListDto>>> GetAllLists()
    {
        try
        {
            var lists = await _repo.GetAllAsync();
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

    [HttpGet("{id}", Name = "GetList")]
    public async Task<ActionResult<ListDto>> GetListById(int id)
    {
        try
        {
            var list = await _repo.GetByIdAsync(id);
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

    [HttpPost]
    public async Task<ActionResult<ListDto>> CreateList(ListForCreationDto list)
    {
        var listToAdd = new ListDto()
        {
            Name = list.Name
        };

        var addedList = await _repo.AddAsync(_mapper.Map<Entities.List>(listToAdd));

        return CreatedAtRoute("GetList",
            new
            {
                id = addedList.Id
            },
            addedList);
    }

    [HttpPatch("{listId}")]
    public async Task<ActionResult> PartiallyUpadteList(
        int listId,
        JsonPatchDocument<ListForUpdateDto> patchDocument)
    {
        var list = await _repo.GetByIdAsync(listId);
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