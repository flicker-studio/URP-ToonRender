Shader "Non-Photorealistic RP/Unlit"
{

    Properties
    {
        _BaseColor("Color", Color)= (1.0, 1.0, 1.0, 1.0)
        [Enum(UnityEngine.Rendering.BlendMode)] _SrcBlend ("Src Blend", Float) = 1
        [Enum(UnityEngine.Rendering.BlendMode)] _DstBlend ("Dst Blend", Float) = 0
        [Enum(Off, 0, On, 1)] _ZWrite ("Z Write", Float) = 1
    }

    SubShader
    {

        Pass
        {
            Blend [_SrcBlend] [_DstBlend]
            ZWrite [_ZWrite]
            HLSLPROGRAM
            #include "UnlitPass.hlsl"
            #pragma multi_compile_instancing
            #pragma vertex unlit_pass_vertex
            #pragma fragment unlit_pass_fragment
            ENDHLSL

        }
    }
}