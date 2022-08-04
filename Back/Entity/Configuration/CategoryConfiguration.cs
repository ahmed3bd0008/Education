using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Entity.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
           builder.Property(p=>p.ParentID).HasDefaultValue(0);
          builder.HasMany(d=>d.Subcategories).WithOne().HasForeignKey(d=>d.ParentID).OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}