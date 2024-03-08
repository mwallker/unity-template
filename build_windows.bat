set logpath=".\Logs\Build-Windows.log"
set unitypath="C:\Program Files\Unity\Hub\Editor\2023.2.13f1\Editor\Unity.exe"
set buildpath=".\Builds\Windows"
set method="Builder.RunWindows"

del %logpath%
rmdir %buildpath%

%unitypath% -quit -batchmode -executeMethod %method% -logFile %logpath% -nographics