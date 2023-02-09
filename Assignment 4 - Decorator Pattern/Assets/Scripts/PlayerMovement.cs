/*
 * Jacob Zydorowicz
 * PlayerMovement.cs
 * Assignment 4 - Decorator Pattern
 * Player movement script
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horiztonalInput;
    private float verticalInput;
    int speed = 5;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        horiztonalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Transform with input
        transform.Translate(Vector3.forward * horiztonalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
    }
}
