/*
 * Jacob Zydorowicz
 * Fire.cs
 * Assignment 4 - Decorator Pattern
 * Uses the information from the decorator to change bullet speed and size.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectile;
    private Rigidbody clone;
    public int projectileSpeed = 1;
    Vector3 projectileStartPos;

    private void Start()
    {
        projectile.transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            spawnProjectile();
        }

    

    }

    private void spawnProjectile()
    {
        
        projectileStartPos = transform.position;
        clone = Instantiate(projectile.GetComponent<Rigidbody>(), projectileStartPos, transform.rotation);

        clone.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);

        

    }
}
