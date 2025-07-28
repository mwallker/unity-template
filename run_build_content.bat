echo Output path for the build and logs
set UNITY_VERSION=6000.0.53f1
set LOG_PATH=Logs\Build.log

echo Set Unity executable path
set UNITY_PATH=C:\Program Files\Unity\Hub\Editor\%UNITY_VERSION%\Editor\Unity.exe

echo Run Unity build command based on the specified platform
"%UNITY_PATH%" -batchmode -executeMethod "AndroidBuilder.BuildContent" -quit -logFile "%LOG_PATH%" -nographics
