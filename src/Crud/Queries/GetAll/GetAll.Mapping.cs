using AutoMapper;
using Namespace.Resource.Get;
using Namespace.Data;
namespace Namespace.Activities.Resource.Queries.GetAll;

public class Mapping: Profile
{
    public Mapping()
    {
       // TODO:  Complete Mapping
       CreateMap<Model, DomainObject>(MemberList.None)
           
           ;
    }
}
