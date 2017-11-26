using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChildBinding.Demo1.Module.Logic
{
    public class ModuleInstaller : Zenject.MonoInstaller<ModuleInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ModuleManager>().AsSingle();
        }
    }
}
