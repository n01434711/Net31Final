using System;

namespace Net31.Wynnie.FinalExam.BusinessLogic.BusinessLogic
{
    public class ValidationException : Exception
    {
        public int Code { get; set; }

        public ValidationException(int code, string message) : base(message)
        {
            Code = code;
        }
    }
}
