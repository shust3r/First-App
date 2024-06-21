using TaskBoard.API.Models;

namespace TaskBoard.API.Services;

public class ListService
{
    private readonly IListRepository _listRepo;

    public ListService(IListRepository listRepo)
    {
        _listRepo = listRepo ?? throw new ArgumentNullException(nameof(listRepo));
    }

    public async Task<IEnumerable<ListWithoutDetailsDto>> GetAllListNamesWithId()
    {
        var all = await _listRepo.GetAllWithoutDetailsAsync();

        var result = all
            .Select(l => new ListWithoutDetailsDto 
                { Id = l.Id, Name = l.Name })
            .ToList();

        return result;
    }
}
