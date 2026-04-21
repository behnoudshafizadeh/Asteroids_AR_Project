using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.ARFoundation;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameState _gameState;

    private void Awake()
    {
        _gameState.Score = 0;
        _gameState.GameOver = false;
    }

    private void Update()
    {
        Time.timeScale = _gameState.GameSpeed;
    }
}
