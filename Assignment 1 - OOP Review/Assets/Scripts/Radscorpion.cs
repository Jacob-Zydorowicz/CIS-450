/*
 * Jacob Zydorowicz
 * Radscorpion.cs
 * Assignment 1 - OOP Review
 * Concrete radscorpion class to demonstrate OOP concepts
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radscorpion : Enemies, Walk, Sting
{
    private int damage;
    private int health;
    private string size;

    public void setSize(string size)
    {
        this.size = size;
    }

    public string getSize()
    {
        return size;
    }

    public void sting(int dmgAmount)
    {
        Debug.Log("The " + size + " radscorpion stings the player with it's tail for " + dmgAmount + " points of damage.");
    }

    public void walk()
    {
        Debug.Log("The " + size + " radscorpion moves forward.");
    }


    public Radscorpion() : base()
    {
        
    }

    public override int getDamage()
    {
        return damage;
    }

    public override int getHealth()
    {
        return health;
    }

    public override void setDamage(int damage)
    {
        this.damage = damage;
    }

    public override void setHealth(int health)
    {
        this.health = health;
    }

  
}
