#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CC1/CC1.csproj", "CC1/"]
RUN dotnet restore "CC1/CC1.csproj"
COPY . .
WORKDIR "/src/CC1"
RUN dotnet build "CC1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CC1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CC1.dll"]