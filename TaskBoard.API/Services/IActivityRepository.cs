using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public interface IActivityRepository
{
    Task<IEnumerable<Activity>> GetAllAsync();
    Task<IEnumerable<Activity>> GeByCardIdAsync(int cardId);
    Task AddAsync(Activity activity);
    public Task AddRange(IEnumerable<Activity> activities);
}
