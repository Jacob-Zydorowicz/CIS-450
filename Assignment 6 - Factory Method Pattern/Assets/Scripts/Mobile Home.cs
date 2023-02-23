/*
 * Jacob Zydorowicz
 * Mobile Home.cs
 * Assignment 6
 * Concrete product of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileHome : Building
{
    private void Start()
    {
        this.buildingType = "Mobile Home";
        this.group = buildingGroup.HOUSING;
    }
}
