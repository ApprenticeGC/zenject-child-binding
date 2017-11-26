using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChildBinding.Demo1.Module.UI
{
    public class ModuleManager : Zenject.IInitializable
    {
        private readonly Common.ISceneManager _sceneManager;

        public ModuleManager(Common.ISceneManager sceneManager)
        {
            _sceneManager = sceneManager;
        }

        public void Initialize()
        {
            _sceneManager.SayHello();
        }
    }
}
