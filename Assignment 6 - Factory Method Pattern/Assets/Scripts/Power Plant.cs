/*
 * Jacob Zydorowicz
 * Power Plant.cs
 * Assignment 6
 * Concrete product of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPlant : Building
{
    private void Start()
    {
        this.buildingType = "Power Plant";
        this.group = buildingGroup.INDUSTRY;
    }
}
