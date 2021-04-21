using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HalfDonut : MonoBehaviour
{
    public Transform halfDonut;
    public float speed;
    public Ease animEase;

    void Start()
    {
        speed = Random.Range(1f, 2f);
        HalfDonutMoveX();   
    }

    void HalfDonutMoveX()
    {
        halfDonut.DOLocalMoveX(-0.1f, speed)
            .SetEase(animEase)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
