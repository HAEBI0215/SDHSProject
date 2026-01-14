using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerManager pm;

    private void Awake()
    {
        pm = GetComponent<PlayerManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool jump = Input.GetButtonDown("Jump");

        pm.MoveInput(horizontal, vertical);
        if(jump)
            pm.JumpInput();
    }
}
