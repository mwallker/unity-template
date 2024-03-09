#!/bin/bash

# Check if the platform argument is provided
if [ -z "$1" ]; then
  echo "Please provide a platform argument (e.g. android, ios, windows or webgl)"
  exit 1
fi

echo "Build started for platform: $1"

# Output path for the build and logs
UNITY_VERSION="2023.2.13f1"
BUILD_PATH="/Builds/$1"
LOG_PATH="./Logs/Build_$1.log"
UNITY_PATH="/Applications/Unity/Hub/Editor/$UNITY_VERSION/Unity.app/Contents/MacOS/Unity"

# Create the build directory if it doesn't exist and clear logs
rm -f "$LOG_PATH"
rm -rf "$BUILD_PATH"

# Run Unity build command based on the specified platform
"$UNITY_PATH" -batchmode -executeMethod "Builder.Run_$1" -quit -logFile "$LOG_PATH" -nographics

echo "Build completed for platform: $1"