using AutoMapper;
using Dtos.DTOs.Put;

namespace  Namespace.Resource.Commands.Put;

public class Mapping: Profile
{
    public Mapping()
    {
        CreateMap<DTO, Model>(MemberList.None)
            // TODO: Implement Mapping here
          ;

        CreateMap<Model, Response>(MemberList.None)
            .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id));
    }
}
