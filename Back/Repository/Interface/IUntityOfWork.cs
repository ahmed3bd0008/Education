using Entity.Core;
using Entity.Core.Exam;
using Repository.Implementation;

namespace Repository.Interface
{
    public interface IUntityOfWork
    {
          IGenericRepository<Answer> AnswerRepository { get; }
          IGenericRepository<Question> QuestionRepository { get; }
          IGenericRepository<Exam> ExamRepository { get; }
    }
}