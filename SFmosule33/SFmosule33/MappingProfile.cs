using AutoMapper;

namespace SFmosule33
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                    .ConstructUsing(u => new UserViewModel(u));
        }
    }
}
