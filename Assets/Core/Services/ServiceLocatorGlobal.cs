using UnityEngine;

[AddComponentMenu("ServiceLocator/ServiceLocator Global")]
public class ServiceLocatorGlobal : ServiceBootstrapper {
    [SerializeField] bool dontDestroyOnLoad = true;
    
    protected override void Bootstrap() {
        Container.ConfigureAsGlobal(dontDestroyOnLoad);
    }
}