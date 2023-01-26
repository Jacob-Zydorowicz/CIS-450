/*
 * Jacob Zydorowicz
 * JumpBehavior.cs
 * Assingment 2 Strategy Design Patterns
 * Abstract JumpBehavior class to display strategy pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JumpBehavior : MonoBehaviour
{
    public abstract void jump();
}
