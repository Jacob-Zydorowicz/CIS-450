/*
 * Jacob Zydorowicz
 * BulletFactory.cs
 * Assignment 5 - Factory Pattern
 * Creates different types of bullets using the factory design pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    public GameObject softBullet;
    public GameObject speedBullet;
    public GameObject spikedBullet;

    private GameObject shotBullet;
    
    public GameObject CreateBullet(string type)
    {
        shotBullet = null;

        if (type.Equals("Soft"))
        {
            shotBullet = softBullet;
        }
        else if (type.Equals("Speed"))
        {
            shotBullet = speedBullet;
        }
        else if (type.Equals("Spiked"))
        {
            shotBullet = spikedBullet;
        }

        Debug.Log("Factory sending: " + shotBullet);
        return shotBullet;
    }
}
