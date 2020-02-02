using System;
using System.ComponentModel;

namespace Demo.ViewModels
{
    public class ErrorMessageDisplay
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }

        public static implicit operator BindingList<object>(ErrorMessageDisplay v)
        {
            throw new NotImplementedException();
        }
    }
}
