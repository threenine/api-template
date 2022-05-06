using System;


namespace ApiProject.Exceptions
{
    [Serializable]
    public class NotFoundException : ApiProjectException
    {
        public NotFoundException(string title, string message) : base(title, message)
        {
        }
    }
}