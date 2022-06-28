namespace Api.Activities;

internal static class RegularExpressions
{
    /// <summary>
    ///     A permissive input ensuring on some special characters are omitted
    /// </summary>
    internal const string AcceptableNameCharactersOnly = @"^[^""±!@£$%^&*_+§¡€#¢§¶•ªº«\\/<>?:;|=.,\n]+$";

    /// <summary>
    /// </summary>
    internal const string OrganisationNameValidator = @"^[A-Z]+[\w\d\s]*$";
    
}