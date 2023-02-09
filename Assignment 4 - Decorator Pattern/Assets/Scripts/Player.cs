/*
 * Jacob Zydorowicz
 * Player.cs
 * Assignment 4 - Decorator Pattern
 * Decides how player is decroated based on collisions
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Powers powers;
    public Fire firingScript;

    //this reference is set in the inspector


    private void Awake()
    {
        powers = new Powers();
    }


    private void OnTriggerEnter(Collider other)
    {
        Pickup pickup = other.gameObject.GetComponent<Pickup>();
        if (pickup != null)
        {
            AddPlayerDecorator(pickup);
        }
    }

    private void AddPlayerDecorator(Pickup pickup)
    {

        switch (pickup.powerType)
        {
            case Pickup.PowerType.BULLETSIZE:
                powers = new PowerBulletSizeUp(powers);
                firingScript.projectile.GetComponent<Transform>().localScale = new Vector3(powers.size, powers.size, powers.size);
                break;
            case Pickup.PowerType.BULLETSPEED:
                powers = new PowerBulletSpeedUp(powers);
                firingScript.projectileSpeed = powers.speed;
                break;
            default:
                break;
        }



    }
}
