using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)     //ctor*tab2 ile constructor oluşturduk
        {
            Data = data;
        }
        public DataResult(T data, bool success) : base(success)  //ctor
        {
            Data = data;
        }
        public T Data { get; }
    }
}
