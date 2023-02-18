/*
 * Jacob Zydorowicz
 * Bullet.cs
 * Assignment 5 - Factory Pattern
 * Bullet class used to create different bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected string Type { get; set; }
    protected int Damage { get; set; }
    protected float Speed { get; set; }
}
