using Entity.Context;
using Repository.Interface;
using Entity.Core.Exam;

namespace Repository.Implementation
{
    public class UntityOfWork : IUntityOfWork
    {
           private readonly AppEducationDbContext _context;
           private  GenericRepository<Answer> _answerRep;
           private  GenericRepository<Question> _questionRep;
           private  GenericRepository<Exam> _examRep;

           public UntityOfWork(AppEducationDbContext context)
           {
               _context=context;
           }
        public IGenericRepository<Answer> AnswerRepository {
             get{
                    if(_answerRep==null)
                               _answerRep=new GenericRepository<Answer>(_context);
                   return  _answerRep;
                } 
        }
        public IGenericRepository<Question> QuestionRepository{
             get{
                    if(_answerRep==null)
                               _questionRep=new GenericRepository<Question>(_context);
                   return  _questionRep;
                } 
        }
        public IGenericRepository<Exam> ExamRepository {
             get{
                    if(_examRep==null)
                               _examRep=new GenericRepository<Exam>(_context);
                   return  _examRep;
                   
                } 
        }
    }
}