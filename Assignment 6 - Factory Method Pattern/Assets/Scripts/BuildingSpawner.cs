/*
 * Jacob Zydorowicz
 * BuildingSpawner.cs
 * Assignment 6
 * Spawns concrete products using factory method creators
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public float spawnDistance;
    private Transform playerOrCameraTransform;

    public BuildingCreator buildingCreator;

    public List<GameObject> industrial;
    public List<GameObject> houses;

    public bool isHousing;



    // Start is called before the first frame update
    void Start()
    {
        spawnDistance = 20f;
        playerOrCameraTransform = Camera.main.transform;

        buildingCreator = new HousingCreator();
        isHousing = true;
    }

    public GameObject SpawnBuilding(string type)
    {
        GameObject building = null;

        //Assign prefab to npc
        building = buildingCreator.CreateBuildingPrefab(type);

        //Set the spawn position
        float xRand = Random.Range(-30, 30);
        float zRand = Random.Range(-30, 30);
        Vector3 spawnPos = playerOrCameraTransform.position +
                           playerOrCameraTransform.forward * spawnDistance +
                           new Vector3(xRand, 0, zRand);

        //Spawn the npc and assign the instance to npcInstance
        GameObject buildingInstance = Instantiate(building, spawnPos, playerOrCameraTransform.rotation);

        //Add script to our npc instance
        buildingCreator.AddBuildingScript(buildingInstance, type);


        //return the npc instance
        return buildingInstance;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
          
            if (isHousing)
            {
                buildingCreator = new IndustryCreator();
                isHousing = false;
            }
            else
            {
                buildingCreator = new HousingCreator();
                isHousing = true;
            }

        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (isHousing)
            {
                houses.Add(SpawnBuilding("House"));
            }
            else
            {
                industrial.Add(SpawnBuilding("Factory"));
            }

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (isHousing)
            {
                houses.Add(SpawnBuilding("Apartment"));
            }
            else
            {
                industrial.Add(SpawnBuilding("Power Plant"));
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (isHousing)
            {
                houses.Add(SpawnBuilding("Mobile Home"));
            }
            else
            {
                industrial.Add(SpawnBuilding("Skyscraper"));
            }
        }

       

    }
}

