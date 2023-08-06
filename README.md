# unity-ci-template

## Get license workflow

### Converting into a license

Follow these (one-time) steps for simple activation.

1. Run 'Activation' workflow.
2. Download the manual activation file that now appeared as an artifact and extract the Unity_v20XX.X.XXXX.alf file from the zip.
3. Visit [license.unity3d.com](https://license.unity3d.com/manual) and upload the Unity_v20XX.X.XXXX.alf file.
4. You should now receive your license file (Unity_v20XX.x.ulf) as a download. It's ok if the numbers don't match your Unity version exactly.

Then open `Github > Repository > Settings > Secrets`.
Create the following secrets:

- UNITY_LICENSE - (Copy the contents of your license file into here)
- UNITY_EMAIL - (Add the email address that you use to login to Unity)
- UNITY_PASSWORD - (Add the password that you use to login to Unity)

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
