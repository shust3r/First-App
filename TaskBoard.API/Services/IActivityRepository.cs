using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public interface IActivityRepository
{
    Task<IEnumerable<Activity>> GetAllAsync();
    Task<IEnumerable<Activity>> GeByBoardIdAsync(int boardId);
    Task AddAsync(Activity activity);
    Task AddRangeAsync(IEnumerable<Activity> activities);
}
