/*
 * Jacob Zydorowicz
 * Power.cs
 * Assignment 4 - Decorator Pattern
 * Allows the player to be decorated by the powers
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers 
{
    public virtual int speed { get; set; } = 20;
    public virtual float size { get; set; } = 1;
}
