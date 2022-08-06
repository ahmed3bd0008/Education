using System.Linq;
using System.Collections.Generic;

using Entity.Dto;

namespace Services.Interface
{
    public interface IExamModalService
    {
        public ExamDto AddExam(ExamDto examDto);
        public ExamDto updateExam(UpdateExamDto examDto);
        public IList< ExamDto> GetExams();
        public ExamDto GetExam();
        public int DeleteExam(int examId);
        public AnswerDto AddAnswer(ExamDto examDto);
        public AnswerDto updateAnswer(UpdateExamDto examDto);
        public IList< AnswerDto> GetAnswers();
        public int DeleteAnswer(int examId,int questionId,int answerId);

        public QestionDto AddQestion(ExamDto examDto);
        public QestionDto updateQuestion(UpdateExamDto examDto);
        public IList< QestionDto > GetQuestions(int examId);
        public int DeleteQuestion(int examId,int questionId);

    }
}