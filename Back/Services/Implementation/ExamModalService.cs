
using System;
using System.Collections.Generic;
using AutoMapper;
using Entity.Core.Exam;
using Entity.Dto;
using Repository.Interface;
using Services.Interface;
using Services.respondService;

namespace Services.Implemetation
{
    public class ExamModalService : IExamModalService
    {
        private readonly IUntityOfWork _untityOfWork;
        private readonly IMapper _mapper;
public ExamModalService(IMapper mapper,IUntityOfWork untityOfWork)
{
    _mapper=mapper;
    _untityOfWork=untityOfWork;
}
        public AnswerDto AddAnswer(addAnswerDto addAnswerDto)
        {
            throw new System.NotImplementedException();
        }

        public ExamDto AddExam(addExamDto examDto)
        {
            try{
            Exam examDb=_mapper.Map<Exam>(examDto);
            _untityOfWork.ExamRepository.AddEntity(examDb);
            _untityOfWork.SaveChane();
            ExamDto examDtoget=_mapper.Map<ExamDto>(examDb);
            examDtoget.Id=examDb.Id;
            return examDtoget ;
            }
            catch(Exception ex)
            {
                return new ExamDto();
            }

        }

        public QestionDto AddQestion(addQuestionDto addQuestionDto)
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

        public AnswerDto updateAnswer(UpdateAnswerDto updateAnswerDto)
        {
            throw new System.NotImplementedException();
        }

        public ExamDto updateExam(UpdateExamDto examDto)
        {
            throw new System.NotImplementedException();
        }

        public QestionDto updateQuestion(UpdateQustionDto updateQustionDto)
        {
            throw new System.NotImplementedException();
        }

        ResponedService<List<ExamDto>> IExamModalService.GetExam()
        {
            return  new ResponedService<List<ExamDto>>(status:true,Data:new List<ExamDto>());
        
        }
    }
}