﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class cameraShake : MonoBehaviour
{
    private void Start()
    {
        CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
    }
    IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }

    internal IEnumerator Shake(double v1, float v2)
    {
        throw new System.NotImplementedException();
    }
}
