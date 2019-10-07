FROM microsoft/aspnetcore:2.0-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-sac2016 AS build
WORKDIR /src
COPY SocietyCare/SocietyCare.csproj SocietyCare/
RUN dotnet restore SocietyCare/SocietyCare.csproj
COPY . .
WORKDIR /src/SocietyCare
RUN dotnet build SocietyCare.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish SocietyCare.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SocietyCare.dll"]
