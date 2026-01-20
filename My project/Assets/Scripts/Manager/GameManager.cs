using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : ManagerBase
{
    public enum GameState
    {
        Loading,
        Title,
        Game,
        Result
    }

    private GameState _currentState = GameState.Loading;

    public void SetState(GameState newState)
    {
        _currentState = newState;
        SceneManager.LoadScene(_currentState.ToString());
    }

    public override void Initialize()
    {
        base.Initialize();
    }
}
