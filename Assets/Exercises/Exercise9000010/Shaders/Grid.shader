// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'
Shader "Exercises/Exercise9000010/Grid"
{
	Properties
	{
        [HideInInspector]
        _mode("正/斜", float) = 0
		_planeWid("平面宽度", Range(1.0, 200.0)) = 20
		_planeHei("平面高度", Range(1.0, 200.0)) = 20
        _gridSize("网格大小",Range(1.0,4.0)) = 1
        _slope("网格斜率", Range(0.5, 1.732)) = 1
		_lineColor("线条颜色",Color) = (0.5,0.5,0.5)
		_lineWidth("线条粗细",Range(0.001,0.1)) = 0.02
	}

	SubShader
	{
		Pass
		{
			CGPROGRAM
			#pragma vertex main_vertex
			#pragma fragment main_fragment  

			#include "UnityCG.cginc"

            uniform float _mode;
			uniform float _planeWid;
			uniform float _planeHei;
			uniform float _gridSize;
            uniform float _slope;
            uniform float4 _lineColor;
			uniform float _lineWidth;

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f main_vertex(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}

			float4 main_fragment(v2f i) : COLOR
			{
                if(0.0 == _mode) {
                    // 正方格
                    float aspect = _planeWid / _planeHei;
                    float grid_count = _planeHei / _gridSize;
                    float line_h = i.uv.x * aspect * grid_count;
                    float line_v = i.uv.y * grid_count;
                    if(abs(floor(line_h + 0.5) - line_h) > _lineWidth && abs(floor(line_v + 0.5) - line_v) > _lineWidth) {
                        discard;
                    }
                } else {
                    // 斜方格
                    float aspect = _planeWid / _planeHei;
                    float grid_count = _planeHei / _gridSize;
                    float args_x = ((i.uv.x - 0.5) * aspect) * _slope * grid_count;
                    float args_y = (i.uv.y - 0.5) * grid_count;
                    float line_up = -args_x + args_y;// _slope > 0
                    float line_down = args_x + args_y;// _slope < 0
                    
                    if (abs(floor(line_up + 0.5) - line_up) > _lineWidth && abs(floor(line_down + 0.5) - line_down) > _lineWidth) {
                    	discard;
                    }
                }

				return _lineColor;
			}
			ENDCG
		}
	}
}
