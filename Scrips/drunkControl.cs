using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drunkControl : MonoBehaviour
{
    [Header("RGB Shift Add")]
    [Range(0f, 0.05f)] public float m_RGBShiftFactorAdd = 0;
    [Range(0f, 16f)] public float m_RGBShiftPowerAdd = 3f;
    [Header("Ghost Add")]
    [Range(0f, 0.06f)] public float m_GhostSeeRadiusAdd = 0.01f;
    [Range(0f, 1f)] public float m_GhostSeeMixAdd = 0.5f;
    [Range(0f, 0.2f)] public float m_GhostSeeAmplitudeAdd = 0.05f;
    [Header("Distortion Add")]
    [Range(0f, 8f)] public float m_FrequencyAdd = 1f;
    [Range(0f, 4f)] public float m_PeriodAdd = 1.5f;
    [Range(0f, 16f)] public float m_AmplitudeAdd = 1f;
    [Header("Radial Blur Add")]
    [Range(0f, 1f)] public float m_BlurMinAdd = 0.1f;
    [Range(0f, 1f)] public float m_BlurMaxAdd = 0.3f;
    [Range(0f, 6f)] public float m_BlurSpeedAdd = 3f;
    [Header("SleepyEye Add")]
    public bool m_SleepyEyeAdd = false;
    [Range(0f, 0.9f)] public float m_EyeCloseAdd = 0.2f;

    firstPersonInputSystem inputManager;

    Demo demo;

    // Start is called before the first frame update
    void Start()
    {
        demo = GetComponentInChildren<Demo>();
    }
    public void increaseTolerance()
    {
        
        m_BlurMaxAdd -= .05f;
        m_BlurSpeedAdd -= .5f;

        m_FrequencyAdd -=.5f;
        m_PeriodAdd -= .3f;
        m_AmplitudeAdd -= .5f;

        m_GhostSeeRadiusAdd -= .002f;
        m_GhostSeeMixAdd -= .01f;
        m_GhostSeeAmplitudeAdd -= .001f;

        m_RGBShiftFactorAdd -= .002f;
        m_RGBShiftPowerAdd -= .5f;
    }

    void startDrunkFX()
    {
        demo.enabled = true;
        
    }
    void RGBIncrease()
    {
        demo.m_RGBShiftFactor += m_RGBShiftFactorAdd;
        demo.m_RGBShiftPower += m_RGBShiftPowerAdd;

    }
    void ghostIncrease()
    {
        demo.m_GhostSeeRadius += m_GhostSeeRadiusAdd;
        demo.m_GhostSeeMix += m_GhostSeeMixAdd;
        demo.m_GhostSeeAmplitude += m_GhostSeeAmplitudeAdd;
    }
    void DistortionIncrease()
    {
        demo.m_Frequency += m_FrequencyAdd;
        demo.m_Period += m_PeriodAdd;
        demo.m_Amplitude += m_AmplitudeAdd;
    }
    void blurIncrease()
    {
        demo.m_BlurMin += m_BlurMinAdd;
        demo.m_BlurMax += m_BlurMaxAdd;
        demo.m_BlurSpeed += m_BlurSpeedAdd;
    }
   
  
 
    public void increaseAll()
    {
        demo.m_BlurMin += m_BlurMinAdd;
        demo.m_BlurMax += m_BlurMaxAdd;
        demo.m_BlurSpeed += m_BlurSpeedAdd;

        demo.m_Frequency += m_FrequencyAdd;
        demo.m_Period += m_PeriodAdd;
        demo.m_Amplitude += m_AmplitudeAdd;

        demo.m_GhostSeeRadius += m_GhostSeeRadiusAdd;
        demo.m_GhostSeeMix += m_GhostSeeMixAdd;
        demo.m_GhostSeeAmplitude += m_GhostSeeAmplitudeAdd;

        demo.m_RGBShiftFactor += m_RGBShiftFactorAdd;
        demo.m_RGBShiftPower += m_RGBShiftPowerAdd;
    }
    void RGBDecrease()
    {
        demo.m_RGBShiftFactor -= m_RGBShiftFactorAdd;
        demo.m_RGBShiftPower -= m_RGBShiftPowerAdd;

    }
    void ghostDecrease()
    {
        demo.m_GhostSeeRadius -= m_GhostSeeRadiusAdd;
        demo.m_GhostSeeMix -= m_GhostSeeMixAdd;
        demo.m_GhostSeeAmplitude -= m_GhostSeeAmplitudeAdd;
    }
    void DistortionDecrease()
    {
        demo.m_Frequency -= m_FrequencyAdd;
        demo.m_Period -= m_PeriodAdd;
        demo.m_Amplitude -= m_AmplitudeAdd;
    }
    void blurDecrease()
    {
        demo.m_BlurMin -= m_BlurMinAdd;
        demo.m_BlurMax -= m_BlurMaxAdd;
        demo.m_BlurSpeed -= m_BlurSpeedAdd;
    }


    
    void DecreaseAll()
    {
        demo.m_BlurMin -= m_BlurMinAdd;
        demo.m_BlurMax -= m_BlurMaxAdd;
        demo.m_BlurSpeed -= m_BlurSpeedAdd;

        demo.m_Frequency -= m_FrequencyAdd;
        demo.m_Period -= m_PeriodAdd;
        demo.m_Amplitude -= m_AmplitudeAdd;

        demo.m_GhostSeeRadius -= m_GhostSeeRadiusAdd;
        demo.m_GhostSeeMix -= m_GhostSeeMixAdd;
        demo.m_GhostSeeAmplitude -= m_GhostSeeAmplitudeAdd;

        demo.m_RGBShiftFactor -= m_RGBShiftFactorAdd;
        demo.m_RGBShiftPower -= m_RGBShiftPowerAdd;
    }

   
}

