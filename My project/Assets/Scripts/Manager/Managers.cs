using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public static GameManage Game { get; private set; }
    private ManagerBase[] _manager;

    private void Awake()
    {
        _manager = new ManagerBase[]
        {
            Game = GetComponent<GameManage>(),
        };

        foreach (var manager in _manager)
        {
            manager.Initialize();
        }

        Game.SetState(GameManage.GameState.Title);
    }
}
