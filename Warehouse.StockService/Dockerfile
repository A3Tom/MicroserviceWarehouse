#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Warehouse.StockService/Warehouse.StockService.csproj", "Warehouse.StockService/"]
RUN dotnet restore "Warehouse.StockService/Warehouse.StockService.csproj"
COPY . .
WORKDIR "/src/Warehouse.StockService"
RUN dotnet build "Warehouse.StockService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Warehouse.StockService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Warehouse.StockService.dll"]