using AutoMapper;
using Namespace.Resource.Post;
using Namespace.Data;
namespace  Namespace.Activities.Resource.Commands.Post;

public class Mapping: Profile
{
    public Mapping()
    {
        // TODO: Complete Mapping
        
        CreateMap<DomainObject, Model>(MemberList.None);
        // TODO: Add Mapping Here 

        CreateMap<Model, Response>(MemberList.None)
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
    }
}
