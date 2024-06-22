using Microsoft.AspNetCore.JsonPatch;
using TaskBoard.API.Entities;
using TaskBoard.API.Models;

namespace TaskBoard.API.Services;

public class ActivityService
{
    private readonly IActivityRepository _repo;
    private readonly IListRepository _listRepo;

    public ActivityService(IActivityRepository repository, IListRepository listRepository)
    {
        _repo = repository ?? throw new ArgumentNullException(nameof(repository));
        _listRepo = listRepository ?? throw new ArgumentNullException(nameof(listRepository));
    }

    public async Task AddActivities(Card card, JsonPatchDocument<CardForUpdateDto> patchDocument)
    {
        var activities = new List<Activity>();
        var list = await _listRepo.GetByIdWithoutDetails(card.ListId);

        foreach (var op in patchDocument.Operations)
        {
            switch (op.path.ToUpperInvariant())
            {
                case "LISTID":
                    activities.Add(
                    new Activity("moved", list!.Name, op.value.ToString()!, op.value.ToString()!, card.Name)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
                case "NAME":
                    activities.Add(
                    new Activity("renamed", card.Name, op.value.ToString()!, list!.Name, op.value.ToString()!)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
                case "DESCRIPTION":
                    activities.Add(
                    new Activity("changed the description", card.Description, op.value.ToString()!, list!.Name, card.Name)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
                case "PRIORITY":
                    activities.Add(
                    new Activity("changed the priority", card.Priority.ToString(), op.value.ToString()!, list!.Name, card.Name)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
                case "DUEDATE":
                    activities.Add(
                    new Activity("changed the due date", card.DueDate.ToString(), op.value.ToString()!, list!.Name, card.Name)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
            }
        }

        await _repo.AddRangeAsync(activities);
    }
}
