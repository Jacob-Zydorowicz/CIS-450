/*
 * Jacob Zydorowicz
 * IndustryCreator.cs
 * Assignment 6
 * Concrete creator of factoy method pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndustryCreator : BuildingCreator
{
    private GameObject industryPrefab;

    public override GameObject AddBuildingScript(GameObject prefab, string type)
    {
        if (type.Equals("Factory"))
        {

            //If there is not already a Zombie script attached to the prefab, attach one
            if (prefab.GetComponent<Factory>() == null)
            {
                prefab.AddComponent<Factory>();
            }
        }
        else if (type.Equals("Skyscraper"))
        {

            //If there is not already a Vampire script attached to the prefab, attach one
            if (prefab.GetComponent<Skyscraper>() == null)
            {
                prefab.AddComponent<Skyscraper>();
            }

        }
        else if (type.Equals("Power Plant"))
        {

            //If there is not already a Werewolf script attached to the prefab, attach one
            if (prefab.GetComponent<PowerPlant>() == null)
            {
                prefab.AddComponent<PowerPlant>();
            }
        }

        return prefab;

    }

    public override GameObject CreateBuildingPrefab(string type)
    {
        if (type.Equals("Factory"))
        {
            industryPrefab = Resources.Load<GameObject>("Prefabs/Factory");
        }
        else if (type.Equals("Skyscraper"))
        {
            industryPrefab = Resources.Load<GameObject>("Prefabs/Skyscraper");
        }
        else if (type.Equals("Power Plant"))
        {
            industryPrefab = Resources.Load<GameObject>("Prefabs/Power Plant");
        }

        return industryPrefab;

    }
}
