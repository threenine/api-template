using AutoMapper;
using Namespace.Resource.Put;
using Namespace.Data;
namespace  Namespace.Activities.Resource.Commands.Put;

public class Mapping: Profile
{
    public Mapping()
    {
        CreateMap<DomainObject, Model>(MemberList.None)
            // TODO: Implement Mapping here
          ;

        CreateMap<Model, Response>(MemberList.None)
            .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id));
    }
}
