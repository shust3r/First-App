using TaskBoard.API.Entities;

namespace TaskBoard.API.Services;

public interface ICardRepository
{
    Task<IEnumerable<Card>> GetAllAsync();
    Task<Card?> GetByCardIdAsync(int cardId);
    Task<Card> AddAsync(Card card);
    Task<Card> Update(Card card);
    Task<Card?> Delete(int cardId);
    Task<IEnumerable<Card>> GetByBoardIdAsync(int boardId);
}
