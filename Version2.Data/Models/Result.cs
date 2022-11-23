using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Version2.Data
{
    public class Result
    {
        public bool isOk { get; set; }
        public bool isFailed { get; set; }
        public string Message { get; set; }
        protected Result()
        {

        }
        public Result(bool isOk, bool isFailed, string message)
        {
            this.isOk = isOk;
            this.isFailed = isFailed;
            Message = message;
        }
        public static Result Ok()
        {
            return new Result(true, false, "Ok");
        }
        public static Result Failed(string message)
        {
            return new Result(false, true, message);
        }
        public static Result<T> Failed<T>(string message)
        {
            return new Result<T>(Result.Failed(message));

        }
        public static Result<T> Ok<T>(T value)
        {
            var res = new Result<T>(Result.Ok());
            res.Value = value;
            return res;
        }
    }
    public class Result<T> : Result
    {

        public Result( Result res) 
        {
            isOk = res.isOk;
            isFailed = res.isFailed;
            Message = res.Message;
        }
        private T val;
        public T Value
        {
            get => val;
            set => val = value;
        }
        
    }
}
