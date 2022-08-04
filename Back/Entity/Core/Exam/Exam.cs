using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Core.Exam
{
    public class Exam
    {
        public string Name { get; set; }
        public DateTime  DateOfStart { get; set; }
        public DateTime ? DateOfEnd { get; set; }
        public bool IsEnded
         { 
            get
            {
                if(this.DateOfEnd<DateTime.Now)
                 return true;
                 else
                  return false;
            }
          }
         public TimeSpan  TimeOfExam 
         { 
       get
        {
             return TimeOfExam;
        }
        set
        {
          TimeOfExam= value==null? (DateTime.Now-DateOfStart) :TimeOfExam
        }
         }   
    }
}