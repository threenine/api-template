namespace Namespace.Resource.Commands.Patch;

public class Mapping: Profile
{
    public Mapping()
    {
        // TODO : Complete Mapping
        
        CreateMap<Model, Response>(MemberList.None);
 
        CreateMap<Model, DTO>(MemberList.None);

        CreateMap<DTO, Model>(MemberList.None);

    }
}
