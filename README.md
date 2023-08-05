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
* UNITY_LICENSE - (Copy the contents of your license file into here)
* UNITY_EMAIL - (Add the email address that you use to login to Unity)
* UNITY_PASSWORD - (Add the password that you use to login to Unity)

## Build and deploy WebGL version

## Build and deploy Windows version