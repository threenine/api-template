namespace Common;

/// <summary>
/// Represents a collection of connection string names used in the application.
/// </summary>
public static class ConnectionStringNames
{
    /// <summary>
    /// Gets or sets the default value.
    /// </summary>
    /// <value>
    /// The default value.
    /// </value>
    public static string Default => "Default";
    
    
    /// <summary>
    /// A default of localBuild is provided this can be any arbitrary value as this will ensure
    /// the migrations are created using an ephemeral in memory database. If you want to use an actual database
    /// to create migrations then this value can be changed to the name of a Connection string.
    /// </summary>
    public static string LocalBuild => "LocalBuild";

}