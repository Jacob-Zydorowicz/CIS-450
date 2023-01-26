/*
 * Jacob Zydorowicz
 * Dog.cs
 * Assingment 2 Strategy Design Patterns
 * Dog class that extends from abstract animal class to display strategy pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private void Awake()
    {
        jumpBehavior = gameObject.AddComponent<Jumps>();
    }
}
