# 常用Dotnet API

# 常用Unity API

## UnityEditor

## UnityEngine

### Classes

1. `UnityEngine.Object`   
   所有对象的基类

2. `UnityEngine.GameObject` -> `UnityEngine.Object`   
   场景中所有实体的基类

3. `UnityEngine.Component` -> `UnityEngine.Object`   
   所有要附加到 `GameObject` 的组件的基类

4. `UnityEngine.ScriptableObject` -> `UnityEngine.Object`   
   所有不附加到 `GameObject` 的组件的基类

5. `UnityEngine.Behaviour` -> `UnityEngine.Component`   
   增加 `enabled` 和 `disabled` 两个行为

6. `UnityEngine.MonoBehaviour` -> `UnityEngine.Behaviour`   
   所有 _Unity_ 脚本都要继承的类
   > 如果脚本有以下函数, 编辑器会提供一个可选框用于停用脚本:   
   > `Start()`   
   > `Update()`   
   > `FixedUpdate()`   
   > `LateUpdate()`   
   > `OnGUI()`   
   > `OnDisable()`   
   > `OnEnable()`

7. `UnityEngine.Logger` -> `UnityEngine.ILogger`   
   日志记录器

8. `UnityEngine.Debug`   
   工具类, 包含一个默认的 _日志记录器_ 和一些静态方法, 方便开发

9. `UnityEngine.Event`   
   UnityGUI事件, 包括用户输入事件, UnityGUI布局事件, UnityGUI渲染事件.
   每个事件都会触发 `OnGUI()` , 所以在一帧内 `OnGUI()`可能会被多次触发.
   在 `OnGUI()` 内使用 `Event.current` 操作当前事件.

10. `UnityEngine.GUI`   
    `GUI` 作为 _Unity_ 的手动排版用户界面接口

11. `UnityEngine.GUILayout`
    `GUILayout` 作为 _Unity_ 的自动排版用户界面接口

12. `UnityEngine.YieldInstruction`   
    所有 `yield` 指令的基类

    1.  `UnityEngine.Coroutine` -> `UnityEngine.YieldInstruction`   
        `MonoBehaviour.StartCoroutine()` 返回此类的实例

    2.  `UnityEngine.WaitForSeconds` -> `UnityEngine.YieldInstruction`   
        将协程挂起指定时间, 受时间的缩放影响

    3.  `UnityEngine.WaitForFixedUpdate` -> `UnityEngine.YieldInstruction`   
        挂起协程直至下个 `FixedUpdate()`

    4.  `UnityEngine.WaitForEndOfFrame` ->  `UnityEngine.YieldInstruction`   
        挂起协程直至当前帧结束, 在渲染结束后, 显示到屏幕前

13. `UnityEngine.CustomYieldInstruction`   
    所有自定义 `yield` 指令的基类

    1.  `UnityEngine.WaitUntil` -> `UnityEngine.CustomYieldInstruction`   
        挂起协程直至指定的代理返回 `true`

    2.  `UnityEngine.WaitWhile` -> `UnityEngine.CustomYieldInstruction`   
        挂起协程直至指定的代理返回 `false`

    3.  `UnityEngine.WWW` -> `UnityEngine.CustomYieldInstruction`   
        简易访问网页资源

14. `UnityEngine.WWWForm`
    用于向web服务器 _POST_ 数据, 配合 `WWW`, `UnityWebRequest` 使用

15. `UnityEngine.Networking.UnityWebRequest`
    与web服务器通信

16. `UnityEngine.Networking.DownloadHandler`

    1.  `UnityEngine.Networking.DownloadHandlerBuffer` -> `UnityEngine.Networking.DownloadHandler`   

    2.  `UnityEngine.Networking.DownloadHandlerTexture` -> `UnityEngine.Networking.DownloadHandler`   

    3.  `UnityEngine.Networking.DownloadHandlerAudioClip` -> `UnityEngine.Networking.DownloadHandler`   

    4.  `UnityEngine.Networking.DownloadHandlerAssetBundle` -> `UnityEngine.Networking.DownloadHandler`   

    5.  `UnityEngine.Networking.DownloadHandlerScript` -> `UnityEngine.Networking.DownloadHandler`   

17. `UnityEngine.Networking.UploadHandler`   

    1.  `UnityEngine.Networking.UploadHandlerRaw` -> `UnityEngine.Networking.UploadHandler`   

18. `UnityEngine.Application`
    访问应用的运行时数据

19. `UnityEngine.Sprite`   
    表示2D游戏里的一个Sprite, 通过 `Sprite.Create` 创建

20. `UnityEngine.Texture` -> `UnityEngine.Object`   
    所有纹理处理器的基类

21. `UnityEngine.Texture2D` -> `UnityEngine.Texture`   

### Interfaces

1. `ILogHandler`   
   自定义日志处理器要实现的接口

2. `ILogger` -> `ILogHandler`   
   自定义日志记录器要实现的接口
