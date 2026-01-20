using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TitleCommanderChildBase : CommanderChildBase
{
    protected TitleCommander _titleCommander;

    public override void Initialize(CommanderBase commander)
    {
        base.Initialize(commander);
        _titleCommander = commander as TitleCommander;
    }
}
