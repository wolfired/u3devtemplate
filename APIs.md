# 常用Dotnet API

# 常用Unity API

## UnityEditor

* `UnityEditor.AssetDatabase`   
  访问与修改资源的接口

* `UnityEditor.AssetImporter` : `UnityEngine.Object`   
  资源导入器, 由特定资源对应的资源导入器继承

* `UnityEditor.AudioImporter` : `UnityEditor.AssetImporter`   
  音频资源导入器

* `UnityEditor.IHVImageFormatImporter` : `UnityEditor.AssetImporter`

* `UnityEditor.ModelImporter` : `UnityEditor.AssetImporter`   
  模型导入器

* `UnityEditor.PluginImporter` : `UnityEditor.AssetImporter`   
插件导入器

* `UnityEditor.SpeedTreeImporter` : `UnityEditor.AssetImporter`

* `UnityEditor.SubstanceImporter` : `UnityEditor.AssetImporter`

* `UnityEditor.TextureImporter` : `UnityEditor.AssetImporter`   
  纹理导入器

* `UnityEditor.TrueTypeFontImporter` : `UnityEditor.AssetImporter`   
  字体导入器

* `UnityEditor.VideoClipImporter` : `UnityEditor.AssetImporter`   
  视频剪辑导入器

* `UnityEditor.AssetPostprocessor`   
  导入资源后续自动化处理

* `UnityEditor.Selection`   
  访问在编辑器中选中的对象

* `UnityEditor.PrefabUtility`   
  工具类, 包含全部预制件的相关操作

* `UnityEditor.ArrayUtility`   
  内置数组的辅助类

* `UnityEditor.PlayerSettings` : `UnityEngine.Object`   
  最终的游戏参数

* `UnityEditor.BuildPipeline`   
  程序化构建游戏和asset bundle

* `UnityEditor.EditorPrefs`
  保存/访问 __Unity Editor__ 的用户设置数据

## UnityEngine

### Classes

* `UnityEngine.Object`   
  所有对象的基类

* `UnityEngine.GameObject` : `UnityEngine.Object`   
  场景中所有实体的基类

* `UnityEngine.Component` : `UnityEngine.Object`   
  所有要附加到 `GameObject` 的组件的基类

* `UnityEngine.ScriptableObject` : `UnityEngine.Object`   
  所有不附加到 `GameObject` 的组件的基类

* `UnityEngine.Behaviour` : `UnityEngine.Component`   
  增加 `enabled` 和 `disabled` 两个行为

* `UnityEngine.MonoBehaviour` : `UnityEngine.Behaviour`   
  所有 _Unity_ 脚本都要继承的类   
  如果脚本有以下函数, 编辑器会提供一个可选框用于停用脚本:

  ```c#
  Start()
  Update()
  FixedUpdate()
  LateUpdate()
  OnGUI()
  OnDisable()
  OnEnable()
  ```

* `UnityEngine.Logger` : `UnityEngine.ILogger`   
  日志记录器

* `UnityEngine.Debug`   
  工具类, 包含一个默认的 _日志记录器_ 和一些静态方法, 方便开发

* `UnityEngine.Event`   
  UnityGUI事件, 包括用户输入事件, UnityGUI布局事件, UnityGUI渲染事件.   
  每个事件都会触发 `OnGUI()` , 所以在一帧内 `OnGUI()`可能会被多次触发.   
  在 `OnGUI()` 内使用 `Event.current` 操作当前事件.

* `UnityEngine.GUI`   
  `GUI` 作为 _Unity_ 的手动排版用户界面接口

* `UnityEngine.GUILayout`   
  `GUILayout` 作为 _Unity_ 的自动排版用户界面接口

* `UnityEngine.YieldInstruction`   
  所有 `yield` 指令的基类

* `UnityEngine.Coroutine` : `UnityEngine.YieldInstruction`   
  `MonoBehaviour.StartCoroutine()` 返回此类的实例

* `UnityEngine.WaitForSeconds` : `UnityEngine.YieldInstruction`   
  将协程挂起指定时间, 受时间的缩放影响

* `UnityEngine.WaitForFixedUpdate` : `UnityEngine.YieldInstruction`   
  挂起协程直至下个 `FixedUpdate()`

* `UnityEngine.WaitForEndOfFrame` :  `UnityEngine.YieldInstruction`   
  挂起协程直至当前帧结束, 在渲染结束后, 显示到屏幕前

* `UnityEngine.CustomYieldInstruction`   
  所有自定义 `yield` 指令的基类

* `UnityEngine.WaitUntil` : `UnityEngine.CustomYieldInstruction`   
  挂起协程直至指定的代理返回 `true`

* `UnityEngine.WaitWhile` : `UnityEngine.CustomYieldInstruction`   
  挂起协程直至指定的代理返回 `false`

* `UnityEngine.WWW` : `UnityEngine.CustomYieldInstruction`   
  简易访问网页资源

* `UnityEngine.WWWForm`   
  用于向web服务器 _POST_ 数据, 配合 `WWW`, `UnityWebRequest` 使用

* `UnityEngine.Networking.UnityWebRequest`   
  与web服务器通信

* `UnityEngine.Networking.DownloadHandler`

* `UnityEngine.Networking.DownloadHandlerBuffer` : `UnityEngine.Networking.DownloadHandler`

* `UnityEngine.Networking.DownloadHandlerTexture` : `UnityEngine.Networking.DownloadHandler`

* `UnityEngine.Networking.DownloadHandlerAudioClip` : `UnityEngine.Networking.DownloadHandler`

* `UnityEngine.Networking.DownloadHandlerAssetBundle` : `UnityEngine.Networking.DownloadHandler`

* `UnityEngine.Networking.DownloadHandlerScript` : `UnityEngine.Networking.DownloadHandler`

* `UnityEngine.Networking.UploadHandler`

* `UnityEngine.Networking.UploadHandlerRaw` : `UnityEngine.Networking.UploadHandler`

* `UnityEngine.Application`   
  访问应用的运行时数据

* `UnityEngine.Sprite`   
  表示2D游戏里的一个Sprite, 通过 `Sprite.Create` 创建

* `UnityEngine.Texture` : `UnityEngine.Object`   
  所有纹理处理器的基类

* `UnityEngine.Texture2D` : `UnityEngine.Texture`

* `UnityEngine.PlayerPrefs`   
  保存玩家数据

* `UnityEngine.UnityEventBase`

* `UnityEngine.Profiler`
  性能分析

### Interfaces

* `UnityEngine.ICanvasRaycastFilter`
  射线过滤器, 顶层元素被点击后进行进一步的有效性验证, 如: 是否点击了图片的透明区域

* `UnityEngine.ILogHandler`   
  自定义日志处理器要实现的接口

* `UnityEngine.ILogger` : `ILogHandler`   
  自定义日志记录器要实现的接口