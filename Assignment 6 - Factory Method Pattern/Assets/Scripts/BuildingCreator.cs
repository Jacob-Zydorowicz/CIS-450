/*
 * Jacob Zydorowicz
 * BuildingCreator.cs
 * Assignment 6
 * creator of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BuildingCreator
{
    public abstract GameObject CreateBuildingPrefab(string type);
    public abstract GameObject AddBuildingScript(GameObject prefab, string type);
}
