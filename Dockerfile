FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy the solution file to the container
COPY ["Orleans.sln", "."]

# Copy and restore GloboTicket.Abstractions project
COPY ["GloboTicket.Abstractions/GloboTicket.Abstractions.csproj", "GloboTicket.Abstractions/"]
RUN dotnet restore "GloboTicket.Abstractions/GloboTicket.Abstractions.csproj"

# Copy and restore GloboTicket.Grains project
COPY ["GloboTicket.Grains/GloboTicket.Grains.csproj", "GloboTicket.Grains/"]
RUN dotnet restore "GloboTicket.Grains/GloboTicket.Grains.csproj"

# Copy and restore GloboTicket.Silo project
COPY ["GloboTicket.Silo/GloboTicket.Silo.csproj", "GloboTicket.Silo/"]
RUN dotnet restore "GloboTicket.Silo/GloboTicket.Silo.csproj"

# Copy the rest of the source code
COPY . .

# Set the working directory for the Silo project
WORKDIR "/src/GloboTicket.Silo"

# Build the Silo project
RUN dotnet build "GloboTicket.Silo.csproj" -c Release -o /app/build

# Define the publish stage
FROM build AS publish

# Publish the Silo project
RUN dotnet publish "GloboTicket.Silo.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Define the final stage
FROM base AS final
WORKDIR /app

# Copy the published output from the publish stage
COPY --from=publish /app/publish .

# Set environment variables
ENV SimpleProperty="hello-from-FINAL-dockerfile"

# Specify the entry point for the application
ENTRYPOINT ["dotnet", "GloboTicket.Silo.dll"]
