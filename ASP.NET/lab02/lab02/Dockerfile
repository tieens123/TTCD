#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["lab02/lab02.csproj", "lab02/"]
RUN dotnet restore "lab02/lab02.csproj"
COPY . .
WORKDIR "/src/lab02"
RUN dotnet build "lab02.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lab02.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab02.dll"]