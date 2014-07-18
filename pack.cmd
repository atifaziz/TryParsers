@echo off
setlocal
chcp 1252 > nul
set nuget=
for %%i in (NuGet.exe) do set nuget=%%~$PATH:i
if not defined nuget goto :nonuget
pushd "%~dp0"
if not exist dist md dist
if %errorlevel%==0 call :packlib && call :packcs
popd
exit /b %errorlevel%

:packlib
call build /v:m && call :pack TryParsers -Symbols
goto :EOF

:packcs
call :pack TryParsers.Embedded
goto :EOF

:pack
NuGet pack %1.nuspec -OutputDirectory dist %2 %3 %4 %5 %6 %7 %8 %9
goto :EOF

:nonuget
echo NuGet executable not found in PATH
echo For more on NuGet, see http://nuget.codeplex.com
exit /b 2
