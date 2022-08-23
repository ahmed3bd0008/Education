using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.respondService
{
    public class ResponedService<T>
    {
        
                private bool Status { get; set; } 
        private string Message { get; set; } 
        private T Data { get; set; }
        private string Token { get; set; }
        public ResponedService(bool Status,string message ,T Data,string Token)
        {
            this.Data=Data;
            this.Message=message;
            this.Token=Token;
            this.Status=Status;
        }
        public ResponedService(bool status, T data, List<Entity.Dto.ExamDto> Data) 
        {
            this.Status = status;
            this.Data = data;
        }
          public ResponedService(string message, T Data) 
        {
            this.Message = message;
            this.Data = Data;
        }
          public ResponedService(bool status, T Data) 
        {
            this.Status = status;
            this.Data = Data;
        }
         public ResponedService(bool Status,string message )
        {
            this.Data=Data;
            this.Message=message;
        }
         public ResponedService(bool Status,string message ,T Data)
        {
            this.Data=Data;
            this.Message=message;
            this.Status=Status;
        }
    }
}