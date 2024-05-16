FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV SimpleProperty="hello-from-BASE-dockerfile"

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GloboTicket.Silo/GloboTicket.Silo.csproj", "silo/"]
RUN dotnet restore "GloboTicket.Silo.csproj"
COPY . .
WORKDIR "/src/GloboTicket.Silo/GloboTicket.Silo.csproj"
RUN dotnet build "GloboTicket.Silo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GloboTicket.Silo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV SimpleProperty="hello-from-FINAL-dockerfile"
ENTRYPOINT ["dotnet", "GloboTicket.Silo.dll"]