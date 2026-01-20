using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommanderChildBase : MonoBehaviour
{
    public CommanderBase _commander;

    public virtual void Initialize(CommanderBase commander)
    {
        _commander = commander as TitleCommander;
    }
}
