/*
 * Jacob Zydorowicz
 * PlayerMovement.cs
 * Assignment 5 - Factory Pattern
 * Player movement and firing script
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horiztonalInput;
    private float verticalInput;
    int speed = 5;


    public BulletFactory factory;

    private GameObject bullet;
    private Rigidbody bulletRB;
 
    // Update is called once per frame
    void Update()
    {
        //player movement
        horiztonalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * horiztonalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FireBullet("Soft");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FireBullet("Speed");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            FireBullet("Spiked");
        }
    }

    //method that uses the factory class to create different bullets using the factory design pattern
    public void FireBullet(string type)
    {
        Rigidbody bulletRB;
        float bulletSpeed = 0;
        Debug.Log("Type passed in: " + type);
        bullet = factory.CreateBullet(type);
        Debug.Log(bullet);


        Vector3 bulletStartPos = transform.position;
      
        GameObject bulletInstance = Instantiate(bullet, bulletStartPos, transform.rotation);


        if (type.Equals("Soft"))
        {
            bulletInstance.AddComponent<SoftBullet>();
            bulletSpeed = bulletInstance.GetComponent<SoftBullet>().getSpeed();
            Debug.Log(bulletInstance.GetComponent<SoftBullet>().getSpeed());
        }
        else if (type.Equals("Speed"))
        {
            bulletInstance.AddComponent<SpeedBullet>();
            bulletSpeed = bulletInstance.GetComponent<SpeedBullet>().getSpeed();
        }
        else if (type.Equals("Spiked"))
        {
            bulletInstance.AddComponent<SpikedBullet>();
            bulletSpeed = bulletInstance.GetComponent<SpikedBullet>().getSpeed();
        }

        bulletRB = bulletInstance.GetComponent<Rigidbody>();
        bulletRB.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);
    }
}

