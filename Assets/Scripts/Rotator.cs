using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    public Transform rotatorStick;
    public Vector3 rot;
    public float speed;

    void Start()
    {
        InvokeRepeating("Rotation", 0.2f, 0.5f);
    }

    void Rotation()
    {
        
        rotatorStick.DORotate(rot, speed, RotateMode.LocalAxisAdd);
    }
}
