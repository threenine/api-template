namespace  Namespace.Resource.Commands.Post;

public class Mapping: Profile
{
    public Mapping()
    {
        // TODO: Complete Mapping
        
        CreateMap<DTO, Model>(MemberList.None);
        // TODO: Add Mapping Here 

        CreateMap<Model, Response>(MemberList.None)
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
    }
}
