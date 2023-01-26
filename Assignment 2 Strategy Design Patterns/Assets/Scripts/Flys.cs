/*
 * Jacob Zydorowicz
 * Fly.cs
 * Assingment 2 Strategy Design Patterns
 * Fly class that extends from JumpBehavior abstract class to display strategy pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flys : JumpBehavior
{
    
    public override void jump()
    {
        
        Debug.Log("The animal flew");
        StartCoroutine(fly());
    }

    IEnumerator fly()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        yield return new WaitForSeconds(1f);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 5f, ForceMode.Impulse);
        yield return new WaitForSeconds(1f);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 5f, ForceMode.Impulse);
        yield return new WaitForSeconds(1f);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 5f, ForceMode.Impulse);

    }
}
