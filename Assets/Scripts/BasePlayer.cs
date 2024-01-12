using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MovementSystem
{
    private Interactor interactor;
    void Start()
    {
        if(isLocalPlayer) 
        {
            interactor = GetComponentInChildren<Interactor>();
            interactor.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        base.HandleMovement();
    }
}
