
using AutoMapper;
using Commandar.Dtos;
using Commandar.Models;

namespace Commandar.Profiles
{
    public class CommandsProfile : Profile
    {
           public CommandsProfile()
           {
               //Source -> Target
               CreateMap<Command,CommandReadDto>();
               CreateMap<CommandCreateDto,Command>();
               CreateMap<CommandUpdateDto,Command>();
               CreateMap<Command,CommandUpdateDto>();

           }
    }
}