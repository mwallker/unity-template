#!/bin/bash
set -e

UNITY="/Applications/Unity/Hub/Editor/6000.0.54f1/Unity.app/Contents/MacOS/Unity"
PROJECT_PATH=$(pwd)

$UNITY \
  -batchmode \
  -nographics \
  -quit \
  -executeMethod AndroidBuilder.BuildContent \
  -logFile Logs/Content/Log.log