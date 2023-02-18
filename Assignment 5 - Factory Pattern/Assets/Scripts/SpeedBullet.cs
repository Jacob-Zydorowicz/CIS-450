/*
 * Jacob Zydorowicz
 * SpeedBullet.cs
 * Assignment 5 - Factory Pattern
 * One of three bullet types created in the factory 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBullet : Bullet
{
    SpeedBullet()
    {
        this.Speed = 25f;
        this.Type = "Speed";
        this.Damage = 25;
    }
    public float getSpeed()
    {
        return Speed;
    }
}
