using Threenine.Models;
namespace Templates.Entity;

#if (list)
    public sealed class EntityName : ValueListEntity
#else 
   public sealed class EntityName : BaseEntity
#endif
{   
}