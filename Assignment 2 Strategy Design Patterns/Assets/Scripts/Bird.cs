/*
 * Jacob Zydorowicz
 * Bird.cs
 * Assingment 2 Strategy Design Patterns
 * Bird class that extends from abstract animal class to display strategy pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private void Awake()
    {
        jumpBehavior = gameObject.AddComponent<Flys>();
    }
}
