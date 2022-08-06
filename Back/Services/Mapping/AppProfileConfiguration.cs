using AutoMapper;
using Entity.Core.Exam;
using Entity.Dto;

namespace Services.Mapping
{
    public class AppProfileConfiguration:Profile
    {
         public AppProfileConfiguration()
         {
             CreateMap<ExamDto,Exam>().ReverseMap();

             CreateMap<UpdateExamDto,Exam>().ForMember(d=>d.Name, a=>a.MapFrom(f=>f.Name)).
             ForMember(d=>d.StartOfExam, a=>a.MapFrom(f=>f.StartOfExam)).
             ForMember(d=>d.EndOfExam, a=>a.MapFrom(f=>f.EndOfExam)).
             ForMember(d=>d.IsOnce, a=>a.MapFrom(f=>f.IsOnce))
             .ForMember(dest => dest.Questions, opt => opt.Ignore()).
             ForMember(d=>d.TimeOfExam, a=>a.MapFrom(f=>f.TimeOfExam)).ReverseMap();


             CreateMap<addExamDto,Exam>().ForMember(d=>d.Name, a=>a.MapFrom(f=>f.Name)).
             ForMember(d=>d.StartOfExam, a=>a.MapFrom(f=>f.StartOfExam)).
             ForMember(d=>d.EndOfExam, a=>a.MapFrom(f=>f.EndOfExam)).
             ForMember(d=>d.IsOnce, a=>a.MapFrom(f=>f.IsOnce))
             .ForMember(dest => dest.Questions, opt => opt.Ignore()).
             ForMember(d=>d.TimeOfExam, a=>a.MapFrom(f=>f.TimeOfExam)).ReverseMap();


           
         }
    }
}