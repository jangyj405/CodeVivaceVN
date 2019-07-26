// Unity built-in shader source. Copyright (c) 2016 Unity Technologies. MIT license (see license.txt)

// Unlit alpha-blended shader.
// - no lighting
// - no lightmap support
// - no per-material color

Shader "Unlit/Transparent" {
Properties {
    _MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
    _MainTex2 ("Tex (RGB) Trans (A)", 2D) = "white" {}
 	_Radius("Radius", float) = 0
	_Radius2("Radius2", float) = 0
}

SubShader {
    Tags {"Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent"}
    LOD 100

    ZWrite Off
    Blend SrcAlpha OneMinusSrcAlpha

    Pass {
        CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma target 2.0
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata_t {
                float4 vertex : POSITION;
                float2 texcoord : TEXCOORD0;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct v2f {
                float4 vertex : SV_POSITION;
                float2 texcoord : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                UNITY_VERTEX_OUTPUT_STEREO
            };

            sampler2D _MainTex;
			sampler2D _MainTex2;
            float4 _MainTex_ST;
			float _Radius;
			float _Radius2;
            v2f vert (appdata_t v)
            {
                v2f o;
                UNITY_SETUP_INSTANCE_ID(v);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.texcoord);
				fixed4 col2 = tex2D(_MainTex2, i.texcoord);
				
				half tStep = step(pow(_Radius2, 2), pow(i.texcoord.r-0.5, 2) + pow(i.texcoord.g-0.5, 2));
				half tStep2 = 1 - tStep;

				fixed4 result = step(pow(_Radius, 2), pow(i.texcoord.r - 0.5, 2) + pow(i.texcoord.g - 0.5, 2))* (tStep * col + tStep2 * col2);
					

                UNITY_APPLY_FOG(i.fogCoord, result);
                return result;
            }
        ENDCG
    }
}

}
