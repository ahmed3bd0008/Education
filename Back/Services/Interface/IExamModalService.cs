using System.Linq;
using System.Collections.Generic;

using Entity.Dto;
using Services.respondService;

namespace Services.Interface
{
    public interface IExamModalService
    {
        public ExamDto AddExam(addExamDto examDto);
        public ExamDto updateExam(UpdateExamDto examDto);
        public IList< ExamDto> GetExams();
        public ResponedService<List< ExamDto>> GetExam();
        public int DeleteExam(int examId);
        public AnswerDto AddAnswer(addAnswerDto addAnswerDto);
        public AnswerDto updateAnswer(UpdateAnswerDto updateAnswerDto);
        public IList< AnswerDto> GetAnswers();
        public int DeleteAnswer(int examId,int questionId,int answerId);

        public QestionDto AddQestion(addQuestionDto addQuestionDto);
        public QestionDto updateQuestion(UpdateQustionDto updateQustionDto);
        public IList< QestionDto > GetQuestions(int examId);
        public int DeleteQuestion(int examId,int questionId);

    }
}