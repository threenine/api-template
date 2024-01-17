using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
#if(useMSSQL)
using Threenine.Configurations.SqlServer;
#endif
#if (usePOSTGRE)
using Threenine.Configurations.PostgreSql;
#endif

namespace Database.Configurations;

public class ModelConfiguration : BaseEntityTypeConfiguration<Model>
{
    public override void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable(nameof(Model).ToSnakeCase());
        
        // Add configurations
        
        base.Configure(builder);
    }
}