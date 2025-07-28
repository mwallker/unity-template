#!/bin/bash

# Check if the platform argument is provided
# if [ -z "$1" ]; then
#   echo "Please provide a platform argument (e.g. Android, ios, windows or webgl)"
#   exit 1
# fi

echo "Build started"

# Output path for the build and logs
UNITY_VERSION="6000.0.54f1"
BUILD_PATH="/Builds/Android"
LOG_PATH="./Logs/Build_Android.log"
UNITY_PATH="/Applications/Unity/Hub/Editor/$UNITY_VERSION/Unity.app/Contents/MacOS/Unity"

# Create the build directory if it doesn't exist and clear logs
rm -f "$LOG_PATH"
rm -rf "$BUILD_PATH"

# Run Unity build command based on the specified platform
"$UNITY_PATH" \
  -batchmode \
  -quit \
  -nographics \
  -logFile "$LOG_PATH" \
  -executeMethod "AndroidBuilder.Run"

echo "Build finished"