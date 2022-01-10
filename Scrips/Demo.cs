﻿using UnityEngine;
using System.Collections.Generic;

public class Demo : MonoBehaviour
{
	public Material m_Mat;
	[Header("RGB Shift")]
	[Range(0f, 0.05f)] public float m_RGBShiftFactor = 0;
	[Range(0f, 16f)] public float m_RGBShiftPower = 3f;
	[Header("Ghost")]
	[Range(0f, 0.06f)] public float m_GhostSeeRadius = 0.01f;
	[Range(0f, 1f)] public float m_GhostSeeMix = 0.5f;
	[Range(0f, 0.2f)] public float m_GhostSeeAmplitude = 0.05f;
	[Header("Distortion")]
	[Range(0f, 8f)] public float m_Frequency = 1f;
	[Range(0f, 4f)] public float m_Period = 1.5f;
	[Range(0f, 16f)] public float m_Amplitude = 1f;
	[Header("Radial Blur")]
	[Range(0f, 1f)] public float m_BlurMin = 0.1f;
	[Range(0f, 1f)] public float m_BlurMax = 0.3f;
	[Range(0f, 6f)] public float m_BlurSpeed = 3f;
	[Header("SleepyEye")]
	public bool m_SleepyEye = false;
	[Range(0f, 0.9f)] public float m_EyeClose = 0.2f;
	public enum EType { ET_Rotated = 0, ET_Splitted };
	public EType m_Type = EType.ET_Rotated;

    void Start ()
	{
		QualitySettings.antiAliasing = 8;
		
	}
	void Update ()
    {
		m_Mat.SetFloat ("_RGBShiftFactor", m_RGBShiftFactor);
		m_Mat.SetFloat ("_RGBShiftPower", m_RGBShiftPower);
		m_Mat.SetFloat ("_GhostSeeRadius", m_GhostSeeRadius);
		m_Mat.SetFloat ("_GhostSeeMix", m_GhostSeeMix);
		m_Mat.SetFloat ("_GhostSeeAmplitude", m_GhostSeeAmplitude);
//		float strength = Mathf.Sin (Time.time) * 0.5f + 0.5f + 0.1f;
		m_Mat.SetVector ("_Dimensions", new Vector4 (0.8f, m_EyeClose, 0f, 0f));
		m_Mat.SetFloat ("_Frequency", m_Frequency);
		m_Mat.SetFloat ("_Period", m_Period);
		m_Mat.SetFloat ("_RandomNumber", 1f);
		m_Mat.SetFloat ("_Amplitude", m_Amplitude);
		m_Mat.SetFloat ("_BlurMin", m_BlurMin);
		m_Mat.SetFloat ("_BlurMax", m_BlurMax);
		m_Mat.SetFloat ("_BlurSpeed", m_BlurSpeed);
		m_Frequency = Mathf.Clamp(m_Frequency, 0f, 8f);
		m_RGBShiftFactor = Mathf.Clamp(m_RGBShiftFactor, 0f, 0.05f);
		m_RGBShiftPower = Mathf.Clamp(m_RGBShiftPower, 0f, 16f);
		m_RGBShiftPower = Mathf.Clamp(m_RGBShiftPower, 0f, 16f);
		m_GhostSeeRadius = Mathf.Clamp(m_GhostSeeRadius, 0f, 0.06f);
		m_GhostSeeMix = Mathf.Clamp(m_GhostSeeMix, 0f, 1f);
		m_GhostSeeAmplitude = Mathf.Clamp(m_GhostSeeAmplitude, 0f, 0.2f);
		m_Period = Mathf.Clamp(m_Period, 0f, 4f);
		m_Amplitude = Mathf.Clamp(m_Amplitude, 0f, 16f);
		m_BlurMin = Mathf.Clamp(m_BlurMin, 0f, 1f);
		m_BlurMax = Mathf.Clamp(m_BlurMax, 0f, 1f);
		m_BlurSpeed = Mathf.Clamp(m_BlurSpeed, 0f, 6f);
	}
	void OnRenderImage (RenderTexture src, RenderTexture dst)
	{
		RenderTexture rt1 = RenderTexture.GetTemporary (Screen.width, Screen.height, 0);
		RenderTexture rt2 = RenderTexture.GetTemporary (Screen.width, Screen.height, 0);
		
		Graphics.Blit (src, rt1, m_Mat, 0);
		if (EType.ET_Rotated == m_Type)
		{
			if (m_SleepyEye)
			{
				Graphics.Blit (rt1, rt2, m_Mat, 1);
				Graphics.Blit (rt2, rt1, m_Mat, 4);
				Graphics.Blit (rt1, rt2, m_Mat, 5);
				Graphics.Blit (rt2, dst, m_Mat, 3);
			}
			else
			{
				Graphics.Blit (rt1, rt2, m_Mat, 1);
				Graphics.Blit (rt2, rt1, m_Mat, 4);
				Graphics.Blit (rt1, dst, m_Mat, 5);
			}
		}
		else
		{
			if (m_SleepyEye)
			{
				Graphics.Blit (rt1, rt2, m_Mat, 2);
				Graphics.Blit (rt2, rt1, m_Mat, 4);
				Graphics.Blit (rt1, rt2, m_Mat, 5);
				Graphics.Blit (rt2, dst, m_Mat, 3);
			}
			else
			{
				Graphics.Blit (rt1, rt2, m_Mat, 2);
				Graphics.Blit (rt2, rt1, m_Mat, 4);
				Graphics.Blit (rt1, dst, m_Mat, 5);
			}
		}
		RenderTexture.ReleaseTemporary (rt1);
		RenderTexture.ReleaseTemporary (rt2);
	}
//	void OnGUI ()
//	{
//		int w = 350;
//		if (EType.ET_Rotated == m_Type)
//			GUI.Box (new Rect (Screen.width / 2 - w / 2, 10, w, 25), "Drunk Man Demo --- Rotated Double Image");
//		else
//			GUI.Box (new Rect (Screen.width / 2 - w / 2, 10, w, 25), "Drunk Man Demo --- Splitted Double Image");
//	}
}