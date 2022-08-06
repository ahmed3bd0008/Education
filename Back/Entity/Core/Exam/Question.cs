using System.Collections.Generic;
using Entity.Enum;
using Entity.Shared;

namespace Entity.Core.Exam
{
    public class Question:EntityId
    {
        public string QuestionDesc { get; set; }
        public string Img { get; set; }
        public QuestionType QuestionType { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public ICollection<Answer> Answers { get; set; }
        
        
        
        
        
         
    }
}