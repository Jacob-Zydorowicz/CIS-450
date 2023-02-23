/*
 * Jacob Zydorowicz
 * Factory.cs
 * Assignment 6
 * Concrete product of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : Building
{
    private void Start()
    {
        this.buildingType = "Factory";
        this.group = buildingGroup.INDUSTRY;
    }
}
