```
Shader "Shader Path/Shader Name"
{
    // 可选属性列表, 显示在材质检视器
    Properties
    {
        // 属性修饰符:
        // [HideInInspector]: 不在材质检视器中显示
        // [NoScaleOffset]: 材质检视器中的纹理参数不显示tiling/offset字段
        // [Normal]: 标记纹理参数需要法线图
        // [HDR]: 标记纹理参数需要HDR图
        // [Gamma]: 
        // [PerRendererData]:
        // [MainTexture]: 标记纹理参数是材质主纹理. Unity默认属性名是_MainTex的纹理是材质主纹理, 如果你想使用其它属性名, 就需要使用此修饰符. 修饰符可以多次指定, 但只有第一个生效
        // [MainColor]: 标记颜色参数是材质主颜色. Unity默认属性名是_Color的颜色是材质主颜色, 如果你想使用其它属性名, 就压根使用此修饰符. 修饰符可以多次指定, 但只有第一个生效

        // 属性类型:
        // Int = 0
        // Float = 0.0
        // Range(min, max) = 0.0
        // Color = (0.0,0.0,0.0,0.0)
        // Vector = (0.0,0.0,0.0,0.0)
        // 2D = "" {}
        // 3D = "" {}
        // Cube = "" {}
        // 
        // Float与Range都是浮点型, Range多了个区间
        // 纹理型有内建默认值: "white", "black", "gray", "bump", "red", ...
        // 对于非2D纹理, 如果材质没指定值则使用: "gray"
        // 在固定功能管线着色器中, 功能指令引用参数格式：[PropertyName]
        // 在Properties块中定义的参数会序列化到材质数据中, 那些运行时增加的参数, 通过Material.Set*函数族修改

        // 属性完整语法:
        // 属性修饰符 属性名 ("材质检视器显示名", 属性类型) = 默认值
    }

    // 子着色器列表, 至少有一个, 使用第一个显卡支持的子着色器
    Subshader
    {
        // 标签列表
        // 渲子着色器使用标签通知渲染引擎, 它们希望如何及何时进行渲染
        // 你可以设置任意数量标签
        // 标签基于键/值对, 在子着色器中, 标签用于决定渲染顺序或其它子着色器参数
        // 下面列举的Unity能识别的标签只能用于子着色器, 不能用于渲染阶段
        //
        // Queue标签, 指定对象的渲染顺序. 着色器通过这个标签决定它所属的对象归属那个渲染队列, 所以所有透明着色器要确保它们要在所有不透明对象渲染完毕后才开始进行渲染
        // 有四个预定义的渲染队列, 在这些预定义队列中可以插入更多不同的渲染队列:
        //   Background: 索引值1000
        //   Geometry: 索引值2000, 默认队列
        //   AlphaTest: 索引值2450
        //   Transparent: 索引值3000
        //   Overlay: 索引值4000
        //
        // RenderType标签
        //
        // DisableBatching标签
        //
        // ForceNoShadowCasting标签
        //
        // IgnoreProjector标签
        //
        // CanUseSpriteAtlas标签
        //
        // PreviewType标签
        Tags
        {

        }
        [CommonState]

        // 渲染阶段列表
        // Unity在选定使用的子着色器后, 将逐一使用每个渲染阶段对渲染物进行渲染
        // 渲染阶段有三种定义方式: RegularPass, UsePass, GrabPass
        // Any statements that are allowed in a Pass definition can also appear in Subshader block. This will make all passes use this “shared” state

        // RegularPass定义:
        Pass
        {
            // 渲染阶段命名
            // 给渲染阶段指定一个名字, 方便UsePass指令引用, 名字在内部会被转换成大写
            Name "PassName"

            // 标签列表
            // 渲染阶段使用标签通知渲染引擎, 它们希望如何及何时进行渲染
            // 你可以设置任意数量标签
            // 标签基于键/值对, 在渲染阶段中, 标签用于控制如: 在光照管线中当前渲染阶段的角色或其它选项
            // 下面列举的Unity能识别的标签只能用于渲染阶段:
            //
            // LightMode标签, 指定渲染阶段在光照管线中的角色, 可选值
            //     Always: 总是渲染, 无照明
            //     ForwardBase: 
            //     ForwardAdd:
            //     Deferred:
            //     ShadowCaster:
            //     MotionVectors:
            //     PrepassBase:
            //     PrepassFinal:
            //     Vertex:
            //     VertexLMRGBM:
            //     VertexLM:
            //
            // PassFlags标签, 可选值
            //     OnlyDirectional:
            //
            // RequireOptions标签, 可选值
            //     SoftVegetation:
            Tags
            {
                "TagName" = "TagValue"
            }

            // 渲染器设置
            // 渲染阶段为图形硬件设置各种状态, 如: alpha混合是否开启, 深度测试是否开启
            //
            // 命令列表如下:
            //
            //   Cull, 面消除模式命令, 指定渲染对象那些面应该消除, 可选值:
            //     Back: 默认值, 消除背向观察者的面
            //     Front: 消除面向观察者的面
            //     Off: 关闭消除模式
            //
            //   ZWrite, 深度缓冲区可写模式命令, 指定渲染对象是否应该写入深度缓冲区, 可选值
            //     On: 默认值, 如果渲染对象是不透明物体, 应该开启此模式
            //     Off: 如果渲染对象是半透明物体, 应该关闭此模式
            //
            //   ZTest, 深度缓冲区测试模式命令, 指定深度测试比较模式
            //      Less: 
            //      Greater: 
            //      LEqual: 默认值
            //      GEqual: 
            //      Equal: 
            //      NotEqual: 
            //      Always: 
            //      Never: 
            //
            //   深度缓冲区偏移参数:
            //     Offset OffsetFactor, OffsetUnits
            //
            //   混合:
            //     Blend sourceBlendMode destBlendMode
            //     Blend sourceBlendMode destBlendMode, alphaSourceBlendMode alphaDestBlendMode
            //     BlendOp colorOp
            //     BlendOp colorOp, alphaOp
            //     AlphaToMask On | Off
            //
            //   颜色遮罩:
            //     ColorMask RGB | A | 0 | any combination of R, G, B, A
            //
            // 固定功能着色器遗留命令:
            //
            //   雾: 
            //     Fog
            //     {
            //         Mode Off | Global | Linear | Exp | Exp2
            //         Color ColorValue
            //         Density FloatValue
            //         Range FloatValue, FloatValue
            //     }
            //
            //   透明度测试:
            //     AlphaTest (Less | Greater | LEqual | GEqual | Equal | NotEqual | Always) CutoffValue
            //
            //   纹理合成:
            //     SetTexture textureProperty { combine options }
        }

        // UsePass: 通过UsePass命令从其它着色器的第一个可使用子着色器引用指定的渲染阶段
        // 渲染阶段名需要大写
        UsePass "Shader Path/Shader Name/PASSNAME"

        // GrabPass: 捕获屏幕内容保存到纹理, 以便后续渲染阶段进行特效处理
        // 两和使用格式:
        //   简单模式, 捕获的纹理保存在_GrabTexture这个内建纹理属性中, 每个使用此属性进行渲染的对象都会触发一次相当耗时的屏幕捕获操作
        //     GrabPass {}
        //
        //   指定纹理模式, 捕获的纹理保存在指定属性名的纹理属性中, 此模式只有第一个使用此属性进行渲染的对象会触发屏幕捕获操作
        //     GrabPass { "PropName" }
    }

    // 可选后备着色器, 如果显卡不支持子着色器列表中的任意一个, 使用后备着色器
    // 有两种语法:
    //   Fallback "Shader Path/Shader Name"
    //   Fallback Off

    // 可选自定义检视器类名
    //   CustomEditor "ClassName"
}
```