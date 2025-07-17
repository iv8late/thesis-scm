using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.scm
{
    namespace MyProject.Utility
    {
        public class ApiRsp<T>
        {
            public int Code { get; set; }
            public string Message { get; set; }
            public T Data { get; set; }

            public ApiRsp(int code, string message, T data = default)
            {
                Code = code;
                Message = message;
                Data = data;
            }

            public static ApiRsp<T> SuccessResponse(int code, T data, string message = "Request has succeeded")
            {
                return new ApiRsp<T>(code, message, data);
            }

            public static ApiRsp<T> ErrorResponse(int code, string message = "Bad request")
            {
                return new ApiRsp<T>(code, message);
            }
        }
    }
}

