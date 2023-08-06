# unity-ci-template

## Basic project structure
In top navigation menu select `Assets > Create Default Folders`

## How to build

### WebGL settings

```
set projectpath=".\"
set logpath=".\Logs\Build-WebGL.log"
set unitypath="C:\Program Files\Unity\Hub\Editor\2022.3.6f1\Editor\Unity.exe"
set buildpath=".\Builds\WebGL"
set method="ProjectBuilder.BuildWebGL"
```

### Windows settings

```
set projectpath=".\"
set logpath=".\Logs\Build-Windows.log"
set unitypath="C:\Program Files\Unity\Hub\Editor\2022.3.6f1\Editor\Unity.exe"
set buildpath=".\Builds\Windows"
set method="ProjectBuilder.BuildWindows"
```

### Cleanup

```
del %logpath%
rmdir %buildpath%
```

### Build script

```
%unitypath% -quit -batchmode -projectpath %projectpath% -executeMethod %method% -logFile %logpath%
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

