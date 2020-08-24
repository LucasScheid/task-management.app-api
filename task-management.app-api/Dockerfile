#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["task-management.app-api/task-management.app-api.csproj", "task-management.app-api/"]
RUN dotnet restore "task-management.app-api/task-management.app-api.csproj"
COPY . .
WORKDIR "/src/task-management.app-api"
RUN dotnet build "task-management.app-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "task-management.app-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "task-management.app-api.dll"]