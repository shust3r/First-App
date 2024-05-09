using AutoMapper;

namespace TaskBoard.API.Profiles;

public class ListProfile : Profile
{
    public ListProfile()
    {
        CreateMap<Models.ListDto, Entities.List>();
        CreateMap<Models.ListForCreationDto, Entities.List>();
        CreateMap<Models.ListForUpdateDto, Entities.List>();
        CreateMap<Entities.List, Models.ListForUpdateDto>();
    }
}
