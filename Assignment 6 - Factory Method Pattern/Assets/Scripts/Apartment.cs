/*
 * Jacob Zydorowicz
 * Apartment.cs
 * Assignment 6
 * Concrete product of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apartment : Building
{
    private void Start()
    {
        this.buildingType = "Apartment";
        this.group = buildingGroup.HOUSING;
    }
}
