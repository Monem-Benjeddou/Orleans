FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY ["Orleans.sln", "."]
COPY ["GloboTicket.Abstractions/GloboTicket.Abstractions.csproj", "GloboTicket.Abstractions/"]
RUN dotnet restore "GloboTicket.Abstractions/GloboTicket.Abstractions.csproj"

COPY ["GloboTicket.Grains/GloboTicket.Grains.csproj", "GloboTicket.Grains/"]
RUN dotnet restore "GloboTicket.Grains/GloboTicket.Grains.csproj"

COPY ["GloboTicket.Silo/GloboTicket.Silo.csproj", "GloboTicket.Silo/"]
RUN dotnet restore "GloboTicket.Silo/GloboTicket.Silo.csproj"

COPY . .

WORKDIR "/src/GloboTicket.Silo"
RUN dotnet build "GloboTicket.Silo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GloboTicket.Silo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV SimpleProperty="hello-from-FINAL-dockerfile"

ENTRYPOINT ["dotnet", "GloboTicket.Silo.dll"]



