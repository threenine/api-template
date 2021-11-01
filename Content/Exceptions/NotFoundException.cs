using System;
using ApiProject.Resources;

namespace ApiProject.Content.Exceptions
{
    [Serializable]
    public class NotFoundException : ApiProjectException
    {
        public NotFoundException(string title, string message) : base(ExceptionTitle.NotFound, message)
        {
        }
    }
}