#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /
EXPOSE 5009
EXPOSE 80
EXPOSE 443
EXPOSE 5435

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . ./
RUN dotnet restore "ToDoList.API/ToDoList.API.csproj"
COPY . .
WORKDIR "/src/ToDoList.API"
RUN dotnet build "ToDoList.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToDoList.API.csproj" -c Release -o /app/publish /p:UseAppHost=true

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ToDoList.API.dll"]