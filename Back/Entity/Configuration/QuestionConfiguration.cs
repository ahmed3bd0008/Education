using Entity.Core.Exam;
using Microsoft.EntityFrameworkCore;
namespace Entity.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Question> builder)
        {
             builder.HasMany(m=>m.Answers).
             WithOne(o=>o.Question).
             HasForeignKey(f=>f.QuestionId).
             OnDelete(DeleteBehavior.Cascade);
              builder.Property(p=>p.QuestionDesc).IsRequired();
        }
    }
}