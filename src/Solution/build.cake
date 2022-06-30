#tool "dotnet:?package=GitVersion.Tool&version=5.10.3"
#addin nuget:?package=Cake.Docker&version=1.1.2
var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
string version = String.Empty;

/// TODO: Update Project Tag Name for Docker Container name
string projectTag = "";

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() => {
    DotNetClean("./ApiSolution.sln");
});

Task("Restore")
    .IsDependentOn("Clean")
    .Description("Restoring the solution dependencies")
    .Does(() => {
    
    var projects = GetFiles("./**/**/*.csproj");
    var settings =  new DotNetRestoreSettings
    {
      Verbosity = DotNetVerbosity.Minimal,
      Sources = new [] { "https://api.nuget.org/v3/index.json" }
    };
    foreach(var project in projects )
    {
      Information($"Restoring { project.ToString()}");
      DotNetRestore(project.ToString(), settings);
    }

});

Task("Version")
  .IsDependentOn("Restore")
   .Does(() =>
{
   var result = GitVersion(new GitVersionSettings {
        UpdateAssemblyInfo = true
    });
    
    version =  result.FullSemVer.ToString();
    Information($"Nuget Version: { version.ToString() }");
    Information($"Semantic Version: { result.FullSemVer.ToString() }");
});

Task("Build")
    .IsDependentOn("Version")
    .Does(() => {
     var buildSettings = new DotNetCoreBuildSettings {
                        Configuration = configuration,
                       };
     var projects = GetFiles("./**/**/*.csproj");
     foreach(var project in projects )
     {
         Information($"Building {project.ToString()}");
         DotNetBuild(project.ToString(),buildSettings);
     }
});



Task("Test")
    .IsDependentOn("Build")
    .Does(() => {

       var testSettings = new DotNetCoreTestSettings  {
                                  Configuration = configuration,
                                  NoBuild = true,
                              };
     var projects = GetFiles("./tests/Unit/*.csproj");
     foreach(var project in projects )
     {
       Information($"Running Tests : { project.ToString()}");
       DotNetTest(project.ToString(), testSettings );
     }


});

Task("Publish")
    .IsDependentOn("Test")
    .Does(() => {

     
     var projects = GetFiles("./src/Api/Api.csproj");
     foreach(var project in projects )
     {
       var publishSettings = new DotNetPublishSettings  {
                                       Configuration = configuration,
                                       NoBuild = true,
                                       OutputDirectory = ".publish",
                                   };
       Information($"Publishing API : { project.ToString()}");
       DotNetPublish(project.ToString(), publishSettings );
     }


});

Task("Docker-Build")
 .IsDependentOn("Publish")
.Does(() => {
    
    string [] tags = new string[]  {  $"{projectTag}:{version}";};
      Information("Building : Actors Docker Image");
    var settings = new DockerImageBuildSettings { Tag=tags};
    DockerBuild(settings, "./");
});



//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

Task("Default")
       .IsDependentOn("Clean")
       .IsDependentOn("Restore")
       .IsDependentOn("Version")
       .IsDependentOn("Build")
       .IsDependentOn("Test")
       .IsDependentOn("Publish")
       .IsDependentOn("Docker-Build");

RunTarget(target);
