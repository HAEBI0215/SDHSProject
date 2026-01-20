using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerBase : MonoBehaviour
{
    public virtual void Initialize()
    {
        Debug.Log($"{GetType().Name} Initialized");
    }
}
