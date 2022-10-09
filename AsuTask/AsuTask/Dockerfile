FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS restore
WORKDIR /src
COPY AsuTask ./AsuTask
RUN  dotnet restore "AsuTask/AsuTask.sln" -p:GlobalRuntimeIdentifier=alpine-x64

FROM restore AS build
RUN  dotnet build "AsuTask/AsuTask.sln" -c Release -p:GlobalRuntimeIdentifier=alpine-x64 --no-restore

FROM build AS publish
RUN dotnet publish "AsuTask/AsuTask/AsuTask.csproj" -c Release -p:GlobalRuntimeIdentifier=alpine-x64 -o /app/publish \
  --no-build \
  --self-contained true

FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /app

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AsuTask.dll"]