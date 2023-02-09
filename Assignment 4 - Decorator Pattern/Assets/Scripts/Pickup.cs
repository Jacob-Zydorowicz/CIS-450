/*
 * Jacob Zydorowicz
 * Pickup.cs
 * Assignment 4 - Decorator Pattern
 * Defines power type for power ups
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PowerType {BULLETSPEED, BULLETSIZE }
    public PowerType powerType;
}
