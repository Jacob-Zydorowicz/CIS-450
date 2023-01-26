/*
 * Jacob Zydorowicz
 * Fish.cs
 * Assingment 2 Strategy Design Patterns
 * Fish class that extends from abstract animal class to display strategy pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal
{
    private void Awake()
    {
        jumpBehavior = gameObject.AddComponent<CantJump>();
    }
}
