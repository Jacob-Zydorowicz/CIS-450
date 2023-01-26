/*
 * Jacob Zydorowicz
 * Animal.cs
 * Assingment 2 Strategy Design Patterns
 * Abstract animal class to display strategy pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public JumpBehavior jumpBehavior;


    public virtual void performJump()
    {
        jumpBehavior.jump();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            performJump();
        }
    }


}

