using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TitleUI : TitleCommanderChildBase
{
    [SerializeField]
    private Button _startButton;

    public override void Initialize(CommanderBase commander)
    {
        base.Initialize(commander);
        _startButton.onClick.AddListener(OnStartButtonClicked);
    }

    private void OnStartButtonClicked()
    {
        _titleCommander.StartGame();
    }
}
