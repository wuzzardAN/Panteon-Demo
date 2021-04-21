using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealtimeRanking : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform EndLine;
    [SerializeField] private Slider slider;

    private float maxDistance;

    void Start()
    {
        maxDistance = getDistance();
    }

    void Update()
    {
        if (Player.position.x <= maxDistance && Player.position.x <= EndLine.position.x)
        {
            float distance = 1 - (getDistance() / maxDistance);
            setProgress(distance);
        }
    }

    float getDistance()
    {
        return Vector3.Distance(Player.position, EndLine.position);
    }

    void setProgress(float p)
    {
        slider.value = p;
    }
}
