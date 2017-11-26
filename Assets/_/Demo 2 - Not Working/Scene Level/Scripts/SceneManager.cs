using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

using UniRx;

namespace ChildBinding.Demo2.Scene
{
    public class SceneManager :
        Zenject.IInitializable,
        Common.ISceneManager
    {
        private readonly Zenject.ZenjectSceneLoader _sceneLoader;

        private readonly SceneInstaller.Settings _settings;

        public SceneManager(
            Zenject.ZenjectSceneLoader sceneLoader,
            SceneInstaller.Settings settings)
        {
            _sceneLoader = sceneLoader;
            _settings = settings;
        }

        public void Initialize()
        {
            var moduleObservables =
                _settings.loadingModules.Select(moduleName =>
                    _sceneLoader.LoadSceneAsync(
                        moduleName,
                        UnityEngine.SceneManagement.LoadSceneMode.Additive,
                        (x) => {},
                        Zenject.LoadSceneRelationship.Child).AsObservable());
            var observable = moduleObservables.ToObservable().SelectMany(x => x);

            observable
                .Subscribe(x => {

                });

        }

        #region ISceneManager realization

        public void SayHello()
        {
            Debug.Log("Say Hello from Scene Manager");
        }

        #endregion
    }
}
