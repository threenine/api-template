using System.Collections.Generic;
using ApiProject.Resources;

namespace ApiProject.Content.Exceptions
{
    public class ValidationException : ApiProjectException
    {
        public ValidationException( string message, IReadOnlyDictionary<string, string[]> errors) : base(ExceptionTitle.Validation , message) =>
            Errors = errors;

        public IReadOnlyDictionary<string, string[]> Errors { get; }
    }
}