
using System.Collections.Generic;
using Entity.Dto;
using Services.Interface;

namespace Services.Implemetation
{
    public class ExamModalService : IExamModalService
    {
        public AnswerDto AddAnswer(ExamDto examDto)
        {
            throw new System.NotImplementedException();
        }

        public ExamDto AddExam(ExamDto examDto)
        {
            throw new System.NotImplementedException();
        }

        public QestionDto AddQestion(ExamDto examDto)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteAnswer(int examId, int questionId, int answerId)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteExam(int examId)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteQuestion(int examId, int questionId)
        {
            throw new System.NotImplementedException();
        }

        public IList<AnswerDto> GetAnswers()
        {
            throw new System.NotImplementedException();
        }

        public ExamDto GetExam()
        {
            throw new System.NotImplementedException();
        }

        public IList<ExamDto> GetExams()
        {
            throw new System.NotImplementedException();
        }

        public IList<QestionDto> GetQuestions(int examId)
        {
            throw new System.NotImplementedException();
        }

        public AnswerDto updateAnswer(UpdateExamDto examDto)
        {
            throw new System.NotImplementedException();
        }

        public ExamDto updateExam(UpdateExamDto examDto)
        {
            throw new System.NotImplementedException();
        }

        public QestionDto updateQuestion(UpdateExamDto examDto)
        {
            throw new System.NotImplementedException();
        }
    }
}