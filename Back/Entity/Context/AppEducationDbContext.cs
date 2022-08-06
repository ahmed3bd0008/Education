using System;
using Entity.Configuration;
using Entity.Core;
using Entity.Core.authentication;
using Entity.Core.Exam;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Entity.Context
{
    public class AppEducationDbContext : IdentityDbContext<userIdentity,roleIdentity,int>
    {
        public AppEducationDbContext(DbContextOptions<AppEducationDbContext> options):base(options)
        {
            
        }
    protected  override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
      modelBuilder.ApplyConfiguration(new CategoryConfiguration());
      modelBuilder.ApplyConfiguration(new AnswerConfiguration());
      modelBuilder.ApplyConfiguration(new QuestionConfiguration());
      modelBuilder.ApplyConfiguration(new ExamConfiguration());
    }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Exam> Exams  { get; set; }
    }
}