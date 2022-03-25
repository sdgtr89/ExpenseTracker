$workingDirectory = Get-Location

dotnet run --project $"$workingDirectory\src\ExpenseTracker.Api"
