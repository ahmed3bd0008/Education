
using Entity.Shared;

namespace Entity.Core.Exam
{
    public class Answer:EntityId
    {
        public string AnswerTxt { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        
        
    }
}