#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Excellence.Ims.Main/Excellence.Ims.Main.csproj", "Excellence.Ims.Main/"]
RUN dotnet restore "Excellence.Ims.Main/Excellence.Ims.Main.csproj"
COPY . .
WORKDIR "/src/Excellence.Ims.Main"
RUN dotnet build "Excellence.Ims.Main.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Excellence.Ims.Main.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Excellence.Ims.Main.dll"]