using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FinishGame : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Opponent")
        {
            FindObjectOfType<LevelManager>().LostGame();
        }

        if (other.tag == "Player")
        {
            FindObjectOfType<LevelManager>().WinGame();
        }
    }


    
}
