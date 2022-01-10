using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class narcoticsUpgrade : MonoBehaviour
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

    

    
    void Awake()
    {



        


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    float z;
    
    

    void testOne()
    {
       GetComponentInChildren<Demo>().m_Frequency -= m_FrequencyAdd;
         


    }
    void RGBDecrease()
    {
        GetComponentInChildren<Demo>().m_RGBShiftFactor -= m_RGBShiftFactorAdd;
        GetComponentInChildren<Demo>().m_RGBShiftPower -= m_RGBShiftPowerAdd;

    }
    void ghostDecrease()
    {
        GetComponentInChildren<Demo>().m_GhostSeeRadius -= m_GhostSeeRadiusAdd;
        GetComponentInChildren<Demo>().m_GhostSeeMix -= m_GhostSeeMixAdd;
        GetComponentInChildren<Demo>().m_GhostSeeAmplitude -= m_GhostSeeAmplitudeAdd;
    }
    void DistortionDecrease()
    {
        GetComponentInChildren<Demo>().m_Frequency -= m_FrequencyAdd;
        GetComponentInChildren<Demo>().m_Period -= m_PeriodAdd;
        GetComponentInChildren<Demo>().m_Amplitude -= m_AmplitudeAdd;
    }
    void blurDecrease()
    {
        GetComponentInChildren<Demo>().m_BlurMin -= m_BlurMinAdd;
        GetComponentInChildren<Demo>().m_BlurMax -= m_BlurMaxAdd;
        GetComponentInChildren<Demo>().m_BlurSpeed -= m_BlurSpeedAdd;
    }
   
  
 
    public void DecreaseAll()
    {
        GetComponentInChildren<Demo>().m_BlurMin -= m_BlurMinAdd;
        GetComponentInChildren<Demo>().m_BlurMax -= m_BlurMaxAdd;
        GetComponentInChildren<Demo>().m_BlurSpeed -= m_BlurSpeedAdd;

        GetComponentInChildren<Demo>().m_Frequency -= m_FrequencyAdd;
        GetComponentInChildren<Demo>().m_Period -= m_PeriodAdd;
        GetComponentInChildren<Demo>().m_Amplitude -= m_AmplitudeAdd;

        GetComponentInChildren<Demo>().m_GhostSeeRadius -= m_GhostSeeRadiusAdd;
        GetComponentInChildren<Demo>().m_GhostSeeMix -= m_GhostSeeMixAdd;
        GetComponentInChildren<Demo>().m_GhostSeeAmplitude -= m_GhostSeeAmplitudeAdd;

        GetComponentInChildren<Demo>().m_RGBShiftFactor -= m_RGBShiftFactorAdd;
        GetComponentInChildren<Demo>().m_RGBShiftPower -= m_RGBShiftPowerAdd;
    }

}
