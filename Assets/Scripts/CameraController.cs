﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float smoothSpeed;
    public Vector3 offset;

    public void Awake()
    {
        TargetPlayer();
    }

    void TargetPlayer()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }
    
    void Update()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(target.transform);
    }
}
