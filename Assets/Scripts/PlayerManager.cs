using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerManager : MonoBehaviour
{
    private InputManager inputManager;
    private CharacterContoller characterContoller;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        characterContoller = GetComponent<CharacterContoller>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
    }

    private void FixedUpdate()
    {
        characterContoller.HandleAllMovement();
    }
}
