/*
 * Jacob Zydorowicz
 * Gecko.cs
 * Assignment 1 - OOP Review
 * Concrete gecko class to demonstrate OOP concepts
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gecko : Enemies, Jump, Walk
{
    private int damage;
    private int health;
    private string species;

    public override int getDamage()
    {
        return damage;
    }

    public override int getHealth()
    {
        return health;
    }

    public void setSpecies(string species)
    {
        this.species = species;
    }

    public string getSpecies()
    {
        return species;
    }

    public void jump()
    {
        Debug.Log("The " + species + "gecko jumps.");
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
        Debug.Log("The " + species + "gecko moves forward.");
    }
}
