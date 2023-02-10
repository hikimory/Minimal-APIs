using AutoMapper;
using ApiProject.Dtos;
using ApiProject.Models;

namespace ApiProject.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
     
            CreateMap<PlatformCreateDto, Platform>();
                    }
    }
}