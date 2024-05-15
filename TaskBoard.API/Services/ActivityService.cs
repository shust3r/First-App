using Microsoft.AspNetCore.JsonPatch;
using TaskBoard.API.Entities;
using TaskBoard.API.Models;

namespace TaskBoard.API.Services;

public class ActivityService
{
    private readonly IActivityRepository _repo;

    public ActivityService(IActivityRepository repository)
    {
        _repo = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public async Task AddActivities(Card card, JsonPatchDocument<CardForUpdateDto> patchDocument)
    {
        var activities = new List<Activity>();

        foreach (var op in patchDocument.Operations)
        {
            switch (op.path.ToUpperInvariant())
            {
                case "NAME":
                    activities.Add(
                    new Activity("renamed", card.Name, op.value.ToString()!)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
                case "DESCRIPTION":
                    activities.Add(
                    new Activity("changed the description", card.Description, op.value.ToString()!)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
                case "PRIORITY":
                    activities.Add(
                    new Activity("changed the priority", card.Priority.ToString(), op.value.ToString()!)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
                case "LISTID":
                    activities.Add(
                    new Activity("moved", card.ListId.ToString(), op.value.ToString()!)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
                case "DUEDATE":
                    activities.Add(
                    new Activity("changed", card.DueDate.ToString(), op.value.ToString()!)
                    {
                        OperationDate = DateTime.UtcNow,
                        CardId = card.Id
                    });
                    break;
            }
        }

        await _repo.AddRange(activities);
    }
}
