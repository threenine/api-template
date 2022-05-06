using System;

namespace ApiProject.Exceptions
{
    public class ApiProjectException : Exception
    {
        public ApiProjectException(string title, string message) : base(message) => Title = title;
        public string Title { get; set; }
    }
}