using Entity.Core;
using Microsoft.EntityFrameworkCore;
namespace Entity.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.Ignore(d => d.Parient);
            builder.HasOne(o => o.Parient).WithOne(d=>d.Parient).
                HasForeignKey<Category>(d => d.ParientId).
                OnDelete(DeleteBehavior.NoAction);
         
        }
    }
}