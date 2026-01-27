using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCommander : MonoBehaviour
{
    private int _score;
    private bool _isPlaying;

    private void Awake()
    {
        _isPlaying = true;
    }

    private void Update()
    {
        if ( _isPlaying == false)
            return;


    }
}
