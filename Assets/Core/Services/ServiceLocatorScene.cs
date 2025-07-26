using UnityEngine;

[AddComponentMenu("ServiceLocator/ServiceLocator Scene")]
public class ServiceLocatorScene : ServiceBootstrapper {
    protected override void Bootstrap() {
        Container.ConfigureForScene();
    }
}