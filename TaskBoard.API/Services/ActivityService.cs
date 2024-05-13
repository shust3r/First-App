using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public class ActivityService
{
    private readonly IActivityRepository _repo;

    public ActivityService(IActivityRepository repository)
    {
        _repo = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public async Task InitActivity(Card card)
    {
        var activity = new Activity("added", "", card.Name)
        {
            OperationDate = DateTime.UtcNow,
            CardId = card.Id,
            ListId = card.ListId
        };

        await _repo.AddAsync(activity, card.Id);
    }

    public async Task AddUpdateActivity(Card oldCard, Card newCard)
    {
        var activities = new List<Activity>();

        if (oldCard.Name != newCard.Name)
        {
            var nameActivity = new Activity("renamed", oldCard.Name, newCard.Name)
            {
                OperationDate = DateTime.UtcNow,
                CardId = oldCard.Id
            };
            activities.Add(nameActivity);
        }

        if (oldCard.Description != newCard.Description)
        {
            var descrActivity = new Activity("changed the description", oldCard.Description, newCard.Description)
            {
                OperationDate = DateTime.UtcNow,
                CardId = oldCard.Id
            };
            activities.Add(descrActivity);
        }

        if (oldCard.Priority != newCard.Priority)
        {
            var priorAcr = new Activity("changed the priority", oldCard.Priority.ToString(), newCard.Priority.ToString())
            {
                OperationDate = DateTime.UtcNow,
                CardId = oldCard.Id
            };
            activities.Add(priorAcr);
        }

        if (oldCard.ListId != newCard.ListId)
        {
            var listAct = new Activity("moved", oldCard.ListId.ToString(), newCard.ListId.ToString())
            {
                OperationDate = DateTime.UtcNow,
                CardId = oldCard.Id
            };
            activities.Add(listAct);
        }

        if (oldCard.DueDate != newCard.DueDate)
        {
            var dateAct = new Activity("changed", oldCard.DueDate.ToString(), newCard.DueDate.ToString())
            {
                OperationDate = DateTime.UtcNow,
                CardId = oldCard.Id
            };
            activities.Add(dateAct);
        }

        foreach (var activity in activities)
        {
            await _repo.AddAsync(activity, oldCard.Id);
        }
    }
}
