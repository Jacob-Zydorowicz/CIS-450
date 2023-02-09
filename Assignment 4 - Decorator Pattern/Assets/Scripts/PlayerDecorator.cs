/*
 * Jacob Zydorowicz
 * PlayerDecorator.cs
 * Assignment 4 - Decorator Pattern
 * Decorator abstract class that decorates components
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerDecorator : Powers
{
    public override abstract int speed { get; set; }
    public override abstract float size { get; set; }
}
