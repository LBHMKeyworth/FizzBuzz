FROM microsoft/dotnet:2.1-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY FirstTestApp/FirstTestApp.csproj FirstTestApp/
RUN dotnet restore FirstTestApp/FirstTestApp.csproj
COPY . .
WORKDIR /src/FirstTestApp
RUN dotnet build FirstTestApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FirstTestApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FirstTestApp.dll"]
