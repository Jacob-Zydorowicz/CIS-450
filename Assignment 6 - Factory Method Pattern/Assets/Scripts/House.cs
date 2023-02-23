/*
 * Jacob Zydorowicz
 * House.cs
 * Assignment 6
 * Concrete product of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : Building
{
    private void Start()
    {
        this.buildingType = "House";
        this.group = buildingGroup.HOUSING;
    }
}
