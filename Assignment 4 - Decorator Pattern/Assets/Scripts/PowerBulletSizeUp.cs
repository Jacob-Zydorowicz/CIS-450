/*
 * Jacob Zydorowicz
 * PowerBulletSizeUp.cs
 * Assignment 4 - Decorator Pattern
 * Uses the decorator abstract class to encapsulate and decorate the player with power ups
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBulletSizeUp : PlayerDecorator
{
    public Powers playerPowers;
    public PowerBulletSizeUp(Powers playerPowers)
    {
        this.playerPowers = playerPowers;
    }
    public override float size
    {
        get
        {
           
            return playerPowers.size + 0.25f;

        }
        set
        {
            playerPowers.size = value;
        }
    }
    public override int speed { get; set; }
}
