# u3devtemplate

## [Special folders and script compilation order](https://docs.unity3d.com/2017.4/Documentation/Manual/ScriptCompileOrderFolders.html)

Unity保留了一些项目文件夹名称以表示其内容有特殊用途。其中一些文件夹影响脚本的编译顺序。

* Assets: Unity项目使用的所有资源都被保存在这个文件夹。
* Editor
* Editor Default Resources
* Gizmos
* Plugins
* Resources
* Standard Assets
* StreamingAssets

[查看](https://docs.unity3d.com/2017.4/Documentation/Manual/SpecialFolders.html)这些文件夹的详细信息。

Unity根据脚本的存放目录，分四个独立阶段编译脚本。Unity为每个阶段创建独立的CSharp项目文件（.csproj）和预定义程序集。

编译阶段如下表：

| Phase | Assembly name                    | Script files                                                                                                                                |
| ----- | -------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
| 1     | Assembly-CSharp-firstpass        | Runtime scripts in folders called Standard Assets, Pro Standard Assets and Plugins.                                                         |
| 2     | Assembly-CSharp-Editor-firstpass | Editor scripts in folders called Editor that are anywhere inside top-level folders called Standard Assets, Pro Standard Assets and Plugins. |
| 3     | Assembly-CSharp                  | All other scripts that are not inside a folder called Editor.                                                                               |
| 4     | Assembly-CSharp-Editor           | All remaining scripts (those that are inside a folder called Editor.)                                                                       |

## [Some common types of Asset](https://docs.unity3d.com/2017.4/Documentation/Manual/ImportingAssets.html)

* 图像文件
* 3D模型文件
* 音频文件

## 类备注

* `UnityWebRequest`：
