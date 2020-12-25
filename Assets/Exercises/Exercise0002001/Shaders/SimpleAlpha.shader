Shader "Simple/Alpha" {
    Properties {
        _Alpha ("Alpha", Range(0.0, 1.0)) = 1.0
        _MainTex ("Texture", 2D) = "white" {}
    }

    SubShader {
        Tags { 
            "Queue" = "Transparent"
        }

        Blend SrcAlpha OneMinusSrcAlpha

        Pass {
            SetTexture [_MainTex] {
                constantColor (1, 1, 1, [_Alpha])
                combine texture * constant
            }
        }
    }
}
