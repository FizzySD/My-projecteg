using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : NetworkBehaviour
{
    [Header("Controls")]
    public KeyCode sprintKey = KeyCode.LeftShift;
    public KeyCode jumpkey = KeyCode.Space;
    public KeyCode crouchKey = KeyCode.LeftControl;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
