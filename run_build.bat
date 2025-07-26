echo Output path for the build and logs
set UNITY_VERSION=6000.0.53f1
set BUILD_PATH=Builds\
set LOG_PATH=Logs\Build.log

echo Set Unity executable path
set UNITY_PATH=C:\Program Files\Unity\Hub\Editor\%UNITY_VERSION%\Editor\Unity.exe

echo Remove log file if it exists
if exist "%LOG_PATH%" del "%LOG_PATH%"

echo Create the build directory if it doesn't exist
mkdir "%BUILD_PATH%"

echo Run Unity build command based on the specified platform
"%UNITY_PATH%" -batchmode -executeMethod "AndroidBuilder.Run" -quit -logFile "%LOG_PATH%" -nographics
