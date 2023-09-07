using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Threenine.Configurations.PostgreSql;

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