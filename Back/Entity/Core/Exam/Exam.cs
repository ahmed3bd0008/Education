using System;
using System.Collections.Generic;
using Entity.Shared;

namespace Entity.Core.Exam
{
    public class Exam:EntityId
    {
        public string Name { get; set; }
        public DateTime   StartOfExam { get; set; }
        public DateTime ? EndOfExam { get; set; }
        public DateTime ? TimeOfExam { get; set; }
        public bool IsOnce { get; set; }
        public ICollection<Question> Questions { get; set; }
        
        
        
        
    }
}