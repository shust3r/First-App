using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public interface IActivityRepository
{
    Task<IEnumerable<Activity>> GetAllAsync();
    //Task<IEnumerable<Activity>> GetByCardIdAsync(int cardId);
    Task<Activity> AddAsync(Activity activity, int cardId);
}
