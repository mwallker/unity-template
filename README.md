# unity-mobile-template

## Basic project structure
In top navigation menu select `Assets > Create Default Folders`

## Environment Setup
1. Install `ngrok` client:
```
brew install ngrok/ngrok/ngrok
```

2. Install `Jenkins` using MacOS package manager:
```
brew install jenkins-lts
```

3. Create `Freestyle Project` or `Multi-configuration project` in `Jenkins` management portal.
4. In `Source code management` section add reference to github repository and target branch.
5. In `Build Triggers` section check `GitHub hook trigger for GITScm polling`.
6. In `Build Steps` specify building command from section below.
7. Add Payload URL to github webhooks section and specify build events:

```
https://4f8f-2a02-a310-c25c-2800-6555-37ac-cfde-4229.ngrok-free.app/github-webhook/
```

## How to build

Execute building script `run_build.bat` (when running on Windows) or `run_build.sh` (for Mac), with providing platform as argument (Android, WebGL, iOS, Windows)

If building for `WebGL`, build can be tested with running local server (`node.js` required)
```
npx http-server -b -g -o
```

## Downloadable content

1. Install Addressable package
2. Go to `Windows > Asset Management > Addressables > Groups`
3. Press `Create Addressables Settings` to setup package
4. Create new default asset group and in settings insure value of `Content Update Restrictions`

## UI Toolkit

1. Create view `Create > UI Toolkit > UI Document`
2. Create style sheet `Create > UI Toolkit > Style Sheet`
3. Create script with references to `VisualElement` and `StyleSheet` references to act as ViewModel

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

