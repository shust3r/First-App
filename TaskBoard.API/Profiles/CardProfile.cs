using AutoMapper;

namespace TaskBoard.API.Profiles;

public class CardProfile : Profile
{
    public CardProfile()
    {
        CreateMap<Models.CardDto, Entities.Card>();
        CreateMap<Models.CardForCreationDto, Entities.Card>();
        CreateMap<Models.CardForUpdateDto, Entities.Card>();
        CreateMap<Entities.Card, Models.CardForUpdateDto>();

    }
}
