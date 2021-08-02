FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

COPY ExpenseOnHotel.Application/ExpenseOnHotel.Application.csproj ./ExpenseOnHotel.Application/
COPY ExpenseOnHotel.Domain/ExpenseOnHotel.Domain.csproj ./ExpenseOnHotel.Domain/
COPY ExpenseOnHotel.Infrastructure/ExpenseOnHotel.Infrastructure.csproj ./ExpenseOnHotel.Infrastructure/

RUN dotnet restore "./ExpenseOnHotel.Application/ExpenseOnHotel.Application.csproj"

COPY . .
WORKDIR "/src"
RUN dotnet build "ExpenseOnHotel.Application/ExpenseOnHotel.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExpenseOnHotel.Application/ExpenseOnHotel.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "ExpenseOnHotel.Application.dll"]