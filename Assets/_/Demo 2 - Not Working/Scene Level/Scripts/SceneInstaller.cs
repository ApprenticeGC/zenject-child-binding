using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChildBinding.Demo2.Scene
{
    public class SceneInstaller : Zenject.MonoInstaller<SceneInstaller>
    {
        [System.Serializable]
        public class Settings
        {
            public List<string> loadingModules;
        }

        public Settings settings;

        public override void InstallBindings()
        {
            Container.Bind<Settings>().FromInstance(settings).AsSingle();
            Container.BindInterfacesAndSelfTo<SceneManager>().AsSingle();
        }
    }
}
