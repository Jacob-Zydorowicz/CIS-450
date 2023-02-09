/*
 * Jacob Zydorowicz
 * PowerBulletSpeedUp.cs
 * Assignment 4 - Decorator Pattern
 * Uses the decorator abstract class to encapsulate and decorate the player with power ups
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBulletSpeedUp : PlayerDecorator
{
    public Powers playerPowers;
    public PowerBulletSpeedUp(Powers playerPowers)
    {
        this.playerPowers = playerPowers;
    }
    public override int speed
    {
        get
        {
        
            return playerPowers.speed + 5;

        }
        set
        {
            playerPowers.speed = value;
        }
    }
    public override float size { get; set; }
    
}
