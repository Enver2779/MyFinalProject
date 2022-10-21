using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
     

        //public Result(bool success, string message)
        //{
        //    Message = message;
        //    Seccess = success;
        //    birinci yöntem en kolay
        //} 
        public Result(bool success, string message):this(success)
        {
            Message = message;
            
           
        }  
        public Result(bool success )
        {
          
            Seccess = success;
           
        }

        public bool Seccess { get; }

        public string Message { get; }
        public bool Success { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
