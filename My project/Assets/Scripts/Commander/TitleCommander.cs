using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class TitleCommander : CommanderBase
{
    private CommanderChildBase[] _childCommanders;

    private void Awake()
    {
        foreach (var childCommander in _childCommanders)
        {
            childCommander.Initialize(this);
        }
    }

    public void StartGame()
    { 
        Managers.Game.SetState(GameManage.GameState.Game);
    }
}
