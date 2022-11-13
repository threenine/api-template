using AutoMapper;
using Namespace.Data;
using Namespace.Resource.Patch;

namespace Namespace.Activities.Resource.Commands.Patch;

public class Mapping: Profile
{
    public Mapping()
    {
        // TODO : Complete Mapping
        
        CreateMap<Model, Response>(MemberList.None);
 
        CreateMap<Model, DomainObject>(MemberList.None);

        CreateMap<DomainObject, Model>(MemberList.None);

    }
}
