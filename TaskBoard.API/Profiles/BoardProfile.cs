using AutoMapper;
using TaskBoard.API.Entities;
using TaskBoard.API.Models;

namespace TaskBoard.API.Profiles;

public class BoardProfile : Profile
{
    public BoardProfile()
    {
        CreateMap<BoardForCreationDto, Board>();
        CreateMap<BoardForUpdateDto, Board>();
        CreateMap<BoardDto, Board>();
        CreateMap<Board, BoardForUpdateDto>();
    }
}
