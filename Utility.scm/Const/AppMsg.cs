using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.scm.Const
{
    public static class AppMsg
    {
        public static class Errors
        {
            public const string UserNotFound = "The user was not found.";
            public const string UnauthorizedAccess = "You do not have permission to access this resource.";
            public const string GenericError = "An unexpected error occurred.";
        }

        public static class Success
        {
            public const string GenericSuccess = "Completed with success";
            public const string UserCreated = "User successfully created.";
            public const string OperationCompleted = "Operation completed successfully.";
        }

        public static class Validation
        {
            public const string RequiredField = "The field '{0}' is required.";
            public const string InvalidFormat = "The format of '{0}' is invalid.";
        }

    }

}

