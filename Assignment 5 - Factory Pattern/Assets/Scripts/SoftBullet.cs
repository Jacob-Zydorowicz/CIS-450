/*
 * Jacob Zydorowicz
 * SoftBullet.cs
 * Assignment 5 - Factory Pattern
 * One of three bullet types created in the factory 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftBullet : Bullet
{
    SoftBullet()
    {
        this.Speed = 15f;
        this.Type = "Soft";
        this.Damage = 50;
    }
  

    public float getSpeed()
    {
        return Speed;
    }
}
