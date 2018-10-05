using AutoMapper;
using Ektra.Dtos;
using Ektra.Models;

namespace Ektra
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<Gig, GigDto>();
            CreateMap<Genre, GenreDto>();
            CreateMap<Notification, NotificationDto>();
        }
    }
}