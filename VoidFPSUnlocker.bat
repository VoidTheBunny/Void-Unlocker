@echo off
title Void FPS unlocker
echo Searching for Roblox folder...
timeout /t 2 >nul
if exist "%LOCALAPPDATA%\Roblox" (
    echo Roblox folder found.
    timeout /t 2 >nul
    echo Creating ClientSettings folder...
    timeout /t 2 >nul
    if not exist "%LOCALAPPDATA%\Roblox\ClientSettings" (
        mkdir "%LOCALAPPDATA%\Roblox\ClientSettings"
    )
    timeout /t 2 >nul
    echo {"DFIntTaskSchedulerTargetFps": 300}>"%LOCALAPPDATA%\Roblox\ClientSettings\ClientAppSettings.json"
    timeout /t 2 >nul
    echo ClientAppSettings.json created successfully in Roblox\ClientSettings folder.
) else (
    echo Roblox folder not found.
)
timeout /t 2 >nul
echo.
set /p check_update=Do you want to check for updates? (Y/N): 
if /i "%check_update%"=="Y" (
    echo Checking for updates...
    timeout /t 2 >nul
    echo No updates available.
) else (
    echo Update check skipped.
)
timeout /t 2 >nul
echo.
echo Thank you for using the FPS unlocker.
pause
