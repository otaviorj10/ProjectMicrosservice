#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Basket.API2/Basket.API2.csproj", "Basket.API2/"]
RUN dotnet restore "Basket.API2/Basket.API2.csproj"
COPY . .
WORKDIR "/src/Basket.API2"
RUN dotnet build "Basket.API2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Basket.API2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Basket.API2.dll"]
