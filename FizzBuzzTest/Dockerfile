FROM microsoft/dotnet:2.1-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY FizzBuzzTest/FizzBuzzTest.csproj FizzBuzzTest/
COPY FirstTestApp/FirstTestApp.csproj FirstTestApp/
RUN dotnet restore FizzBuzzTest/FizzBuzzTest.csproj
COPY . .
WORKDIR /src/FizzBuzzTest
RUN dotnet build FizzBuzzTest.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FizzBuzzTest.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FizzBuzzTest.dll"]
