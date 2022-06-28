using System;


namespace Api.Exceptions
{
    [Serializable]
    public class NotFoundException : ApiException
    {
        public NotFoundException(string title, string message) : base(title, message)
        {
        }
    }
}