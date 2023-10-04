using AutoMapper;

namespace NZWalks.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        protected internal AutoMapperProfiles()
        {
            CreateMap<>
        }
    }

    public class UserDTO
    {
        public string FullName { get; set; }
    }

    public class UserDomain
    {
        public string FullName { get; set; }
    }
}