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
public class CardsController : ControllerBase
{
    private readonly ICardRepository _cardRepo;
    private readonly IListRepository _listRepo;
    private readonly ActivityService _activityService;
    private readonly IMapper _mapper;

    public CardsController(ICardRepository cardRepo,
        IListRepository listRepo,
        IMapper mapper, ActivityService activityService)
    {
        _cardRepo = cardRepo ?? throw new ArgumentNullException(nameof(cardRepo));
        _listRepo = listRepo ?? throw new ArgumentNullException(nameof(listRepo));
        _activityService = activityService ?? throw new ArgumentNullException(nameof(activityService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CardDto>>> GetAllCards()
    {
        try
        {
            var cards = await _cardRepo.GetAllAsync();
            if (!cards.Any())
            {
                return NotFound();
            }

            return Ok(cards);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet("{id}", Name = "GetCard")]
    public async Task<ActionResult<CardDto>> GetCardById(int id)
    {
        try
        {
            var card = await _cardRepo.GetByIdAsync(id);
            if (card is null)
            {
                return NotFound();
            }

            return Ok(card);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<CardDto>> CreateCard(int listId, CardForCreationDto card)
    {
        var list = await _listRepo.GetByIdAsync(listId);
        if (list is null)
        {
            return NotFound();
        }

        var cardToSave = new CardDto()
        {
            Name = card.Name,
            Description = card.Description == null ? "Task description should be unambiguous, accurate, factual." : card.Description,
            Priority = card.Priority,
            DueDate = (DateTime)(card.DueDate == null ? DateTime.UtcNow.AddDays(1) : card.DueDate),
            ListId = listId
        };

        var addedCard = await _cardRepo.AddAsync(_mapper.Map<Entities.Card>(cardToSave));

        return CreatedAtRoute("GetCard",
            new
            {
                id = addedCard.Id
            },
        addedCard);
    }

    [HttpPatch("{cardId}")]
    public async Task<ActionResult> PartiallyUpdateCard(
        int cardId,
        JsonPatchDocument<CardForUpdateDto> patchDocument)
    {
        var card = await _cardRepo.GetByIdAsync(cardId);
        if (card is null)
        {
            return NotFound();
        }

        await _activityService.AddActivities(card, patchDocument);

        var cardToPatch = _mapper.Map<CardForUpdateDto>(card);

        patchDocument.ApplyTo(cardToPatch, ModelState);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (!TryValidateModel(cardToPatch))
        {
            return BadRequest(ModelState);
        }

        _mapper.Map(cardToPatch, card);

        await _cardRepo.Update(card);

        return NoContent();
    }

    [HttpDelete("{cardId}")]
    public async Task<ActionResult> DeleteCard(int cardId)
    {
        await _cardRepo.Delete(cardId);
        return NoContent();
    }
}