# Project Overview

There are 2 demos inside the project, basically they have very identical code and structure. The difference is that for Demo 1, it uses **Contract Names** for the parent scene context and **Parent Contract Names** for the child scene context. But for Demo 2, it uses API to load

```cs
// moduleName is scene name
_sceneLoader.LoadSceneAsync(
    moduleName,
    UnityEngine.SceneManagement.LoadSceneMode.Additive,
    (x) => {},
    Zenject.LoadSceneRelationship.Child)
```

The outcome is that **Demo 1 works great** for binding reference to two child scene context while **Demo 2 has issue on binding**. Demo 2 binds reference fine for the first child scene context, but not the second(remaining ones).
