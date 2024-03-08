set logpath=".\Logs\Build-Android.log"
set unitypath="C:\Program Files\Unity\Hub\Editor\2023.2.13f1\Editor\Unity.exe"
set buildpath=".\Builds\Android"
set method="Builder.RunAndroid"

del %logpath%
rmdir %buildpath%

%unitypath% -quit -batchmode -executeMethod %method% -logFile %logpath% -nographics