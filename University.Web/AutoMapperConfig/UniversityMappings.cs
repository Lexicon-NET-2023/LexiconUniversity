using AutoMapper;

namespace University.Web.AutoMapperConfig
{
    public class UniversityMappings : Profile
    {
        public UniversityMappings()
        {
            CreateMap<Student, StudentCreateViewModel>()
                .ReverseMap();

            CreateMap<Student, StudentIndexViewModel>();
        }
    }
}
