# [进入播放模式配置化](https://docs.unity3d.com/Manual/ConfigurableEnterPlayMode.html)

![][20200716102846.png]_进入播放模式设置_

![][20200716102151.png]_自动刷新设置_

## 域重载(Domain Reloading)

关闭 _Domain Reloading_ 后,

对于 `Runtime Script`, 需要通过:

* `[RuntimeInitializeOnLoadMethodAttribute]`
  官方文档上, 处理 __静态属性__ 需要指定 __loadType__ `RuntimeInitializeLoadType.SubsystemRegistration`   
  处理 __静态事件处理器__ 则无需指定 __loadType__   

重置 __静态属性__ 与 __静态事件处理器__

对于 `Editor Script`, 需要通过:

* `[InitializeOnLoadAttribute]`   
  脚本重编译时触发, 需要开启自动刷新

* `[InitializeOnLoadMethodAttribute]`   
  脚本重编译时触发, 需要开启自动刷新

* `[InitializeOnEnterPlayModeAttribute]`   
  进入Play Mode时触发

重置 __静态属性__ 与 __静态事件处理器__, 具体参考 [Exercise9000007](../Exercise9000007/README.md)

## 场景重载(Scene Reloading)

## 资料

* [Domain Reloading](https://docs.unity3d.com/Manual/DomainReloading.html)
* [Scene Reloading](https://docs.unity3d.com/Manual/SceneReloading.html)
* [The details of entering Play Mode](https://docs.unity3d.com/Manual/ConfigurableEnterPlayModeDetails.html)
* [InitializeOnLoadAttribute](https://docs.unity3d.com/ScriptReference/InitializeOnLoadAttribute.html)
* [InitializeOnLoadMethodAttribute](https://docs.unity3d.com/ScriptReference/InitializeOnLoadMethodAttribute.html)
* [InitializeOnEnterPlayModeAttribute](https://docs.unity3d.com/ScriptReference/InitializeOnEnterPlayModeAttribute.html)
* [RuntimeInitializeLoadType](https://docs.unity3d.com/ScriptReference/RuntimeInitializeLoadType.html)
* [RuntimeInitializeOnLoadMethodAttribute](https://docs.unity3d.com/ScriptReference/RuntimeInitializeOnLoadMethodAttribute.html)

[20200716102846.png]: ./res.md/20200716102846.png
[20200716102151.png]: ./res.md/20200716102151.png
