using Threenine.Models;
namespace placeHolder.Database.Entities;

#if (list)
public sealed class EntityName : ValueListEntity
#else 
public sealed class EntityName : BaseEntity
#endif
{   
}