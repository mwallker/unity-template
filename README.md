# unity-ci-template

## Environment Setup
Install `Jenkins` using MacOS package manager:
```
brew install jenkins-lts
```

Create `Freestyle Project` or `Multi-configuration project` in `Jenkins` management portal. In `Source code management` section add reference to github repository and target branch. In `Build Triggers` section check `GitHub hook trigger for GITScm polling`. In `Build Steps` specify needed commands.

Install `ngrok` client:
```
brew install ngrok/ngrok/ngrok
```

Add Payload URL to github webhooks section and specify build events:

```
https://4f8f-2a02-a310-c25c-2800-6555-37ac-cfde-4229.ngrok-free.app/github-webhook/
```

## Basic project structure
In top navigation menu select `Assets > Create Default Folders`

## How to build

### Android settings

```
set logpath=".\Logs\Build-Android.log"
set buildpath=".\Builds\Android"
set method="Builder.RunAndroid"
```

### WebGL settings

```
set logpath=".\Logs\Build-WebGL.log"
set buildpath=".\Builds\WebGL"
set method="Builder.RunWebGL"
```

### Windows settings

```
set logpath=".\Logs\Build-Windows.log"
set buildpath=".\Builds\Windows"
set method="Builder.RunWindows"
```

### Cleanup

```
del %logpath%
rmdir %buildpath%
```

### Build script

```
%unitypath% -quit -batchmode -executeMethod %method% -logFile %logpath%
```

## Graphics

### URP

1. In the top navigation bar, select `Window > Package Manager` to open the Package Manager window.
2. Select the `All` tab.
3. Select `Universal RP` from the list of packages.
4. In the bottom right corner of the Package Manager window, select Install. Unity installs URP directly into your Project.
5. In the Editor, go to the Project window.
6. Right-click in the Project window, and select `Create > Rendering > Universal Render Pipeline > Pipeline Asset`
**OR** navigate to the menu bar at the top, and select `Assets > Create > Rendering > Universal Render Pipeline > Pipeline Asset`
7. Navigate to `Edit > Project Settings > Graphics`.
In the Scriptable Render Pipeline Settings field, add the Universal Render Pipeline Asset you created earlier.

