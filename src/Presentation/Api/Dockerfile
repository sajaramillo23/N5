#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/Presentation/Api/N5.csproj", "src/Presentation/Api/"]
COPY ["src/Infrastructure/N5.ElasticSearch/N5.ElasticSearch.csproj", "src/Infrastructure/N5.ElasticSearch/"]
COPY ["src/Core/Application/N5.Application.csproj", "src/Core/Application/"]
COPY ["src/Core/Domain/N5.Domain.csproj", "src/Core/Domain/"]
COPY ["src/Infrastructure/Helpers/N5.Helpers.csproj", "src/Infrastructure/Helpers/"]
COPY ["src/Infrastructure/Configuration/N5.Configuration.csproj", "src/Infrastructure/Configuration/"]
COPY ["src/Infrastructure/Persistance/N5.Persistance.csproj", "src/Infrastructure/Persistance/"]
RUN dotnet restore "src/Presentation/Api/N5.csproj"
COPY . .
WORKDIR "/src/src/Presentation/Api"
RUN dotnet build "N5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "N5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "N5.dll"]
