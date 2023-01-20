/*
 * Jacob Zydorowicz
 * Human.cs
 * Assignment 1 - OOP Review
 * Concrete human class to demonstrate OOP concepts
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Enemies, Jump, Walk
{
    private int damage;
    private int health;

    public override int getDamage()
    {
        return damage;
    }

    public override int getHealth()
    {
        return health;
    }

   
    public void jump()
    {
        Debug.Log("The human jumps.");
    }

    public override void setDamage(int damage)
    {
        this.damage = damage;
    }

    public override void setHealth(int health)
    {
        this.health = health;
    }

    public void walk()
    {
        Debug.Log("The human moves forward.");
    }
}
