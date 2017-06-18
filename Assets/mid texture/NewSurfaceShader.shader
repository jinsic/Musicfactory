﻿Shader "Custom/NewSurfaceShader" {
	Properties{
		_ColorTint("Color", Color) = (1,1,1,1)
		_MainTex("Albedo (RGB)", 2D) = "white" {}
	_Glossiness("Smoothness", Range(0,1)) = 0.5
		_RimColor("Rim Color", Color) = (1,1,1,1)
		_RimPower("Rim Power", Range(1.0,6.0)) = 3.0
	}
		SubShader{
		Tags{ "RenderType" = "Opaque" }

		CGPROGRAM
		#pragma surface surf Lambert
		#pragma target 3.0
		struct Input {
		float4 color : Color;
		float2 uv_MainTex;
		float2 uv_BumpMap;
		float3 viewDir;
	};

	float4 _ColorTint;
	sampler2D _MainTex;
	sampler2D _BumpMap;
	float4 _RimColor;
	float _RimPower;

	void surf(Input IN, inout SurfaceOutput o) {
		IN.color = _ColorTint;
		o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb * IN.color;
		o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));
		half rim = 1.0 - saturate(dot(normalize(IN.viewDir), o.Normal));
		o.Emission = _RimColor.rgb * pow(rim, _RimPower);
	}
	ENDCG
	}
		FallBack "Diffuse"
}
