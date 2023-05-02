using AutoMapper;
using SFmosule33.PLL;

namespace SFmosule33.DAL
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
