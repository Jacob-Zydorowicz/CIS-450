/*
 * Jacob Zydorowicz
 * Skyscraper.cs
 * Assignment 6
 * Concrete product of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyscraper : Building
{
    private void Start()
    {
        this.buildingType = "Skyscraper";
        this.group = buildingGroup.INDUSTRY;
    }
}
