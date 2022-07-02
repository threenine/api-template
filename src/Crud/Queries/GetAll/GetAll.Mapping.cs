using AutoMapper;
using Dtos;

namespace Namespace.Resource.Queries.GetAll;

public class Mapping: Profile
{
    public Mapping()
    {
       // TODO:  Complete Mapping
       CreateMap<Model, DTO>(MemberList.None)
           
           ;
    }
}
