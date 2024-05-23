FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SingleResponsebilityPrinciple/SingleResponsebilityPrinciple.csproj", "SingleResponsebilityPrinciple/"]
RUN dotnet restore "SingleResponsebilityPrinciple/SingleResponsebilityPrinciple.csproj"
COPY . .
WORKDIR "/src/SingleResponsebilityPrinciple"
RUN dotnet build "SingleResponsebilityPrinciple.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SingleResponsebilityPrinciple.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SingleResponsebilityPrinciple.dll"]
