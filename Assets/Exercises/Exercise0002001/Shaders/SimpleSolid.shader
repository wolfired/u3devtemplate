Shader "Simple/Solid" {
    Properties {
        _ColorOff ("Color Off", Color) = (1, 1, 1, 1)
        _ColorDiffuse ("Color Diffuse", Color) = (1, 1, 1, 1)
        _ColorAmbient ("Color Ambient", Color) = (1, 1, 1, 1)
        _ColorSpecular ("Color Specular", Color) = (0, 0, 0, 0)
        _Shininess ("Shininess", Range(0.0, 1.0)) = 0.5
        _ColorEmission ("Color Emission", Color) = (0, 0, 0, 0)
    }

    SubShader {
        Tags {
            "Queue" = "Geometry"
        }

        Pass {
            Color [_ColorOff]
            Material {
                Diffuse     [_ColorDiffuse]
                Ambient     [_ColorAmbient]
                Specular    [_ColorSpecular]
                Shininess   [_Shininess]
                Emission    [_ColorEmission]
            }
            Lighting On
        }
    }
}