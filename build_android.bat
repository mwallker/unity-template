set logpath=".\Logs\Build-Android.log"
set unitypath="C:\Program Files\Unity\Hub\Editor\2022.3.9f1\Editor\Unity.exe"
set buildpath=".\Builds\Android"
set method="ProjectBuilder.BuildAndroid"

del %logpath%
rmdir %buildpath%

%unitypath% -quit -batchmode -executeMethod %method% -logFile %logpath% -nographics