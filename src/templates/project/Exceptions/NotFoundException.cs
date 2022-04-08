using System;


namespace ApiProject.Content.Exceptions
{
    [Serializable]
    public class NotFoundException : ApiProjectException
    {
        public NotFoundException(string title, string message) : base(title, message)
        {
        }
    }
}