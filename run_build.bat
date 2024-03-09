REM Output path for the build and logs
SET UNITY_VERSION=2023.2.13f1
SET BUILD_PATH=Builds\%1
SET LOG_PATH=Logs\Build_%1.log

REM Set Unity executable path
SET UNITY_PATH=C:\Program Files\Unity\Hub\Editor\%UNITY_VERSION%\Editor\Unity.exe

REM Remove log file if it exists
IF EXIST "%LOG_PATH%" DEL "%LOG_PATH%"

REM Create the build directory if it doesn't exist
MKDIR "%BUILD_PATH%"

REM Run Unity build command based on the specified platform
"%UNITY_PATH%" -batchmode -executeMethod "Builder.Run_%1" -quit -logFile "%LOG_PATH%" -nographics

ECHO Build completed for platform: %1