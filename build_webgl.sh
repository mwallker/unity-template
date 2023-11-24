#!/bin/bash

logpath="./Logs/Build-WebGL.log"
unitypath="/Applications/Unity/Hub/Editor/2022.3.9f1/Unity.app/Contents/MacOS/Unity"
buildpath="./Builds/WebGL"
method="ProjectBuilder.BuildWebGL"

rm -f "$logpath"
rm -rf "$buildpath"

"$unitypath" -quit -batchmode -executeMethod "$method" -logFile "$logpath" -nographics