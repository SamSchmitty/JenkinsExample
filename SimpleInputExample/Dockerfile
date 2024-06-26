FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /SimpleInputExample
ADD ["bin/Release/net8.0/publish/", "."]

EXPOSE  8080
ENTRYPOINT ["dotnet", "SimpleInputExample.dll"]