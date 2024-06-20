FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SaleAirTickets/SaleAirTickets.csproj", "SaleAirTickets/"]
RUN dotnet restore "./SaleAirTickets/SaleAirTickets.csproj"
COPY . .
WORKDIR "/src/SaleAirTickets"
RUN dotnet build "./SaleAirTickets.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SaleAirTickets.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "SaleAirTickets.dll"]