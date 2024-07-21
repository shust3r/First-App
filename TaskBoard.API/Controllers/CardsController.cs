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

    /// <summary>
    /// Get all cards by List ID
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /Cards/{id}
    /// </remarks>
    /// <param name="listId" example="1">List ID</param>
    /// <returns>Returns all the cards by List ID</returns>
    /// <response code="200">Success</response>
    /// <response code="404">NotFound</response>
    /// <response code="500">ServerError</response>
    [HttpGet]
    [ProducesResponseType(typeof(CardDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<CardDto>>> GetAllCards(int? listId)
    {
        try
        {
            if (listId is null)
            {
                var cards = await _cardRepo.GetAllAsync();
                if (!cards.Any())
                {
                    return NotFound();
                }
             
                return Ok(cards);
            }
            else
            {
                var cards = await _cardRepo.GetByListIdAsync(listId.Value);
                if (!cards.Any())
                {
                    return NotFound();
                }

                return Ok(cards);
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    /// <summary>
    /// Get card by Card ID
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     GET /Cards/{id}
    /// </remarks>
    /// <param name="id" example="1">Card ID</param>
    /// <returns>Returns the card by Card ID</returns>
    /// <response code="200">Success</response>
    /// <response code="404">NotFound</response>
    /// <response code="500">ServerError</response>
    [HttpGet("{id}", Name = "GetCard")]
    [ProducesResponseType(typeof(CardDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<CardDto>> GetCardById(int id)
    {
        try
        {
            var card = await _cardRepo.GetByCardIdAsync(id);
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

    /// <summary>
    /// Create new card
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     POST /Cards?listId={listId}
    ///     {
    ///         "Name": null,
    ///         "Description": null,
    ///         "Priority": 0
    ///     }
    /// </remarks>
    /// <param name="listId"></param>
    /// <param name="card"></param>
    /// <returns>Returns the created card</returns>
    /// <response code="200">Success</response>
    /// <response code="404">NotFound</response>
    [HttpPost]
    [ProducesResponseType(typeof(CardDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CardDto>> CreateCard(int listId, CardForCreationDto card)
    {
        var list = await _listRepo.GetByIdWithoutDetails(listId);
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

    /// <summary>
    /// Patch existing card
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     PATCH /Cards/{id}
    ///     [{
    ///         "operationType": 0,
    ///         "path": "Name",
    ///         "op": "replace",
    ///         "value": null
    ///     }]
    /// </remarks>
    /// <param name="cardId">Card ID</param>
    /// <param name="patchDocument"></param>
    /// <returns>Returns the updated card</returns>
    /// <response code="204">Success</response>
    /// <response code="400">BadRequest</response>
    /// <response code="404">NotFound</response>
    [HttpPatch("{cardId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> PartiallyUpdateCard(
        int cardId,
        JsonPatchDocument<CardForUpdateDto> patchDocument)
    {
        var card = await _cardRepo.GetByCardIdAsync(cardId);
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

    /// <summary>
    /// Delete existing card
    /// </summary>
    /// <remarks>
    /// Sample request:
    /// 
    ///     DELETE /Cards/{id}
    /// </remarks>
    /// <param name="cardId">Card id</param>
    /// <returns>Returns 204 (No Content)</returns>
    /// <response code="204">Success</response>
    [HttpDelete("{cardId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult> DeleteCard(int cardId)
    {
        await _cardRepo.Delete(cardId);
        return NoContent();
    }
}