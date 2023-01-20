/*
 * Jacob Zydorowicz
 * Enemies.cs
 * Assignment 1 - OOP Review
 * Abstract class Enemies to demonstrate OOP concepts
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemies 
{


    private int health;
    private int damage;

    public abstract int getHealth();
    public abstract void setHealth(int health);
    public abstract int getDamage();
    public abstract void setDamage(int damage);

}
