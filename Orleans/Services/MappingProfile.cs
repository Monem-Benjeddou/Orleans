using AutoMapper;
using Orleans.Models;

namespace Orleans.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserProfile, GloboTicket.Abstractions.UserProfile>().ReverseMap();

        }
    }
}
