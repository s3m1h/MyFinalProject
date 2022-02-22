using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message):this(success)
        {
            Message = message;

        }
        // overloading - aşırı yükleme
        public Result(bool success)
        {
            Success = success;
        }
        // constructor icerisinde set yapılabilir
        public string Message { get; }

        public bool Success { get; }
    }
}
