Shader "CustomPostProcessing/ScreenTint"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags {"RenderType"="Opaque", "RenderPipeline"="UniversalPipeline"}
        Pass 
        {
            HLSLPROGRAM

            #pragma vertex vert;
            #pragma fragment frag;

           sampler2D _MainTex;
           float _intensity;
           float _OverlayColor;

           struct appdata 
           {
               float4 vertex: POSITION;
               float2 uv : TEXTCOORD0;
           };

           struct v2f 
           {
                float4 vertex : SV_POSITION;
                float2 uv : TEXTCOORD0M
           }

           v2f vert(appdata v) 
           {
               v2f 0;
               o.vertex = TransformObjectToHClip(v.vertex);
               o.uv = v.uv;
               return o;
           }
        }
    }
}
