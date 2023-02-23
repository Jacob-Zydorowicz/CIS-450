/*
 * Jacob Zydorowicz
 * Building.cs
 * Assignment 6
 * product of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public enum buildingGroup { HOUSING, INDUSTRY }

    public buildingGroup group;
    public string buildingType;
}
