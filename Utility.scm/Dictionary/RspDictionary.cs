using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.scm.Enums;

namespace Utility.scm.Dictionary
{
    public static class CodeResponses
    {
        public static readonly Dictionary<ErrorCode, string> Messages = new()
         {

              { ErrorCode.Unauthorized, "Insufficient permits " },
              { ErrorCode.ServerError, "Server error. Try again later." }
          };

        public static readonly Dictionary<SuccessCode, string> Success = new()
        {
             { SuccessCode.OK, "Request was successful." },
            { SuccessCode.Created, "Created successfully." }
         };
    }

   

}
