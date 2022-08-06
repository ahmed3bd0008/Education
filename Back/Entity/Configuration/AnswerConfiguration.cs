using Entity.Core.Exam;
using Microsoft.EntityFrameworkCore;
namespace Entity.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Answer> builder)
        {
             builder.HasOne(m=>m.Question).
             WithMany(o=>o.Answers).
             HasForeignKey(f=>f.QuestionId).
             OnDelete(DeleteBehavior.Cascade);

             builder.Property(p=>p.IsCorrect).
            HasDefaultValue(false);
            builder.Property(p=>p.AnswerTxt).IsRequired();
        }
    }
}