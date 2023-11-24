set logpath=".\Logs\Build-WebGL.log"
set unitypath="C:\Program Files\Unity\Hub\Editor\2022.3.9f1\Editor\Unity.exe"
set buildpath=".\Builds\WebGL"
set method="ProjectBuilder.BuildWebGL"

del %logpath%
rmdir %buildpath%

%unitypath% -quit -batchmode -executeMethod %method% -logFile %logpath% -nographics
