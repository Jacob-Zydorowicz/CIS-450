/*
 * Jacob Zydorowicz
 * CantJump.cs
 * Assingment 2 Strategy Design Patterns
 * CantJump class that extends from JumpBehavior abstract class to display strategy pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantJump : JumpBehavior
{
    private bool spin = false;
    public override void jump()
    {
        Debug.Log("The animal can't jump.");
        spin = true;
        StartCoroutine(cantJump());
    }



    IEnumerator cantJump()
    {
        yield return new WaitForSeconds(1f);
        spin = false;
        gameObject.transform.Rotate(0f, 0f, 0f, Space.Self);
    }

    private void Update()
    {
        if(spin)
        {
            gameObject.transform.Rotate(1f, 0f, 0f, Space.Self);
        }
    }
}
