#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Indimin.WebApi/Indimin.WebApi.csproj", "src/Indimin.WebApi/"]
COPY ["src/Indimin.Application/Indimin.Application.csproj", "src/Indimin.Application/"]
COPY ["src/Indimin.Core/Indimin.Core.csproj", "src/Indimin.Core/"]
COPY ["src/Indimin.Infrastructure/Indimin.Infrastructure.csproj", "src/Indimin.Infrastructure/"]
RUN dotnet restore "src/Indimin.WebApi/Indimin.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Indimin.WebApi"
RUN dotnet build "Indimin.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Indimin.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Indimin.WebApi.dll"]