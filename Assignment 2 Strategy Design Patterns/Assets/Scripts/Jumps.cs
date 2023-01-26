/*
 * Jacob Zydorowicz
 * Jump.cs
 * Assingment 2 Strategy Design Patterns
 * Jump class that extends from JumpBehavior abstract class to display strategy pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumps : JumpBehavior
{
    public override void jump()
    {
        Debug.Log("The animal jumped");
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }

}
