
using System;

namespace Entity.Dto
{
    public class ExamDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime   StartOfExam { get; set; }
        public DateTime ? EndOfExam { get; set; }
        public DateTime ? TimeOfExam { get; set; }
        public bool IsOnce { get; set; }
    }
     public class UpdateExamDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime   StartOfExam { get; set; }
        public DateTime ? EndOfExam { get; set; }
        public DateTime ? TimeOfExam { get; set; }
        public bool IsOnce { get; set; }
    }
    public class addExamDto
    {
        
        public string Name { get; set; }
        public DateTime   StartOfExam { get; set; }
        public DateTime ? EndOfExam { get; set; }
        public DateTime ? TimeOfExam { get; set; }
        public bool IsOnce { get; set; }
    }
}