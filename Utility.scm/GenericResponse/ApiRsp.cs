using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.scm.Enums;

namespace Utility.scm.GenericResponse
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


        public static ApiRsp<T> SuccessResponse(SuccessCode? code = SuccessCode.OK, string? message = Const.AppMsg.Success.GenericSuccess, T data = default)
        {
            return new ApiRsp<T>((int)(code ?? SuccessCode.OK), message ?? Const.AppMsg.Success.GenericSuccess, data);
        }


        public static ApiRsp<T> ErrorResponse(ErrorCode? code, string? message)
            {
                return new ApiRsp<T>((int)(code ?? ErrorCode.BadRequest), message ?? Const.AppMsg.Success.GenericSuccess);
            }
        }
    
}

