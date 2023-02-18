/*
 * Jacob Zydorowicz
 * SpikedBullet.cs
 * Assignment 5 - Factory Pattern
 * One of three bullet types created in the factory 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedBullet : Bullet
{
    SpikedBullet()
    {
        this.Speed = 5f;
        this.Type = "Spiked";
        this.Damage = 100;
    }


    public float getSpeed()
    {
        return Speed;
    }
}
