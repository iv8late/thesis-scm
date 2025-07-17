using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.scm.Enums
{
    public enum SuccessCode
    {

        OK = 200,
        Created = 201,
        
    }
    public enum ErrorCode
    {
        
        Unauthorized = 401,
        Forbidden = 403,
        ServerError = 500,
        NoContent // 204
    }

}
