## Api Project
Stub for Engagement Service
Set up bit bucket for new service
---------------------------------
-Create repo in bitbucket

local machine - open powershell
-Create a host directory for the service
 mkdir Engagements

-clone repo at destination using ssh link
git clone git@bitbucket.org:kpsol/engagements.git
-test by modifying README.md
-commit
git commit -am "initial change"

-push
git push
---------------------------------------------------------

Start creating the Service stub
-------------------------------
-create dotnet sln
dotnet new sln -n Engagements

-get latest version of the api project template
dotnet new --install Threenine.ApiProject

-create apiproject stub
dotnet new apiproject -n Api -o src

-add to sln
dotnet sln .\Engagements.sln add src

-get the git ignore copied over from another stable src

Open in Visual Studio - integrated git menu should be working

-commit
-push to remote repo