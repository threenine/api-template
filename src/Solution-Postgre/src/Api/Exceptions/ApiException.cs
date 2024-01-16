using System;

namespace Api.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException(string title, string message) : base(message) => Title = title;
        public string Title { get; set; }
    }
}