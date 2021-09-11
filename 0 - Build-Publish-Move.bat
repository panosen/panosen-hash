@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.Hash\bin\Release\Panosen.Hash.*.nupkg D:\LocalSavoryNuget\

pause