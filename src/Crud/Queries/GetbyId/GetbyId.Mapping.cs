using AutoMapper;
using Namespace.Resource.Get;
using Namespace.Data;
namespace Namespace.Activities.Resource.Queries.GetbyId;

public class Mapping: Profile
{
    public Mapping()
    {
        // TODO: Add Mapping
        CreateMap<Model, Response>(MemberList.None);
    }
}
