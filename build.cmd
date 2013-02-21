@echo off
setlocal
pushd "%~dp0"
call :main %*
popd
goto :EOF

:main
set MSBUILD=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe
if not exist "%MSBUILD%" (
    echo The .NET Framework 4.0 does not appear to be installed on this 
    echo machine, which is required to build the solution.
    exit /b 1
)
for %%f in (2.0 3.5) do for %%q in (Debug Release) do "%MSBUILD%" TryParsers.sln /p:Configuration="NETFX %%f %%q" /v:m %*

