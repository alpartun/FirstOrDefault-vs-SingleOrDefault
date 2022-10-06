FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["firstordefaultvssingleordefault/firstordefaultvssingleordefault.csproj", "firstordefaultvssingleordefault/"]
RUN dotnet restore "firstordefaultvssingleordefault/firstordefaultvssingleordefault.csproj"
COPY . .
WORKDIR "/src/firstordefaultvssingleordefault"
RUN dotnet build "firstordefaultvssingleordefault.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "firstordefaultvssingleordefault.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "firstordefaultvssingleordefault.dll"]
