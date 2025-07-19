using AutoMapper;
using DTO.scm;
using Models.scm;

namespace Mapping.scm
{
    public class ThemeMapping: Profile
    {

        public ThemeMapping() {

            CreateMap<Theme, ThemeDTO>().ReverseMap();
        }
    }
}
