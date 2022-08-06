using Entity.Core.Exam;
using Microsoft.EntityFrameworkCore;
namespace Entity.Configuration
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Exam> builder)
        {
             builder.HasMany(m=>m.Questions).
             WithOne(o=>o.Exam).
             HasForeignKey(f=>f.ExamId).
             OnDelete(DeleteBehavior.Cascade);
             builder.Property(p=>p.IsOnce).
                     HasDefaultValue(false);

             builder.Property(p=>p.Name).IsRequired();
        }
    }
}