@echo off
setlocal
chcp 1252
pushd "%~dp0"
if not exist dist md dist
if not %errorlevel%==0 exit /b %errorlevel%
call :packlib && call :packcs
goto :EOF

:packlib
call build /v:m && call :pack TryParsers
goto :EOF

:packcs
call :pack TryParsers.Embedded
goto :EOF

:pack
NuGet pack %1.nuspec -OutputDirectory dist
goto :EOF
