namespace Common;

public static class RegularExpressions
{
    /// <summary>
    ///     A permissive input ensuring on some special characters are omitted
    /// </summary>
    public const string AcceptableNameCharactersOnly = @"^[^""±!@£$%^&*_+§¡€#¢§¶•ªº«\\/<>?:;|=.,\n]+$";

    /// <summary>
    /// A general Organisation nme validator
    /// </summary>
    public const string OrganisationNameValidator = @"^[A-Z]+[\w\d\s]*$";
    
    /// <summary>
    /// Provides validation for regular Internet Domain structure
    /// </summary>
    public const string DomainName = @"\A([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,}\Z";
    
    /// <summary>
    /// Common relative path structure validation
    /// </summary>
    public const string RelativeUrlPath = @"^([\/][a-zA-Z]+)+\.*(((\?)([a-zA-Z]*=\w*)){1}((&)([a-zA-Z]*=\w*))*)?$";
    
}