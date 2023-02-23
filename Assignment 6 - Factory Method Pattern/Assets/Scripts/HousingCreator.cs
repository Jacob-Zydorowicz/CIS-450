/*
 * Jacob Zydorowicz
 * HousingCreator.cs
 * Assignment 6
 * Concrete creator of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousingCreator : BuildingCreator
{
    private GameObject housingPrefab;

    public override GameObject AddBuildingScript(GameObject prefab, string type)
    {
        if (type.Equals("House"))
                prefab.AddComponent<House>();
        else if (type.Equals("Apartment"))
                prefab.AddComponent<Apartment>();
        else if (type.Equals("Mobile Home"))
                prefab.AddComponent< MobileHome > ();
          
        return prefab;

    }

    public override GameObject CreateBuildingPrefab(string type)
    {
        if (type.Equals("House"))
            housingPrefab = Resources.Load<GameObject>("Prefabs/House");
        else if (type.Equals("Apartment"))
            housingPrefab = Resources.Load<GameObject>("Prefabs/Apartment");
        else if (type.Equals("Mobile Home"))
            housingPrefab = Resources.Load<GameObject>("Prefabs/Mobile Home");

        return housingPrefab;

    }
}
