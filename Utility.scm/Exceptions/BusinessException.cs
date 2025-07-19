using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.scm.Dictionary;
using Utility.scm.Enums;

namespace Utility.scm.Exceptions
{
    public class BusinessException : Exception
    {
        public ErrorCode Code { get; }

        public BusinessException(ErrorCode code)
            : base(CodeResponses.Messages[code])
        {
            Code = code;
        }

        public BusinessException(ErrorCode code, string customMessage)
            : base(customMessage)
        {
            Code = code;
        } 
    }


    public class ControllerException : Exception
    {
        public int Code { get;}

        public ControllerException(int code) : base(CodeResponses.Test[code])
        {
            Code = code;
        } 
    }
        

}
