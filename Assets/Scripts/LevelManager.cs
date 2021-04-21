using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public RectTransform winPanel;
    public RectTransform losePanel;
    public GameObject startPanel;

    public void Start()
    {
        Time.timeScale = 0.01F;
    }

    public void StartGame()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LostGame()
    {
        losePanel.DOAnchorPos(Vector2.zero, 1, true);
        FindObjectOfType<Respawn>().RespawnPlayers();
    }
    
    public void WinGame()
    {
        winPanel.DOAnchorPos(Vector2.zero, 1, true);
        FindObjectOfType<Respawn>().RespawnPlayers();
        
    }
}
